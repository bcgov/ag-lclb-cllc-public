import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { forkJoin, Subscription } from 'rxjs';
import { MatSnackBar } from '@angular/material';
import { ApplicationDataService } from '@app/services/application-data.service';
import { LicenseDataService } from '@app/services/license-data.service';
import { Router } from '@angular/router';
import { Application } from '@models/application.model';
import { ApplicationSummary } from '@models/application-summary.model';
import { ApplicationTypeNames } from '@models/application-type.model';
import { Account } from '@models/account.model';
import { FeatureFlagService } from '@services/feature-flag.service';
import { FormBase } from '@shared/form-base';
import { takeWhile } from 'rxjs/operators';
import { ApplicationLicenseSummary } from '@models/application-license-summary.model';
import { Store } from '@ngrx/store';
import { AppState } from '@app/app-state/models/app-state';
import * as moment from 'moment';
import { PaymentDataService } from '@services/payment-data.service';
import { EstablishmentDataService } from '@services/establishment-data.service';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Establishment } from '@models/establishment.model';


export const UPLOAD_FILES_MODE = 'UploadFilesMode';


const ACTIVE = 'Active';
const PAYMENT_REQUIRED = 'Payment Required';
const RENEWAL_DUE = 'Renewal Due';

@Component({
  selector: 'app-licences',
  templateUrl: './licences.component.html',
  styleUrls: ['./licences.component.scss']
})
export class LicencesComponent extends FormBase implements OnInit {
  applications: ApplicationSummary[] = [];
  licenceForms = {};
  mainForm: FormGroup;

  readonly ACTIVE = ACTIVE;
  readonly PAYMENT_REQUIRED = PAYMENT_REQUIRED;
  readonly RENEWAL_DUE = RENEWAL_DUE;

  busy: Subscription;
  @Input() applicationInProgress: boolean;
  @Input() account: Account;
  @Output() marketerApplicationExists: EventEmitter<boolean> = new EventEmitter<boolean>();
  dataLoaded = false;
  ApplicationTypeNames = ApplicationTypeNames;
  licenceTransferFeatureOn = false;
  licenceMappings = {};

  constructor(
    private applicationDataService: ApplicationDataService,
    private licenceDataService: LicenseDataService,
    private router: Router,
    private store: Store<AppState>,
    private snackBar: MatSnackBar,
    private paymentService: PaymentDataService,
    private establishmentService: EstablishmentDataService,
    public featureFlagService: FeatureFlagService,
    public fb: FormBuilder) {
    super();
    featureFlagService.featureOn('LicenceTransfer')
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((featureOn: boolean) => {
        this.licenceTransferFeatureOn = featureOn;
      });
    this.mainForm = new FormGroup({});
  }

  ngOnInit() {
    this.displayApplications();
  }

  /**
   *
   * */
  private displayApplications() {
    this.busy =
      forkJoin(this.applicationDataService.getAllCurrentApplications(), this.licenceDataService.getAllCurrentLicenses()
      ).pipe(takeWhile(() => this.componentActive))
        .subscribe(([applications, licenses]) => {
          this.applications = applications;
          licenses.forEach((licence: ApplicationLicenseSummary) => {
            this.addOrUpdateLicence(licence);
          });
        });
  }

  uploadMoreFiles(application: Application) {
    this.router.navigate([`/application/${application.id}`, { mode: UPLOAD_FILES_MODE }]);
  }

