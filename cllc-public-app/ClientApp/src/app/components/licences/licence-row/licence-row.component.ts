import { Component, OnInit, Input } from '@angular/core';
import { forkJoin, Subscription } from 'rxjs';
import { MatSnackBar } from '@angular/material';
import { LicenseDataService } from '@app/services/license-data.service';
import { Router } from '@angular/router';
import { ApplicationTypeNames } from '@models/application-type.model';
import { FormBase } from '@shared/form-base';
import { takeWhile } from 'rxjs/operators';
import { ApplicationLicenseSummary } from '@models/application-license-summary.model';
import * as moment from 'moment';
import { PaymentDataService } from '@services/payment-data.service';
import { EstablishmentDataService } from '@services/establishment-data.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Establishment } from '@models/establishment.model';
import { LicenceEventsService } from '@services/licence-events.service';
import { EventStatus, LicenceEvent, EventCategory } from '@models/licence-event.model';
import { License } from '@models/license.model';
import { TermsAndConditionsDataService } from '@services/terms-and-condtions-data.service';


export const UPLOAD_FILES_MODE = 'UploadFilesMode';
export const CRS_RENEWAL_LICENCE_TYPE_NAME = 'crs';
export const LIQUOR_RENEWAL_LICENCE_TYPE_NAME = 'liquor';


const ACTIVE = 'Active';
const RENEWAL_DUE = 'Renewal Due';
const NOW = moment(new Date()).startOf('day');

@Component({
  selector: 'app-licence-row',
  templateUrl: './licence-row.component.html',
  styleUrls: ['./licence-row.component.scss']
})
export class LicenceRowComponent extends FormBase implements OnInit {
  mainForm: FormGroup;
  busy: Subscription;
  licenceForms = {};
  eventStatus = EventStatus;
  eventCategory = EventCategory;

  @Input() available: boolean;
  @Input() licenceType: string;
  @Input() licences: ApplicationLicenseSummary[];

  constructor(
    private licenceDataService: LicenseDataService,
    private router: Router,
    private snackBar: MatSnackBar,
    private paymentService: PaymentDataService,
    private establishmentService: EstablishmentDataService,
    private licenceEventsService: LicenceEventsService,
    private termsAndConditionsService: TermsAndConditionsDataService,
    public fb: FormBuilder) {
    super();
    this.mainForm = new FormGroup({});
  }

  ngOnInit() {
    this.licences.forEach((licence) => {
      this.licenceForms[licence.licenseId] = this.fb.group({
        phone: [licence.establishmentPhoneNumber],
        email: [licence.establishmentEmail]
      });
      licence.termsAndConditionsBusy = this.termsAndConditionsService.getTermsAndCondtions(licence.licenseId)
        .subscribe((terms) => {
          licence.termsAndConditions = terms;
          if (terms.length > 0) {
            licence.headerRowSpan += 1;
          }
        });
    });
  }

  updateEmail(licenceId: string, establishmentId: string, event: any) {
    if (event.target.value === null) {
      return false;
    }

    const establishment = {
      id: establishmentId,
      email: event.target.value,
      phone: null,
      isOpen: null
    };

    const licence = Object.assign(new ApplicationLicenseSummary(), {
      licenseId: licenceId,
      establishmentEmail: event.target.value
    });

    this.updateEstablishment(establishment);
    this.sendUpdateLicence(licence);
  }

  updatePhone(licenceId: string, establishmentId: string, event: any) {
    if (event.target.value === null || typeof this.licenceForms[licenceId] === 'undefined') {
      return false;
    }

    const phone = this.licenceForms[licenceId].controls['phone'].value;

    const establishment = {
      id: establishmentId,
      email: null,
      phone: phone,
      isOpen: null
    };

    const licence = Object.assign(new ApplicationLicenseSummary(), {
      licenseId: licenceId,
      establishmentPhoneNumber: phone
    });

    this.updateEstablishment(establishment);
    this.sendUpdateLicence(licence);
  }

