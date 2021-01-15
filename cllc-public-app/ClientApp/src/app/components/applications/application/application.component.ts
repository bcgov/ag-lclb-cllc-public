
import { filter, takeWhile, catchError, mergeMap, delay, tap, switchMap, distinctUntilChanged } from 'rxjs/operators';
import { Component, OnInit, ViewChild, ChangeDetectionStrategy, Input, Output, EventEmitter, ChangeDetectorRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Store } from '@ngrx/store';
import { AppState } from '@app/app-state/models/app-state';
import { Subscription, Subject, Observable, forkJoin, of } from 'rxjs';
import { MatSnackBar, MatDialog, MatAutocompleteTrigger } from '@angular/material';
import * as currentApplicationActions from '@app/app-state/actions/current-application.action';
import { ActivatedRoute, Router } from '@angular/router';
import { ApplicationDataService } from '@services/application-data.service';
import { PaymentDataService } from '@services/payment-data.service';
import { Application } from '@models/application.model';
import { FormBase, CanadaPostalRegex, ApplicationHTMLContent } from '@shared/form-base';
import { DynamicsDataService } from '@services/dynamics-data.service';
import { Account, TransferAccount } from '@models/account.model';
import { ApplicationTypeNames, FormControlState } from '@models/application-type.model';
import { TiedHouseConnection } from '@models/tied-house-connection.model';
import { TiedHouseConnectionsDataService } from '@services/tied-house-connections-data.service';
import { EstablishmentWatchWordsService } from '@services/establishment-watch-words.service';
import { KeyValue } from '@angular/common';
import { FeatureFlagService } from '@services/feature-flag.service';
import { FileUploaderComponent } from '@shared/components/file-uploader/file-uploader.component';
import { ConnectionToNonMedicalStoresComponent } from '@components/account-profile/tabs/connection-to-non-medical-stores/connection-to-non-medical-stores.component';
import { UPLOAD_FILES_MODE } from '@components/licences/licences.component';
import { ApplicationCancellationDialogComponent } from '@components/dashboard/applications-and-licences/applications-and-licences.component';
import { AccountDataService } from '@services/account-data.service';
//import { User } from '@models/user.model';
import { DynamicsForm } from '../../../models/dynamics-form.model';
import { DynamicsFormDataService } from '../../../services/dynamics-form-data.service';
import { PoliceDurisdictionDataService } from '@services/police-jurisdiction-data.service';
import { LocalGovernmentDataService } from '@services/local-government-data.service';
import { ProofOfZoningComponent } from './tabs/proof-of-zoning/proof-of-zoning.component';
import { ApplicationLicenseSummary } from '@models/application-license-summary.model';
import { AreaCategory } from '@models/service-area.model';
import { faExclamationCircle, faTrashAlt, faUniversity } from '@fortawesome/free-solid-svg-icons';
import { faCreditCard, faIdCard, faSave } from '@fortawesome/free-regular-svg-icons';

const ServiceHours = [
  '00:00', '00:15', '00:30', '00:45', '01:00', '01:15', '01:30', '01:45', '02:00', '02:15', '02:30', '02:45', '03:00',
  '03:15', '03:30', '03:45', '04:00', '04:15', '04:30', '04:45', '05:00', '05:15', '05:30', '05:45', '06:00', '06:15',
  '06:30', '06:45', '07:00', '07:15', '07:30', '07:45', '08:00', '08:15', '08:30', '08:45',
  '09:00', '09:15', '09:30',
  '09:45', '10:00', '10:15', '10:30', '10:45', '11:00', '11:15', '11:30', '11:45', '12:00', '12:15', '12:30', '12:45',
  '13:00', '13:15', '13:30', '13:45', '14:00', '14:15', '14:30', '14:45', '15:00', '15:15', '15:30', '15:45', '16:00',
  '16:15', '16:30', '16:45', '17:00', '17:15', '17:30', '17:45', '18:00', '18:15', '18:30', '18:45', '19:00', '19:15',
  '19:30', '19:45', '20:00', '20:15', '20:30', '20:45', '21:00', '21:15', '21:30', '21:45', '22:00', '22:15', '22:30',
  '22:45', '23:00', '23:15', '23:30', '23:45'
];



@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.scss']
})
export class ApplicationComponent extends FormBase implements OnInit {
  faSave = faSave;
  faIdCard = faIdCard;
  faUniversity = faUniversity;
  faCreditCard = faCreditCard;
  faExclamationCircle = faExclamationCircle;
  faTrashAlt = faTrashAlt;

  establishmentWatchWords: KeyValue<string, boolean>[];
  application: Application;
  @Input() skipPayment: boolean = false;
  @Output() saveComplete: EventEmitter<boolean> = new EventEmitter<boolean>();
  @ViewChild('mainForm') mainForm: FileUploaderComponent;
  @ViewChild('financialIntegrityDocuments') financialIntegrityDocuments: FileUploaderComponent;
  @ViewChild('supportingDocuments') supportingDocuments: FileUploaderComponent;
  @ViewChild(ConnectionToNonMedicalStoresComponent) connectionsToProducers: ConnectionToNonMedicalStoresComponent;
  @ViewChild(ProofOfZoningComponent) proofOfZoning: ProofOfZoningComponent;
  @ViewChild('lgAutoCompleteTrigger', { read: MatAutocompleteTrigger }) lgAutoComplete: MatAutocompleteTrigger;
  @ViewChild('pdAutoCompleteTrigger', { read: MatAutocompleteTrigger }) pdAutoComplete: MatAutocompleteTrigger;
  form: FormGroup;
  savedFormData: any;
  applicationId: string;
  busy: Subscription;
  busyPromise: Promise<any>;
  accountId: string;
  payMethod: string;
  validationMessages: any[];
  showValidationMessages: boolean;
  submittedApplications = 8;
  ServiceHours = ServiceHours;
  tiedHouseFormData: TiedHouseConnection;
  possibleProblematicNameWarning = false;
  htmlContent: ApplicationHTMLContent = <ApplicationHTMLContent>{};
  indigenousNations: { id: string, name: string }[] = [];
  readonly UPLOAD_FILES_MODE = UPLOAD_FILES_MODE;
  FormControlState = FormControlState;
  mode: string;
  account: Account;