  doAction(licence: ApplicationLicenseSummary, actionName: string) {
    const actionApplication = licence.actionApplications.find(app => app.applicationTypeName === actionName && app.applicationStatus !== 'Active');
    if (actionApplication && !actionApplication.isPaid) {
      this.router.navigateByUrl('/account-profile/' + actionApplication.applicationId);
    } else if (actionApplication && actionApplication.isPaid) {
      this.snackBar.open('Application  in progress', 'Fail',
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
            console.log('Error starting a Change Licence Location Application');
          }
        );
    }
  }

  planStoreOpening(licence: ApplicationLicenseSummary) {
    const crsApplication = licence.actionApplications.find(app => app.applicationTypeName === ApplicationTypeNames.CannabisRetailStore);
    if (crsApplication) {
      this.router.navigate([`/store-opening/${crsApplication.applicationId}`]);
    } else {
      this.snackBar.open('Unable to find CRS Application', 'Fail',
        { duration: 3500, panelClass: ['red-snackbar'] });
    }
  }

  payLicenceFee(licence: ApplicationLicenseSummary) {
    const crsApplication = licence.actionApplications.find(app => app.applicationTypeName === ApplicationTypeNames.CannabisRetailStore);
    if (crsApplication) {
      this.busy = this.paymentService.getInvoiceFeePaymentSubmissionUrl(crsApplication.applicationId)
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

  startRenewal(licence: ApplicationLicenseSummary) {
    const renewalApplication = licence.actionApplications.find(app => app.applicationTypeName === 'CRS Renewal');
    if (renewalApplication && !renewalApplication.isPaid) {
      this.router.navigateByUrl('/renew-crs-licence/application/' + renewalApplication.applicationId);
    } else if (renewalApplication && renewalApplication.isPaid) {
      this.snackBar.open('Renewal application already submitted', 'Fail',
        { duration: 3500, panelClass: ['red-snackbar'] });
    } else {
      const actionName = 'CRS Renewal';
      this.busy = this.licenceDataService.createApplicationForActionType(licence.licenseId, actionName)
        .pipe(takeWhile(() => this.componentActive))
        .subscribe(data => {
          this.router.navigateByUrl('/renew-crs-licence/application/' + data.id);
        },
          () => {
            this.snackBar.open(`Error running licence action for ${actionName}`, 'Fail',
              { duration: 3500, panelClass: ['red-snackbar'] });
            console.log('Error starting a Change Licence Location Application');
          }
        );
    }
  }

  isAboutToExpire(expiryDate: string) {
    const now = moment(new Date()).startOf('day');
    const expiry = moment(expiryDate).startOf('day');
    const diff = expiry.diff(now, 'days') + 1;
    return diff <= 60 || expiry < now;
  }

  licenceHasExpired(expiryDate: string) {
    const now = moment(new Date()).startOf('day');
    const expiry = moment(expiryDate).startOf('day');
    return expiry < now;
  }

  addOrUpdateLicence(licence: ApplicationLicenseSummary) {
    licence.actionApplications = [];
    const relatedApplications = this.applications.filter(l => l.licenceId === licence.licenseId);
    relatedApplications.forEach(app => {
      licence.actionApplications.push({
        applicationId: app.id,
        applicationTypeName: app.applicationTypeName,
        applicationStatus: app.applicationStatus,
        isPaid: app.isPaid
      });
    });

    if (typeof this.licenceMappings[licence.licenceTypeName] === 'undefined') {
      this.licenceMappings[licence.licenceTypeName] = [];
    }
    const licenceIndex = this.licenceMappings[licence.licenceTypeName].findIndex(l => l.licenseId === licence.licenseId);
    if (licenceIndex >= 0) {
      this.licenceMappings[licence.licenceTypeName][licenceIndex] = licence;
    } else {
      this.licenceMappings[licence.licenceTypeName].push(licence);
    }
    this.licenceForms[licence.licenseId] = this.fb.group({
      phone: [licence.establishmentPhoneNumber],
      email: [licence.establishmentEmail]
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

    const licence = Object.assign( new ApplicationLicenseSummary(), {
      licenseId: licenceId,
      establishmentEmail: event.target.value
    });

    this.updateEstablishment(establishment);
    this.updateLicence(licence);
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

    const licence = Object.assign( new ApplicationLicenseSummary(), {
      licenseId: licenceId,
      establishmentPhoneNumber: phone
    });

    this.updateEstablishment(establishment);
    this.updateLicence(licence);
  }

  updateLicence(licence: ApplicationLicenseSummary) {
    this.busy = forkJoin([
      this.licenceDataService.updateLicenceEstablishment(licence.licenseId, licence)
    ])
    .subscribe(([licenceResp]) => {
      this.addOrUpdateLicence(licenceResp);
    });
  }

  updateEstablishment(establishment: Establishment) {
    this.busy = this.establishmentService.upEstablishment(establishment).subscribe();
  }

  toggleStoreOpen(licenceType: string, index: number, establishmentId: string, isOpen: boolean) {
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
      this.licenceMappings[licenceType][index].establishmentIsOpen = establishmentResp.isOpen;
    });
  }

  getHandbookLink(licenceType: string) {
    switch (licenceType) {
      case 'Cannabis Retail Store':
        return 'https://www2.gov.bc.ca/assets/gov/employment-business-and-economic-development/business-management/liquor-regulation-licensing/guides-and-manuals/cannabis-retail-store-licence-handbook.pdf';
      case 'Marketing':
        return 'https://www2.gov.bc.ca/assets/gov/employment-business-and-economic-development/business-management/liquor-regulation-licensing/guides-and-manuals/marketing-handbook.pdf';
      case 'Catering':
        return 'https://www2.gov.bc.ca/assets/gov/employment-business-and-economic-development/business-management/liquor-regulation-licensing/guides-and-manuals/catering-handbook.pdf';
      case 'Wine Store':
        return 'https://www2.gov.bc.ca/assets/gov/employment-business-and-economic-development/business-management/liquor-regulation-licensing/guides-and-manuals/winestore-handbook.pdf';
      default:
        return '404';
    }
  }
}