  sendUpdateLicence(licence: ApplicationLicenseSummary) {
    this.busy = forkJoin([
      this.licenceDataService.updateLicenceEstablishment(licence.licenseId, licence)
    ])
      .subscribe(([licenceResp]) => {
        if (this.licenceTypeHasEvents(licence.licenceTypeName)) {
          forkJoin([
            this.licenceEventsService.getLicenceEventsList(licenceResp.licenseId, 10)
          ])
            .subscribe(data => {
              licenceResp.events = data[0];
              this.updateLicence(licenceResp);
            });
        } else {
          this.updateLicence(licenceResp);
        }
      });
  }

  updateLicence(licence: ApplicationLicenseSummary) {
    const licenceIndex = this.licences.findIndex(l => l.licenseId === licence.licenseId);
    if (licenceIndex >= 0) {
      this.licences[licenceIndex] = licence;
    }
  }

  updateEstablishment(establishment: Establishment) {
    this.busy = this.establishmentService.upEstablishment(establishment).subscribe();
  }

  actionsVisible(licence: ApplicationLicenseSummary) {
    if (licence.licenceTypeCategory === 'Liquor'
      && (licence.transferRequested && !licence.licenceTypeName.toLowerCase().includes('deemed - '))
      || this.isExpired(licence)) {
      return false;
    }
    return true;
  }

  showLicenceTransferAction(item: ApplicationLicenseSummary) {
    const result = this.isActive(item)
      && !item.transferRequested
      && this.actionsVisible(item)
      && item.licenceTypeName !== 'Section 119 Authorization';
    return result;
  }


  showAddOrChangeThirdPartyOperator(item: ApplicationLicenseSummary): boolean {
    const result = this.isActive(item)
      && this.actionsVisible(item)
      && !item.tpoRequested
      && item.licenceTypeCategory === 'Liquor';
    return result;
  }

  actionVisible(licence: License, actionId: string) {
    return !this.hasEndorsement(licence, actionId);
  }