  uploadedSupportingDocuments = 0;
  uploadedFinancialIntegrityDocuments: 0;
  uploadedAssociateDocuments: 0;
  uploadedSignageDocuments: 0;
  uploadedValidInterestDocuments: 0;
  uploadedSitePlanDocuments: 0;
  uploadedFloorPlanDocuments: 0;
  uploadedPhotosOrRenderingsDocuments: 0;
  uploadedZoningDocuments: 0;
  uploadedCentralSecuritiesRegister: 0;
  uploadedRegisterOfDirectorsAndOfficers:0;
  uploadedPartnershipAgreement:0;
  uploadedOtherDocuments:0;
  uploadedIndividualsWithLessThan10:0;
  dynamicsForm: DynamicsForm;
  autocompleteLocalGovernmemts: any[];
  autocompletePoliceDurisdictions: any[];
  LGApprovalsFeatureIsOn: boolean;
  disableSubmitForLGINApproval: boolean;
  INRequestInProgress: boolean;
  policeJurisdictionReqInProgress: boolean;
  saveForLaterInProgress: boolean;
  submitApplicationInProgress: boolean;
  proceedToSecurityScreeningInProgress: boolean;
  dataLoaded: boolean;


  get isOpenedByLGForApproval(): boolean {
    let openedByLG = false;
    if (this.account && this.application && this.application.applicant &&
      this.account.businessType === 'LocalGovernment' &&
      this.application.applicant.id !== this.account.id && // Application was not made by the LG/IN
      this.account.localGovernmentId && this.application.indigenousNationId && // make sure these values are not null
      this.account.localGovernmentId === this.application.indigenousNationId) {
      openedByLG = true;
    }
    return openedByLG;
  }

  constructor(private store: Store<AppState>,
    private paymentDataService: PaymentDataService,
    public snackBar: MatSnackBar,
    public router: Router,
    public applicationDataService: ApplicationDataService,
    private dynamicsDataService: DynamicsDataService,
    public featureFlagService: FeatureFlagService,
    private route: ActivatedRoute,
    private fb: FormBuilder,
    private cd: ChangeDetectorRef,
    private tiedHouseService: TiedHouseConnectionsDataService,
    public dialog: MatDialog,
    public establishmentWatchWordsService: EstablishmentWatchWordsService,
    private policeJurisdictionDataService: PoliceDurisdictionDataService,
    private localGovDataService: LocalGovernmentDataService
  ) {
    super();
    this.route.paramMap.subscribe(pmap => this.applicationId = pmap.get('applicationId'));
    this.route.paramMap.subscribe(pmap => this.mode = pmap.get('mode'));

    this.featureFlagService.featureOn('LGApprovals')
      .subscribe(featureOn => this.LGApprovalsFeatureIsOn = featureOn);
  }