  payLicenceFee(licence: ApplicationLicenseSummary) {
    // locate the application associated with the issuance of this licence
    const application = licence.actionApplications.find(app => app.applicationTypeName === licence.licenceTypeName);
    if (application) {
      this.busy = this.paymentService.getInvoiceFeePaymentSubmissionUrl(application.applicationId)
        .pipe(takeWhile(() => this.componentActive))
        .subscribe(res => {
          const data = <any>res;
          window.location.href = data.url;
        }, err => {
          if (err._body === 'Payment already made') {
            this.snackBar.open('Licence Fee payment has already been made.', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
          }
        });
    }
  }

  planStoreOpening(licence: ApplicationLicenseSummary) {
    const application = licence.actionApplications.find(app => app.applicationTypeName === licence.applicationTypeName);
    if (application) {
      this.router.navigate([`/store-opening/${application.applicationId}`]);
    } else {
      this.snackBar.open('Unable to find Application', 'Fail',
        { duration: 3500, panelClass: ['red-snackbar'] });
    }
  }

  toggleStoreOpen(index: number, establishmentId: string, isOpen: boolean) {
    const establishment = {
      id: establishmentId,
      isOpen: isOpen,
      phone: null,
      email: null
    };

    this.busy = forkJoin([
      this.establishmentService.upEstablishment(establishment)
    ])
      .subscribe(([establishmentResp]) => {
        this.licences[index].establishmentIsOpen = establishmentResp.isOpen;
      });
  }

  isExpired(licence: ApplicationLicenseSummary) {
    return NOW.diff(moment(licence.expiryDate).startOf('day')) > 0;
  }

  isAboutToExpire(licence: ApplicationLicenseSummary) {
    if (!this.isExpired(licence)) {
      const expiry = moment(licence.expiryDate).startOf('day');
      const diff = expiry.diff(NOW, 'days');
      return diff <= 60;
    } else {
      return false;
    }
  }

  isRecentlyExpired(licence: ApplicationLicenseSummary) {
    if (this.isExpired(licence)) {
      const expiry = moment(licence.expiryDate).startOf('day');
      const diff = NOW.diff(expiry, 'days');
      return diff <= 30;
    }
    return false;
  }

  isCancelled(licence: ApplicationLicenseSummary) {
    const expiry = moment(licence.expiryDate).startOf('day');
    const diff = expiry.diff(NOW, 'days');
    return diff >= 180 || licence.status === 'Cancelled';
  }

  isActive(licence: ApplicationLicenseSummary) {
    let active = licence.status === 'Active';
    if (licence.suspended) {
      active = false;
    }
    return active;
  }

  isActiveOrRecentlyExpired(licence: ApplicationLicenseSummary) {
    return this.isRecentlyExpired(licence) || this.isActive(licence);
  }

  doAction(licence: ApplicationLicenseSummary, actionName: string) {
    const actionApplication = licence.actionApplications.find(
      app => app.applicationTypeName === actionName && app.applicationStatus !== 'Active');
    if (actionApplication && !actionApplication.isPaid) {
      this.router.navigateByUrl('/account-profile/' + actionApplication.applicationId);
    } else if (actionApplication && actionApplication.isPaid) {
      this.snackBar.open(`${actionName} has already been submitted and is under review`, 'Warning',
        { duration: 3500, panelClass: ['red-snackbar'] });
    } else {
      this.busy = this.licenceDataService.createApplicationForActionType(licence.licenseId, actionName)
        .pipe(takeWhile(() => this.componentActive))
        .subscribe(data => {
          this.router.navigateByUrl('/account-profile/' + data.id);
        },
          () => {
            this.snackBar.open(`Error running licence action for ${actionName}`, 'Fail',
              { duration: 3500, panelClass: ['red-snackbar'] });
          }
        );
    }
  }

  startRenewal(licence: ApplicationLicenseSummary) {
    // there are three type of renewals;
    // CRS Renewals
    // Cannabis Marketing Renewals
    // Liquor Renewals

    // use a renewal type to direct to the right renewal application form (crs or liquor)
    let renewalType;
    // used to find an existing renewal application of that type, or create a new one
    let renewalApplication;
    // used to specify the type of renewal application too create
    let renewalApplicationTypeName;

    // if it's a cannabis related licence
    if (licence.licenceTypeCategory === "Cannabis") {
      renewalType = CRS_RENEWAL_LICENCE_TYPE_NAME;

      if (licence.licenceTypeName === "Marketing") {
        // see if there is an existing Marketing renewal application for this licence
        renewalApplicationTypeName = this.ApplicationTypeNames.MarketingRenewal;
        renewalApplication = licence.actionApplications.find(app =>
          app.applicationTypeName === this.ApplicationTypeNames.MarketingRenewal && app.applicationStatus !== 'Active');
      } else {
        // if it's a CRS Licence
        // see if there is an existing CRS renewal application for this licence
        renewalApplicationTypeName = this.ApplicationTypeNames.CRSRenewal;
        renewalApplication = licence.actionApplications.find(app =>
          app.applicationTypeName === this.ApplicationTypeNames.CRSRenewal && app.applicationStatus !== 'Active');
      }

    } else {
      // otherwise it's a liquor licence
      // set the renewal type to liquor
      renewalType = LIQUOR_RENEWAL_LICENCE_TYPE_NAME;
      renewalApplicationTypeName = this.ApplicationTypeNames.LiquorRenewal;

      // look for a liquor renewal application
      renewalApplication = licence.actionApplications.find(app =>
        app.applicationTypeName === this.ApplicationTypeNames.LiquorRenewal && app.applicationStatus !== 'Active');

    }

    // if we found a renewal application that hasn't been paid for
    if (renewalApplication && !renewalApplication.isPaid) {
      // let's go there
      this.router.navigateByUrl(`/renew-licence/${renewalType}/${renewalApplication.applicationId}`);
      // otherwise if there's a paid renewal application
    } else if (renewalApplication && renewalApplication.isPaid) {
      // that shouldnt have happened
      this.snackBar.open('Renewal application already submitted', 'Fail',
        { duration: 3500, panelClass: ['red-snackbar'] });
      // otherwise
    } else {

      // create an renewal application of the specified type
      this.busy = this.licenceDataService.createApplicationForActionType(licence.licenseId, renewalApplicationTypeName)
        .pipe(takeWhile(() => this.componentActive))
        .subscribe(data => {
          this.router.navigateByUrl(`/renew-licence/${renewalType}/${data.id}`);
        },
          () => {
            this.snackBar.open(`Error running licence action for ${renewalType}`, 'Fail',
              { duration: 3500, panelClass: ['red-snackbar'] });
            console.log('Error starting a Change Licence Location Application');
          }
        );
    }
  }

  hasEndorsement(licence: License, endorsementId: string) {
    return typeof licence.endorsements.find(endorsement => endorsement.endorsementId === endorsementId) !== 'undefined';
  }

  hasEndorsementByName(licence: License, endorsementName: string) {
    return typeof licence.endorsements.find(endorsement => endorsement.endorsementName === endorsementName) !== 'undefined';
  }

  getHandbookLink(licenceType: string) {
    const pdfRoot = 'https://www2.gov.bc.ca/assets/gov/employment-business-and-economic-development/business-management/liquor-regulation-licensing/guides-and-manuals';
    switch (licenceType) {
      case 'Cannabis Retail Store':
      case 'Section 119 Authorization':
        return `${pdfRoot}/cannabis-retail-store-licence-handbook.pdf`;
      case 'Marketing':
        return `${pdfRoot}/marketing-handbook.pdf`;
      case 'Operated - Catering':
      case 'Catering':
      case 'Transfer in Progress - Catering':
        return `${pdfRoot}/catering-handbook.pdf`;
      case 'Wine Store':
      case 'Transfer in Progress - Wine Store':
      case 'Operated - Wine Store':
        return `${pdfRoot}/winestore-handbook.pdf`;
      case 'Licensee Retail Store':
      case 'Operated - Licensee Retail Store':
        return `${pdfRoot}/licenseeretailstore-handbook.pdf`;
      case 'Manufacturer':
        return `${pdfRoot}/manufacturer-handbook.pdf`;
      case 'UBrew and UVin':
        return `${pdfRoot}/ubrewanduvin-handbook.pdf`;
      default:
        return '404';
    }
  }

  getSubCategory(subcategory: string) {
    let label = '';

    switch (subcategory) {
      case 'GroceryStore':
        label = 'Grocery Store';
        break;
      case 'IndependentWineStore':
        label = 'Independent Wine Store';
        break;
      case 'OffSiteWineStore':
        label = 'Off-Site Wine Store';
        break;
      case 'OnSiteWineStore':
        label = 'On-Site Wine Store';
        break;
      case 'SacramentalWineStore':
        label = 'Sacramental Wine Store';
        break;
      case 'SpecialWineStore':
        label = 'Special Wine Store';
        break;
      case 'TouristWineStore':
        label = 'Tourist Wine Store';
        break;
      case 'WineOnShelf':
        label = 'Wine on Shelf';
        break;
      case 'BCVQA':
        label = 'BC VQA Store';
        break;
      default:
        label = subcategory;
    }
    return label;
  }

  getOptionFromValue(options: any, value: number) {
    const idx = options.findIndex(opt => opt.value === value);
    if (idx >= 0) {
      return options[idx];
    }
    return {
      value: null,
      label: ''
    };
  }

  getLicenceStatusText(status: string) {
    switch (status) {
      case 'PreInspection':
        return 'Pre-Inspection';
      case 'PendingLicenceFee':
        return 'Pending First Year Fee';
      default:
        return status;
    }
  }

  getEventName(event) {
    if (event.clientHostname !== null) {
      return event.clientHostname;
    } else if (event.name !== null) {
      return event.name;
    }
    return null;
  }

  getEventPath(event: LicenceEvent) {
    if (event.eventCategory === this.getOptionFromLabel(this.eventCategory, 'Catering').value) {
      return '/event/';
    } else if (event.eventCategory === this.getOptionFromLabel(this.eventCategory, 'Temporary Off-Site Sale').value) {
      return '/temporary-offsite/';
    } else if (event.eventCategory === this.getOptionFromLabel(this.eventCategory, 'Market').value) {
      return '/market-event/';
    }
    return '/event/';
  }

  getOptionFromLabel(options: any, label: string) {
    const idx = options.findIndex(opt => opt.label === label);
    if (idx >= 0) {
      return options[idx];
    }
    return {
      value: null,
      label: ''
    };
  }

  licenceTypeHasEvents(licenceType: string) {
    return licenceType.indexOf('Catering') >= 0 || licenceType.indexOf('Wine Store') >= 0 || licenceType.indexOf('Manufacturer') >= 0;
  }

  licenceTypeHasTerms(licenceType: string) {
    return licenceType.indexOf('Cannabis') < 0;
  }
}