  ngOnInit() {


    this.form = this.fb.group({
      id: [''],
      assignedLicence: this.fb.group({
        id: [''],
        establishmentAddressStreet: [''],
        establishmentAddressCity: [''],
        establishmentAddressPostalCode: [''],
        establishmentParcelId: ['']
      }),
      establishmentName: ['', [
        Validators.required,
        this.establishmentWatchWordsService.forbiddenNameValidator()
      ]],
      establishmentParcelId: ['', [Validators.required, Validators.maxLength(9), Validators.minLength(9)]],
      contactPersonFirstName: ['', Validators.required],
      contactPersonLastName: ['', Validators.required],
      contactPersonRole: [''],
      contactPersonEmail: ['', Validators.required],
      contactPersonPhone: ['', Validators.required],
      establishmentAddressStreet: ['', Validators.required],
      establishmentAddressCity: ['', Validators.required],
      establishmentAddressPostalCode: ['', [Validators.required, Validators.pattern(CanadaPostalRegex)]],
      establishmentEmail: ['', Validators.email],
      establishmentPhone: [''],
      serviceHoursSundayOpen: [''],
      serviceHoursMondayOpen: [''],
      serviceHoursTuesdayOpen: [''],
      serviceHoursWednesdayOpen: [''],
      serviceHoursThursdayOpen: [''],
      serviceHoursFridayOpen: [''],
      serviceHoursSaturdayOpen: [''],
      serviceHoursSundayClose: [''],
      serviceHoursMondayClose: [''],
      serviceHoursTuesdayClose: [''],
      serviceHoursWednesdayClose: [''],
      serviceHoursThursdayClose: [''],
      serviceHoursFridayClose: [''],
      serviceHoursSaturdayClose: [''],
      liquorDeclarationCheck: [''],
      applyAsIndigenousNation: [false],
      indigenousNationId: [{ value: null, disabled: true }, Validators.required],
      federalProducerNames: ['', Validators.required],
      applicantType: ['', Validators.required],
      description1: [''],
      proposedChange: ['', [Validators.required]],
      isLocatedInGroceryStore: [null, []],
      sitePhotos: ['', []],
      authorizedToSubmit: [''],
      signatureAgreement: [''],
      policeJurisdiction: [''],
      indigenousNation: [''],
      zoningPermitsMFG: ['', []],
      zoningPermitsRetailSales: ['', []],
      isAlr: ['', []],
      isOwner: ['', []],
      isOwnerBusiness: ['', []],
      isHasPatio: ['', []],
      hasCoolerAccess: ['', []],
      hasValidInterest: ['', []],
      willHaveValidInterest: ['', []],
      meetsALRRequirements: ['', []],
      IsReadyProductNotVisibleOutside: ['', []],
      serviceAreas: ['', []],
      outsideAreas: ['', []],
      capacityArea: this.fb.group({
        areaCategory: [AreaCategory.Capacity],
        areaNumber: [1],
        areaLocation: [''],
        capacity: ['', Validators.required]
      }),
      isPermittedInZoning: ['', []],
      isOnINLand: [false, []]
    });

    this.form.get('serviceHoursSundayOpen').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursSundayClose');
    });
    this.form.get('serviceHoursSundayClose').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursSundayOpen');
    });
    this.form.get('serviceHoursMondayOpen').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursMondayClose');
    });
    this.form.get('serviceHoursMondayClose').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursMondayOpen');
    });
    this.form.get('serviceHoursTuesdayOpen').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursTuesdayClose');
    });
    this.form.get('serviceHoursTuesdayClose').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursTuesdayOpen');
    });
    this.form.get('serviceHoursWednesdayOpen').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursWednesdayClose');
    });
    this.form.get('serviceHoursWednesdayClose').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursWednesdayOpen');
    });
    this.form.get('serviceHoursThursdayOpen').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursThursdayClose');
    });
    this.form.get('serviceHoursThursdayClose').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursThursdayOpen');
    });
    this.form.get('serviceHoursFridayOpen').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursFridayClose');
    });
    this.form.get('serviceHoursFridayClose').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursFridayOpen');
    });
    this.form.get('serviceHoursSaturdayOpen').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursSaturdayClose');
    });
    this.form.get('serviceHoursSaturdayClose').valueChanges.pipe(distinctUntilChanged()).subscribe(val => {
      this.updateHoursValidator(val, 'serviceHoursSaturdayOpen');
    });


    this.form.get('indigenousNation').valueChanges
      .pipe(filter(value => value && value.length >= 3),
        tap(_ => {
          this.autocompleteLocalGovernmemts = [];
          this.INRequestInProgress = true;
        }),
        switchMap(value => this.localGovDataService.getAutocomplete(value))
      )
      .subscribe(data => {
        this.autocompleteLocalGovernmemts = data;
        this.INRequestInProgress = false;

        this.cd.detectChanges();
        if (data && data.length === 0) {
          this.snackBar.open('No match found', '', { duration: 2500, panelClass: ['green-snackbar'] });
        }
      });

    this.form.get('policeJurisdiction').valueChanges
      .pipe(filter(value => value && value.length >= 3),
        tap(_ => {
          this.autocompleteLocalGovernmemts = [];
          this.policeJurisdictionReqInProgress = true;
        }),
        switchMap(value => this.policeJurisdictionDataService.getAutocomplete(value))
      )
      .subscribe(data => {
        this.autocompletePoliceDurisdictions = data;
        this.policeJurisdictionReqInProgress = false;

        this.cd.detectChanges();
        if (data && data.length === 0) {
          this.snackBar.open('No match found', '', { duration: 2500, panelClass: ['green-snackbar'] });
        }
      });

    this.form.get('applyAsIndigenousNation').valueChanges.subscribe((applyAsIN: boolean) => {
      if (applyAsIN && this.application.applicationType.name === this.ApplicationTypeNames.CannabisRetailStore) {
        this.form.get('applicantType').setValue('IndigenousNation');
        this.form.get('indigenousNationId').enable();
      } else {
        this.form.get('applicantType').setValue(this.account.businessType);
        this.form.get('indigenousNationId').disable();
      }
      this.addDynamicContent();
    });

    this.applicationDataService.getSubmittedApplicationCount()
      .pipe(takeWhile(() => this.componentActive))
      .subscribe(value => this.submittedApplications = value);

    this.establishmentWatchWordsService.initialize();

    this.store.select(state => state.currentAccountState.currentAccount)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((account) => {
        this.account = account;
        this.busy = this.applicationDataService.getApplicationById(this.applicationId)
          .pipe(takeWhile(() => this.componentActive))
          .subscribe((data: Application) => {
            if (data.establishmentParcelId) {
              data.establishmentParcelId = data.establishmentParcelId.replace(/-/g, '');
            }
            // fix for no applicant type.
            if (!data.applicantType) {
              data.applicantType = this.account.businessType;
            }

            if (data.applicantType === 'IndigenousNation') {
              (<any>data).applyAsIndigenousNation = true;
            }

            this.application = data;

            this.hideFormControlByType();

            this.addDynamicContent();

            if (data.applicationType.formReference) {
              console.log("Getting form layout");
              // get the application form
              this.dynamicsForm = data.applicationType.dynamicsForm;
              this.dynamicsForm.tabs.forEach(function (tab) {
                tab.sections.forEach(function (section) {
                  if (section.fields) {
                    section.fields.forEach(function (field) {
                      // add the field to the form.
                      if (field.required) {
                        this.form.addControl(field.datafieldname, new FormControl('', Validators.required));
                      }
                      else {
                        this.form.addControl(field.datafieldname, new FormControl(''));
                      }
                    }, this);
                  }

                }, this);
              }, this);
              this.updateDynamicValidation();
            }

            const noNulls = Object.keys(data)
              .filter(e => data[e] !== null)
              .reduce((o, e) => {
                o[e] = data[e];
                return o;
              }, {});

            this.form.patchValue(noNulls);

            if (data.indigenousNation) {
              this.form.get('indigenousNationId').patchValue(data.indigenousNation.id);
            }

            if (data.policeJurisdiction) {
              this.form.get('indigenousNationId').patchValue(data.policeJurisdiction.id);
            }
            if (this.application.capacityArea.length > 0) {
              this.form.get('capacityArea').patchValue({ ...this.application.capacityArea[0] });
            } else {
              this.form.get('capacityArea.areaLocation').patchValue(data.applicationType.name);
            }

            // make fields readonly if payment was made or the LG is viewing the application
            // disable the form if the local government has reviewed the application
            if (data.isPaid || this.isOpenedByLGForApproval || this.application.lGDecisionSubmissionDate) {
              this.form.disable();
            }
            this.savedFormData = this.form.value;
            this.dataLoaded = true;
          },
            () => {
              console.log('Error occured');
              this.dataLoaded = true;
            }
          );
      });

    this.dynamicsDataService.getRecord('indigenousnations', '')
      .subscribe(data => this.indigenousNations = data);

  }

  updateHoursValidator(val, controlName) {
    if (val === '') {
      this.form.get(controlName).setValidators([]);
    } else {
      this.form.get(controlName).setValidators(Validators.required);
    }
    this.form.get(controlName).updateValueAndValidity();
  }

  autocompleteDisplay(item: any) {
    return item && item.name;
  }

  private hideFormControlByType() {
    //add guard
    if (!(this.application && this.application.applicationType)) {
      return;
    }

    if (this.application.applicationType.name !== ApplicationTypeNames.LRSStructuralChange) {
      this.form.get('hasCoolerAccess').disable();
    }

    if ((this.application.applicationType.name !== ApplicationTypeNames.SpecialEventAreaEndorsement
        && this.application.applicationType.name !== ApplicationTypeNames.LoungeAreaEndorsment) &&
        !this.application.applicationType.showPatio) {
      this.form.get('isHasPatio').disable();
    }

    if (!this.application.applicationType.showPropertyDetails) {
      this.form.get('establishmentAddressStreet').disable();
      this.form.get('establishmentAddressCity').disable();
      this.form.get('establishmentAddressPostalCode').disable();
      this.form.get('establishmentName').disable();
      this.form.get('establishmentParcelId').disable();
    }

    if (this.application.applicationType.newEstablishmentAddress !== FormControlState.Show) {
      this.form.get('establishmentAddressStreet').disable();
      this.form.get('establishmentAddressCity').disable();
      this.form.get('establishmentAddressPostalCode').disable();
      this.form.get('establishmentParcelId').disable();
    }

    if (this.application.applicationType.establishmentName !== FormControlState.Show) {
      this.form.get('establishmentName').disable();
    }

    if (this.application.applicationType.storeContactInfo !== FormControlState.Show) {
      this.form.get('establishmentEmail').disable();
      this.form.get('establishmentPhone').disable();
    }

    if (!this.application.applicationType.showHoursOfSale || this.application.applicationType.name === ApplicationTypeNames.FP || this.application.applicationType.name === ApplicationTypeNames.FPRelo) {
      // Opening hours
      this.form.get('serviceHoursSundayOpen').disable();
      this.form.get('serviceHoursMondayOpen').disable();
      this.form.get('serviceHoursTuesdayOpen').disable();
      this.form.get('serviceHoursWednesdayOpen').disable();
      this.form.get('serviceHoursThursdayOpen').disable();
      this.form.get('serviceHoursFridayOpen').disable();
      this.form.get('serviceHoursSaturdayOpen').disable();
      // Closing hours
      this.form.get('serviceHoursSundayClose').disable();
      this.form.get('serviceHoursMondayClose').disable();
      this.form.get('serviceHoursTuesdayClose').disable();
      this.form.get('serviceHoursWednesdayClose').disable();
      this.form.get('serviceHoursThursdayClose').disable();
      this.form.get('serviceHoursFridayClose').disable();
      this.form.get('serviceHoursSaturdayClose').disable();
    }

    if (this.application.applicationType.name !== ApplicationTypeNames.Marketer) {
      this.form.get('federalProducerNames').disable();
    }

    if (this.application.applicationType.name !== ApplicationTypeNames.CRSStructuralChange
      && this.application.applicationType.name !== ApplicationTypeNames.CRSEstablishmentNameChange) {
      this.form.get('proposedChange').disable();
    }

    //if (!this.application.applicationType.showDescription1) {
    //  this.form.get('description1').disable();
    //}

    if (this.application.applicationType.showLiquorDeclarations) {
      this.form.get('liquorDeclarationCheck').setValidators([this.customRequiredCheckboxValidator()]);
    }

    if (this.application.applicationType.showDeclarations) {
      this.form.get('authorizedToSubmit').setValidators([this.customRequiredCheckboxValidator()]);
      this.form.get('signatureAgreement').setValidators([this.customRequiredCheckboxValidator()]);
    }

    // TG validation question for cannabis licences to confirm that product is not visible from outside
    if (this.application.applicationType.floorPlan === FormControlState.Show && this.application.licenseType === 'Cannabis Retail Store') {
      this.form.get('IsReadyProductNotVisibleOutside').setValidators([Validators.required]);
    }


    if (this.application.applicationType.lGandPoliceSelectors === "Yes" && this.LGApprovalsFeatureIsOn) {
      this.form.get('indigenousNation').setValidators([this.requiredAutoCompleteId]);
      this.form.get('policeJurisdiction').setValidators([this.requiredAutoCompleteId]);
    }

    if (this.isRAS()) {
      // use description1 for the certificate number
      this.form.get('description1').enable();
    }

    // 03/01/2020 - Disabled until connected grocery store feature is ready
    // if (this.application.applicationType.connectedGroceryStore !== FormControlState.Show) {
    //   this.form.get('isLocatedInGroceryStore').clearValidators();
    // } else {
    //   this.form.get('isLocatedInGroceryStore').setValidators([Validators.required]);
    // }

    if (!this.application.applicationType.serviceAreas) {
      this.form.get('serviceAreas').disable();
    }
    if (!this.application.applicationType.outsideAreas) {
      this.form.get('outsideAreas').disable();
    }
    if (!this.application.applicationType.capacityArea) {
      this.form.get('capacityArea.capacity').disable();
    }
  }


  private isHoursOfSaleValid(): boolean {
    return !this.application.applicationType.showHoursOfSale ||
      (this.form.get('serviceHoursSundayOpen').valid
        && this.form.get('serviceHoursMondayOpen').valid
        && this.form.get('serviceHoursTuesdayOpen').valid
        && this.form.get('serviceHoursWednesdayOpen').valid
        && this.form.get('serviceHoursThursdayOpen').valid
        && this.form.get('serviceHoursFridayOpen').valid
        && this.form.get('serviceHoursSaturdayOpen').valid
        && this.form.get('serviceHoursSundayClose').valid
        && this.form.get('serviceHoursMondayClose').valid
        && this.form.get('serviceHoursTuesdayClose').valid
        && this.form.get('serviceHoursWednesdayClose').valid
        && this.form.get('serviceHoursThursdayClose').valid
        && this.form.get('serviceHoursFridayClose').valid
        && this.form.get('serviceHoursSaturdayClose').valid
      );
  }

  lgHasReviewedZoning(): boolean {
    let hasReviewed = false;
    if (this.application && this.application.lGDecisionSubmissionDate && this.application.lgZoning) {
      hasReviewed = true;
    }
    return hasReviewed;
  }

  lgApprovalDecisionMade(): boolean {
    let hasMadeDecision = false;
    if (this.application && this.application.lGDecisionSubmissionDate && this.application.lGApprovalDecision) {
      hasMadeDecision = true;
    }
    return hasMadeDecision;
  }

  canDeactivate(): Observable<boolean> {
    const connectionsDidntChang = !(this.connectionsToProducers && this.connectionsToProducers.formHasChanged());
    const formDidntChange = JSON.stringify(this.savedFormData) === JSON.stringify(this.form.value);
    if (connectionsDidntChang && formDidntChange) {
      return of(true);
    } else {
      const subj = new Subject<boolean>();
      this.busy = this.save(true).subscribe(([res, app]) => {
        subj.next(res);
      });
      return subj;
    }
  }

  checkPossibleProblematicWords() {
    this.possibleProblematicNameWarning =
      this.establishmentWatchWordsService.potentiallyProblematicValidator(this.form.get('establishmentName').value);
  }

  showSitePlan(): boolean {
    let show = this.application
      && this.application.applicationType
      && (this.showFormControl(this.application.applicationType.sitePlan)
        || this.showFormControl(this.application.applicationType.showLiquorSitePlan));

    if (this.application && this.application.applicationType.name === ApplicationTypeNames.CRSStructuralChange) {
      show = this.showFormControl(this.application.applicationType.sitePlan)
        && this.form.get('proposedChange').value === 'Yes';
    }

    return show;
  }


  showZoning(): boolean {
    let show = this.application
      && this.application.applicationType
      && this.showFormControl(this.application.applicationType.proofofZoning);
    return show;

  }

  showExteriorChangeQuestion(): boolean {
    let show = this.application &&
      (this.application.applicationType.name === ApplicationTypeNames.CRSEstablishmentNameChange
        && this.application.licenseType === 'Cannabis Retail Store');

    if (show) {
      this.form.get('proposedChange').setValidators([Validators.required]);
      this.form.updateValueAndValidity();
    } else {
      this.form.get('proposedChange').setValidators([]);
      this.form.updateValueAndValidity();
    }
    return show;
  }

  showExteriorRenderings() {
    let show = this.application &&
      (this.application.applicationType.name === ApplicationTypeNames.CRSEstablishmentNameChange
        );
    show = show && this.form.get('proposedChange').value === 'Yes';
    return show;
  }

  showGroceryQuestion() {
    let show = this.application
      && this.application.applicationType
      && this.showFormControl(this.application.applicationType.connectedGroceryStore);
    return show;
  }

  showGroceryStore() {
    let show = (this.application && this.showFormControl(this.application.applicationType.connectedGroceryStore));
    // show = show && this.form.get('isLocatedInGroceryStore').value === 'Yes';
    return show;
  }

  showSitePhotos() {
    let show = (this.application && this.showFormControl(this.application.applicationType.sitePhotos));
    return show;
  }

  onAccountSelect(proposedAccount: TransferAccount) {
    this.form.get('proposedTPO').patchValue(proposedAccount);
  }


  isRAS(): boolean {
    return this.application.licenseType === 'Rural Agency Store';
  }

  isLiquor(): boolean {
    return this.application.applicationType.category == "Liquor";
  }

  normalizeFormData() {
    let description2 = '';
    if (this.isRAS()) {
      description2 += this.form.get('isOwner').value ? 'Is owner = Yes' : 'Is owner = No';
      description2 += '\n';
      description2 += this.form.get('hasValidInterest').value ? 'Has valid interest = Yes' : 'Has valid interest = No';
      description2 += '\n';
      description2 += this.form.get('willHaveValidInterest').value ? 'Will have valid interest = Yes' : 'Will have valid interest = No';
    }
    else {
      description2 += this.application.description2;
    }

    // flatten the service areas if need be
    const serviceAreas = ('areas' in this.form.get('serviceAreas').value) ? this.form.get('serviceAreas').value['areas'] : this.form.get('serviceAreas').value;
    const outsideAreas = ('areas' in this.form.get('outsideAreas').value) ? this.form.get('outsideAreas').value['areas'] : this.form.get('outsideAreas').value;
    const capacityArea = [this.form.get('capacityArea').value];

    return {
      ...this.form.value,
      description2,
      serviceAreas,
      outsideAreas,
      capacityArea,
      indigenousNationId: this.form.value.indigenousNation && this.form.value.indigenousNation.id,
      policeJurisdictionId: this.form.value.policeJurisdiction && this.form.value.policeJurisdiction.id,
    }
  }

  /**
   * Save form data
   * @param showProgress
   */
  save(showProgress: boolean = false, appData: Application = <Application>{}): Observable<[boolean, Application]> {
    const saveData = this.form.value;

    // do not save if the form is in file upload mode
    if (this.mode === UPLOAD_FILES_MODE) {
      // a delay is need by the deactivate guard
      const res: [boolean, Application] = [true, null];
      return of(res).pipe(delay(10));
    }
    return forkJoin(
      this.applicationDataService.updateApplication({
        ...this.application,
        ...this.normalizeFormData(),
        ...appData
      }),
      this.prepareTiedHouseSaveRequest(this.tiedHouseFormData)
    ).pipe(takeWhile(() => this.componentActive))
      .pipe(catchError(() => {
        this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        const res: [boolean, Application] = [false, null];
        return of(res);
      }))
      .pipe(mergeMap((data) => {
        this.savedFormData = saveData;
        let application = data[0];
        this.updateApplicationInStore();
        if (showProgress === true) {
          this.snackBar.open('Application has been saved', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
        }
        const res: [boolean, Application] = [true, <Application>application];
        return of(res);
      }));
  }


  saveForLater() {
    this.saveForLaterInProgress = true;
    this.busyPromise = this.save(true)
      .toPromise()
      .then(([saveSucceeded, app]) => {
        if (saveSucceeded) {
          this.router.navigateByUrl('/dashboard');
        } else {
          this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        }
        this.saveForLaterInProgress = false;
      });
  }

  prepareTiedHouseSaveRequest(_tiedHouseData) {
    if (!this.application.tiedHouse) {
      return of(null);
    }
    let data = (<any>Object).assign(this.application.tiedHouse, _tiedHouseData);
    data = { ...data };
    return this.tiedHouseService.updateTiedHouse(data, data.id);
  }

  updateApplicationInStore() {
    this.applicationDataService.getApplicationById(this.applicationId)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((data: Application) => {
        this.store.dispatch(new currentApplicationActions.SetCurrentApplicationAction(data));
      }
      );
  }

  /**
   * Submit the application for payment
   * */
  submit_application() {

    // Only save if the data is valid
    if (this.isValid()) {
      this.submitApplicationInProgress = true;
      this.busy = this.save(!this.application.applicationType.isFree, <Application>{ invoiceTrigger: 1 }) // trigger invoice generation when saving
        .pipe(takeWhile(() => this.componentActive))
        .subscribe(([saveSucceeded, app]) => {
          if (saveSucceeded) {
            // payment is required
            if (app && app.invoiceId) {
              this.submitPayment()
                .subscribe(res => {
                  this.saveComplete.emit(true);
                  this.submitApplicationInProgress = false;
                });
            } else if (app) {
              // mark application as complete
              this.save(!this.application.applicationType.isFree, <Application>{ isApplicationComplete: 'Yes' })
                .subscribe(res => {
                  this.saveComplete.emit(true);
                  // however we need to redirect if the application is Free
                  if (this.application.applicationType.isFree) {
                    this.snackBar.open('Application submitted', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
                    this.router.navigateByUrl('/dashboard');
                  }
                });
            }
          } else if (this.application.applicationType.isFree) { // show error message the save failed and the application is free
            this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
            this.submitApplicationInProgress = false;
          }
        });
    } else {
      this.showValidationMessages = true;
    }
  }


  submitForLGINApproval() {
    const saveData = this.form.value;
    this.disableSubmitForLGINApproval = true;

    // Only save if the data is valid
    if (this.isValid()) {
      this.busy = forkJoin(
        this.applicationDataService.updateApplication({
          ...this.application,
          ...this.normalizeFormData(),
          applicationStatus: 'PendingForLGFNPFeedback'
        }),
        this.prepareTiedHouseSaveRequest(this.tiedHouseFormData)
      ).pipe(takeWhile(() => this.componentActive))
        .pipe(catchError(() => {
          this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
          return of(false);
        }))
        .pipe(mergeMap(() => {
          this.savedFormData = saveData;
          this.updateApplicationInStore();
          this.snackBar.open('Application has been saved', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
          return of(true);
        })).subscribe(res => {
          this.saveComplete.emit(true);
          this.snackBar.open('Application Submitted to Local Government For Approval', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
          this.router.navigateByUrl('/dashboard');
        });
    } else {
      this.showValidationMessages = true;
      this.disableSubmitForLGINApproval = false;
    }
  }

  private proceedToSecurityScreening() {
    //send event to move to the next step of the multi-step
    if (this.isValid()) { // Only proceed if the data is valid
      this.proceedToSecurityScreeningInProgress = true;
      this.busyPromise = this.save(true)
        .toPromise()
        .then(([saveSucceeded, app]) => {
          this.proceedToSecurityScreeningInProgress = false;
          if (saveSucceeded) {
            this.saveComplete.next(true);
          } else {
            this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
          }
        });
    } else {
      this.showValidationMessages = true;
    }
  }


  private lGHasApproved() {
    let hasApproved = this.application && this.application.applicationType &&
      (this.application.applicationType.isShowLGINApproval &&
        (this.application.lGApprovalDecision === 'Approved' ||
          this.application.lGApprovalDecision === 'OptOut' ||
          this.application.lGApprovalDecision === 'Pending'
        )
      ) ||
      (this.application.applicationType.isShowLGZoningConfirmation && this.application.lgZoning === 'Allows');
    return hasApproved;
  }

  private lGHasRejected() {
    let hasApproved = this.application && this.application.applicationType &&
      (this.application.applicationType.isShowLGINApproval &&
        (this.application.lGApprovalDecision === 'Rejected')) ||
      (this.application.applicationType.isShowLGZoningConfirmation && this.application.lgZoning === 'DoesNotAllow');
    return hasApproved;
  }


  /**
   * Redirect to payment processing page (Express Pay / Bambora service)
   * */
  private submitPayment() {
    return this.paymentDataService.getPaymentSubmissionUrl(this.applicationId)
      .pipe(takeWhile(() => this.componentActive))
      .pipe(mergeMap(jsonUrl => {
        window.location.href = jsonUrl['url'];
        return jsonUrl['url'];
      }, (err: any) => {
        if (err._body === 'Payment already made') {
          this.snackBar.open('Application payment has already been made.', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        }
      }));
  }

  isValid(): boolean {

    this.showValidationMessages = false;
    let valid = true;
    this.validationMessages = this.listControlsWithErrors(this.form, this.getValidationErrorMap());
    const applicationTypeName = this.application && this.application.applicationType.name;

    this.markControlsAsTouched(this.form);
    // handle supporting documents for sole proprietor who submit marketing applications
    let marketing_soleprop = applicationTypeName === ApplicationTypeNames.Marketer && this.account.businessType === "SoleProprietorship";

    if (this.proofOfZoning) {
      let zoningErrors = this.proofOfZoning.getValidationErrors();
      if (zoningErrors.length > 0) {
        valid = false;
        this.validationMessages = this.validationMessages.concat(zoningErrors);
      }
    }

    if (this.application.applicationType.showAssociatesFormUpload &&
      ((this.uploadedAssociateDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('Associate form is required.');

      /// here

    }

    if (this.application.applicationType.showFinancialIntegrityFormUpload &&
      ((this.uploadedFinancialIntegrityDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('Financial Integrity form is required.');
    }

    // if we're showing supporting documents and it's not a marketing soleprop application add validation
    if (this.application.applicationType.showSupportingDocuments && !marketing_soleprop &&
      ((this.uploadedSupportingDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one supporting document is required.');
    }

    const signageNotRequired = (
       applicationTypeName === ApplicationTypeNames.LiquorLicenceTransfer ||
       applicationTypeName === ApplicationTypeNames.MFG
    );

    if (!signageNotRequired && this.application.applicationType.signage === FormControlState.Show &&
      this.application.applicationType.name !== ApplicationTypeNames.LRSTransferofLocation && // optional for this application type
      ((this.uploadedSignageDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one signage document is required.');
    }

    if (this.application.applicationType.validInterest === FormControlState.Show &&
      ((this.uploadedValidInterestDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least proof of ownership document is required.');
    }

    if (this.showSitePlan() &&
      ((this.uploadedSitePlanDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one site plan document is required.');
    }

    if (this.showExteriorRenderings() &&
      ((this.uploadedPhotosOrRenderingsDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one store exterior rendering or photo is required.');
    }

    if (this.application.applicationType.floorPlan === FormControlState.Show &&
      this.application.applicationType.name !== ApplicationTypeNames.LRSTransferofLocation &&  // optional for this application type
      ((this.uploadedFloorPlanDocuments || 0) < 1)) {
      valid = false;
      this.validationMessages.push('At least one floor plan document is required.');
    }

    if (this.application.applicationType.showPropertyDetails && !this.form.get('establishmentName').value) {
      valid = false;
      this.validationMessages.push('Establishment name is required.');
    }
    if (applicationTypeName === ApplicationTypeNames.CannabisRetailStore && this.submittedApplications >= 8) {
      valid = false;
      this.validationMessages.push('Only 8 applications can be submitted');
    }

    if (!this.isHoursOfSaleValid()) {
      this.validationMessages.push('Hours of sale are required');
    }

    if (this.application.applicationType.showOwnershipDeclaration) {

      if (!this.form.get('isOwner').value) {
        this.validationMessages.push('Only the owner of the business may submit this information');
      }

      //if (!this.form.get('hasValidInterest').value) {
      //  this.validationMessages.push('The owner of the business must own or have an agreement to purchase the proposed establishment, or, be the lessee or have a binding agreement to lease the proposed establishment');
      // }

      //if (!this.form.get('willHaveValidInterest').value) {
      //  this.validationMessages.push('Ownership or the lease agreement must be in place at the time of licensing');
      // }

    }

    return valid && (this.form.valid || this.form.disabled);
  }

  getValidationErrorMap() {
    let errorMap = {
      establishmentName: (_ => {
        let control = this.getEstablishmentLabel(<ApplicationTypeNames>(this.application.applicationType.name))
        let message = '';
        if (this.form && this.form.get('establishmentName')) {
          let errors = this.form.get('establishmentName').errors;
          if (errors && errors.required) {
            message += `${control} is required`;
          } else if (errors && errors.forbiddenName) {
            message += `The store name contains at least one word that doesn’t comply with naming requirements.`;
          }
        }
        return message;
      })(),

      signatureAgreement: 'Please affirm that all of the information provided for this application is true and complete',

      description1: 'Please enter a description',
      IsReadyProductNotVisibleOutside: 'Please confirm that product will not be visible from the outside',
      serviceAreas: 'All service area rows must be complete',

      additionalPropertyInformation: 'Please enter additional property information',
      applyingPerson: 'Please enter the applying person',
      authorizedToSubmit: 'Please affirm that you are authorized to submit the application',
      'capacityArea.capacity': 'Please enter capacity area',
      contactPersonEmail: 'Please enter the business contact\'s email address',
      contactPersonFirstName: 'Please enter the business contact\'s first name',
      contactPersonLastName: 'Please enter the business contact\'s last name',
      contactPersonPhone: 'Please enter the business contact\'s 10-digit phone number',
      contactPersonRole: 'Please enter the contact person role',

      establishmentAddressStreet: 'Please enter the street address',
      establishmentAddressCity: 'Please enter the city',
      establishmentAddressPostalCode: 'Please enter the postal code',
      establishmentEmail: 'Please enter the email address for the store',
      establishmentPhone: 'Please enter the store phone number',
      establishmentParcelId: 'Please enter the Parcel Identifier (format: 9 digits)',
      establishmentopeningdate: 'Please enter the store opening date',
      federalProducerNames: 'Please enter the name of federal producer',
      hasValidInterest: 'Please enter a value for valid interest',
      indigenousNationId: 'Please select the Indigenous nation',
      isAlr: 'Please indicate ALR status',
      isLocatedInGroceryStore: 'Please specify if the establishment is located in a grocery store.',
      isOwnerBusiness: 'Please enter a value for owner business',
      isPackaging: 'Please enter a value for packaging',
      isPermittedInZoning: 'Please enter a value for permitted in zoning',
      isReadyDisplays: 'Please confirm displays are ready',
      isReadyExtranceExit: 'Please confirm the exit is ready',
      isReadyFireAlarm: 'Please confirm the fire alarm is ready',
      isReadyIntruderAlarm: 'Please confirm the intruder alarm is ready',
      isReadyLockedCases: 'Please confirm locked cases are ready',
      isReadyLockedStorage: 'Please confirm locked storage is ready',
      isReadyNameBranding: 'Please confirm branding is ready',
      isReadyPerimeter: 'Please confirm perimeter is ready',
      isReadyProductNotVisibleOutside: 'Please confirm product is not visible outside',
      isReadyRetailArea: 'Please confirm retail area is ready',
      isReadyStorage: 'Please confirm storage is ready',
      isReadySurveillanceNotice: 'Please confirm surveilance notice is ready',
      isReadyValidInterest: 'Please confirm valid interest is ready',
      isReadyWorkers: 'Please confirm workers are ready',
      lGApprovalDecision: 'Please enter a value for local government approval decision',
      lGContactEmail: 'Please enter a value for local government contact email',
      lGContactPhone: 'Please enter a value for local government contact phone',
      lGDecisionComments: 'Please enter a value for local government decision comments',
      lGDecisionSubmissionDate: 'Please enter a value for local government decision submission date',
      lGNameOfOfficial: 'Please enter a value for local government name of official',
      lGTitlePosition: 'Please enter a value for local government title of position',
      lgZoning: 'Please enter a value for local government zoning',
      licenceSubCategory: 'Please select the licence sub category',
      liquorIndustryConnections: 'Please enter industry connections',
      liquorIndustryConnectionsDetails: 'Please enter industry connection details',
      locatedAboveDescription: 'Please enter a value for located above description',
      mfgAcresOfFruit: 'Please enter a value for acres of fruit',
      mfgAcresOfGrapes: 'Please enter a value for acres of grapes',
      mfgAcresOfHoney: 'Please enter a value for acres of honey',
      mfgBrewPubOnSite: 'Please enter a value for brew pub on site',
      mfgMeetsProductionMinimum: 'Please enter a value for meets production minimum',
      mfgPipedInProduct: 'Please enter a value for brew pub on site',
      mfgStepBlending: 'Please enter a value for manufacturing blending step',
      mfgStepCrushing: 'Please enter a value for manufacturing crushing step',
      mfgStepFiltering: 'Please enter a value for manufacturing filtering step',
      mfgStepSecFermOrCarb: 'Please enter a value for manufacturing secondary fermentation or carbonation step',
      mfgUsesNeutralGrainSpirits: 'Please enter a value for manufacturing use of neutral grain spirits',
      otherBusinesses: 'Please enter a value for other businesses',
      otherBusinessesDetails: 'Please enter a value for other business details',
      patioAccessControlDescription: 'Please enter a value for patio access control description',
      patioAccessDescription: 'Please enter a value for patio access description',
      patioCompDescription: 'Please enter a value for patio comp description',
      patioIsLiquorCarried: 'Please enter a value for patio liquor carried',
      patioLiquorCarriedDescription: 'Please enter a value for patio liquor carried description',
      patioLocationDescription: 'Please enter a value for patio location description',
      patioServiceBar: 'Please enter a value for patio service bar',
      pidList: 'Please enter a value for PID list',
      policeJurisdictionId: 'Please enter a value for police jurisdiction',
      previousApplication: 'Please enter a value for previous application',
      previousApplicationDetails: 'Please enter a value for previous application details',
      proposedChange: 'Please specify if the store’s exterior will change',
      registeredEstablishment: 'Please enter a value for registered establishment number',
      renewalBranding: 'Please enter a value for renewal branding',
      renewalBusinessType: 'Please enter a value for renewal business type',
      renewalCriminalOffenceCheck: 'Please enter a value for renewal criminal offence check',
      renewalDUI: 'Please enter a value for renewal DUI check',
      renewalEstablishmentAddress: 'Please enter a value for renewal establishment address',
      renewalFloorPlan: 'Please enter a value for renewal floor plan',
      renewalOrgLeadership: 'Please enter a value for renewal organization leadership',
      renewalOutstandingFines: 'Please enter a value for renewal outstanding fines',
      renewalShareholders: 'Please enter a value for renewal shareholder',
      renewalSignage: 'Please enter a value for renewal signage',
      renewalSiteMap: 'Please enter a value for renewal site map',
      renewalThirdParty: 'Please enter a value for renwal third party',
      renewalTiedhouse: 'Please enter a value for renwal tied house',
      renewalUnreportedSaleOfBusiness: 'Please enter a value for renwal unreported sale of business',
      renewalValidInterest: 'Please enter a value for renwal valid interest',
      renewalZoning: 'Please enter a value for renwal zoning',
      renewalkeypersonnel: 'Please enter a value for renwal key personnel',
      resolutionDocsUploaded: 'Please enter a value for renwal documentation uploaded',
      ruralAgencyStoreAppointment: 'Please enter a value for rural agency store appointment number',
      tiedhouseFederalInterest: 'Please enter a value for tied house federal interest',
      willHaveValidInterest: 'Please enter a value for will have valid interest',
      zoningStatus: 'Please enter a value for zoning status'

    };


    // add the dynamic fields to the error map.
    if (this.dynamicsForm ) {
      this.dynamicsForm.tabs.forEach(function (tab) {
        tab.sections.forEach(function (section) {
          if (section.fields) {
            section.fields.forEach(function (field) {
              if (field.required) {
                if (!errorMap[field.datafieldname]) {
                  errorMap[field.datafieldname] = field.name + ' is required';
                }
              }
            }, this);
          }

        }, this);
      }, this);
    }



    return errorMap;
  }




  /**
   * Dialog to confirm the application cancellation (status changed to "Termindated")
   */
  cancelApplication() {

    const dialogConfig = {
      disableClose: true,
      autoFocus: true,
      width: '400px',
      height: '200px',
      data: {
        establishmentName: this.application.establishmentName,
        applicationName: this.application.name
      }
    };

    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(ApplicationCancellationDialogComponent, dialogConfig);
    dialogRef.afterClosed()
      .pipe(takeWhile(() => this.componentActive))
      .subscribe(cancelApplication => {
        if (cancelApplication) {
          // delete the application.
          this.busy = this.applicationDataService.cancelApplication(this.applicationId)
            .pipe(takeWhile(() => this.componentActive))
            .subscribe(() => {
              this.savedFormData = this.form.value;
              this.router.navigate(['/dashboard']);
            },
              () => {
                this.snackBar.open('Error cancelling the application', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
                console.error('Error cancelling the application');
              });
        }
      });
  }

  businessTypeIsPartnership(): boolean {
    return this.account &&
      ['GeneralPartnership',
        'LimitedPartnership',
        'LimitedLiabilityPartnership',
        'Partnership'].indexOf(this.account.businessType) !== -1;
  }

  businessTypeIsPrivateCorporation(): boolean {
    return this.account &&
      ['PrivateCorporation',
        'UnlimitedLiabilityCorporation',
        'LimitedLiabilityCorporation'].indexOf(this.account.businessType) !== -1;
  }

  businessTypeIsCorporation(): boolean {
    return this.businessTypeIsPrivateCorporation() || (this.account && ['PublicCorporation'].indexOf(this.account.businessType) !== -1);
  }

  businessTypeIsSoleProp(): boolean {
    return (this.account && ['SoleProprietorship'].indexOf(this.account.businessType) !== -1);
  }

  businessTypeIsSociety(): boolean {
    return (this.account && ['Society'].indexOf(this.account.businessType) !== -1);
  }

  canRenameEstablishment(): boolean {
    return (this.application?.applicationType?.name === ApplicationTypeNames.LiquorLicenceTransfer ||
            (this.application?.applicationType?.establishmentName !== FormControlState.ReadOnly &&
              this.showFormControl(this.application?.applicationType?.currentEstablishmentAddress)));
  }

  isCRSRenewalApplication(): boolean {
    return this.application
      && this.application.applicationType
      && [
        ApplicationTypeNames.CRSRenewal.toString(),
        ApplicationTypeNames.CRSRenewalLate30.toString(),
        ApplicationTypeNames.CRSRenewalLate6Months.toString(),
      ].indexOf(this.application.applicationType.name) !== -1;
  }

  isFormControlDisabled(fieldName: string): boolean {
    return this.form.controls[fieldName].disabled;
  }

  getEstablishmentLabel(applicationTypeName: ApplicationTypeNames): string {
    let label = 'Establishment Name';
    if ([ApplicationTypeNames.CRSTransferofOwnership, ApplicationTypeNames.CRSLocationChange].indexOf(applicationTypeName) !== -1) {
      label = 'Name of the Proposed Establishment';
    } else if (applicationTypeName === ApplicationTypeNames.CRSEstablishmentNameChange) {
      label = 'Proposed New Name';
    }
    return label;
  }

  getAreaCategoryNumber(categoryName: string): number {
    switch (categoryName) {
      case 'OutsideArea':
        return AreaCategory.OutsideArea;
      case 'Service':
        return AreaCategory.Service;
      case 'Capacity':
        return AreaCategory.Capacity;
    }
  }

  updateDynamicValidation() {
    let useDynamicValidation = true;

    // special case for Lounge Area and Special Event Area Endorsement.
    // If the patio checkbox is false then do not include the dynamic fields in validation.
    if (this.form.get('isHasPatio') && this.form.get('isHasPatio').enabled && !this.form.get('isHasPatio').value) {
      useDynamicValidation = false;
    }

    // loop through the dynamic form, updating validators.
    if (this.dynamicsForm) {
      this.dynamicsForm.tabs.forEach(function (tab) {
        tab.sections.forEach(function (section) {
          if (section.fields) {
            section.fields.forEach(function (field) {
              this.form.controls[field.datafieldname].clearValidators();
              if (useDynamicValidation === true) {
                if (field.required) {
                  this.form.controls[field.datafieldname].setValidators([Validators.required]);
                }
              }
            }, this);
          }

        }, this);
      }, this);
    }

  }

  showValidInterestforTransfer(){
    return this.application.applicationType.name === ApplicationTypeNames.LiquorLicenceTransfer &&
            (this.application.licenseType === "Licensee Retail Store" || this.application.licenseType ==="Wine Store");
  }

  showDynamicForm(formReference, tabs) {
    if (this.form.get('isHasPatio').enabled) {
      this.updateDynamicValidation();
      return this.form.get('isHasPatio').value && formReference && tabs;
    }
    return formReference && tabs;
  }
}
