import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { FormBuilder, Validators } from '@angular/forms';
import { LicenceEvent, EventStatus } from '../../models/licence-event.model';
import { LicenceEventsService } from '@services/licence-events.service';
import { FormBase } from '@shared/form-base';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-event-security-form',
  templateUrl: './security.component.html',
  styleUrls: ['./security.component.scss'],
})
export class EventSecurityFormComponent extends FormBase implements OnInit {
  isEditMode = false;
  licenceEvent: LicenceEvent;
  busy: Subscription;
  eventStatus = EventStatus;
  securityForm = this.fb.group({
    id: ['', [Validators.required]],
    licenceId: ['', [Validators.required]],
    eventLiquorLayout: ['', [Validators.required, Validators.maxLength(5000)]],
    dailyEventAttendees: ['', [Validators.required, Validators.max(999999)]],
    dailyMinorAttendees: ['', [Validators.required, Validators.max(999999)]],
    occupantLoad: ['', [Validators.required, Validators.max(999999)]],
    occupantLoadAvailable: ['', []],
    occupantLoadServiceArea: ['', [Validators.required, Validators.max(99999)]],
    occupantLoadServiceAreaAvailable: ['', []],
    serviceAreaControlledDetails: ['', [Validators.required, Validators.maxLength(2000)]],
    staffingManagers: ['', [Validators.required, Validators.max(2000)]],
    staffingBartenders: ['', [Validators.required, Validators.max(2000)]],
    staffingServers: ['', [Validators.required, Validators.max(2000)]],
    securityPersonnel: ['', [Validators.maxLength(2000)]],
    securityPersonnelThroughCompany: ['', [Validators.max(9999)]],
    securityCompanyName: ['', [Validators.maxLength(100)]],
    securityCompanyAddress: ['', [Validators.maxLength(100)]],
    securityCompanyCity: ['', [Validators.maxLength(100)]],
    securityCompanyPostalCode: ['', [Validators.maxLength(6)]],
    securityCompanyContactPerson: ['', [Validators.maxLength(100)]],
    securityCompanyPhoneNumber: ['', [Validators.maxLength(12)]],
    securityCompanyEmail: ['', [Validators.maxLength(100)]],
    securityPoliceOfficerSummary: ['', [Validators.maxLength(2000)]],
    safeAndResponsibleMinorsNotAttending: ['', []],
    safeAndResponsibleLiquorAreaControlled: ['', []],
    safeAndResponsibleLiquorAreaControlledDescription: ['', [Validators.maxLength(2000)]],
    safeAndResponsibleMandatoryID: ['', []],
    safeAndResponsibleSignsAdvisingMinors: ['', []],
    safeAndResponsibleMinorsOther: ['', []],
    safeAndResponsibleMinorsOtherDescription: ['', [Validators.maxLength(2000)]],
    safeAndResponsibleSignsAdvisingRemoval: ['', []],
    safeAndResponsibleSignsAdvisingTwoDrink: ['', []],
    safeAndResponsibleOverConsumptionOther: ['', []],
    safeAndResponsibleOverConsumptionOtherDescription: ['', [Validators.maxLength(2000)]],
    safeAndResponsibleReadAppendix2: ['', []],
    safeAndResponsibleDisturbancesOther: ['', []],
    safeAndResponsibleDisturbancesOtherDescription: ['', [Validators.maxLength(2000)]],
    safeAndResponsibleAdditionalSafetyMeasures: ['', [Validators.maxLength(2000)]],
    declarationIsAccurate: [false, [Validators.required]]
  });

  constructor(
    private fb: FormBuilder,
    private licenceEvents: LicenceEventsService,
    private router: Router,
    private route: ActivatedRoute
    ) {
      super();
      this.route.paramMap.subscribe(params => {
        this.securityForm.controls['licenceId'].setValue(params.get('licenceId'));
        this.securityForm.controls['id'].setValue(params.get('eventId'));
      });
    }

  ngOnInit() {
    this.retrieveSavedEvent(this.securityForm.controls['id'].value);
  }

  retrieveSavedEvent(eventId: string) {
    this.busy = this.licenceEvents.getLicenceEvent(eventId)
    .subscribe((licenceEvent) => {
      this.setFormToLicenceEvent(licenceEvent);
    });
  }

  setFormToLicenceEvent(licenceEvent: LicenceEvent) {
    this.securityForm.setValue({
      id: licenceEvent.id,
      licenceId: licenceEvent.licenceId,
      eventLiquorLayout: licenceEvent.eventLiquorLayout,
      dailyEventAttendees: licenceEvent.dailyEventAttendees,
      dailyMinorAttendees: licenceEvent.dailyMinorAttendees,
      occupantLoad: licenceEvent.occupantLoad,
      occupantLoadAvailable: licenceEvent.occupantLoadAvailable,
      occupantLoadServiceArea: licenceEvent.occupantLoadServiceArea,
      occupantLoadServiceAreaAvailable: licenceEvent.occupantLoadServiceAreaAvailable,
      serviceAreaControlledDetails: licenceEvent.serviceAreaControlledDetails,
      staffingManagers: licenceEvent.staffingManagers,
      staffingBartenders: licenceEvent.staffingBartenders,
      staffingServers: licenceEvent.staffingServers,
      securityPersonnel: licenceEvent.securityPersonnel,
      securityPersonnelThroughCompany: licenceEvent.securityPersonnelThroughCompany,
      securityCompanyName: licenceEvent.securityCompanyName,
      securityCompanyAddress: licenceEvent.securityCompanyAddress,
      securityCompanyCity: licenceEvent.securityCompanyCity,
      securityCompanyPostalCode: licenceEvent.securityCompanyPostalCode,
      securityCompanyContactPerson: licenceEvent.securityCompanyContactPerson,
      securityCompanyPhoneNumber: licenceEvent.securityCompanyPhoneNumber,
      securityCompanyEmail: licenceEvent.securityCompanyEmail,
      securityPoliceOfficerSummary: licenceEvent.securityPoliceOfficerSummary,
      safeAndResponsibleMinorsNotAttending: licenceEvent.safeAndResponsibleMinorsNotAttending,
      safeAndResponsibleLiquorAreaControlled: licenceEvent.safeAndResponsibleLiquorAreaControlled,
      safeAndResponsibleLiquorAreaControlledDescription: licenceEvent.safeAndResponsibleLiquorAreaControlledDescription,
      safeAndResponsibleMandatoryID: licenceEvent.safeAndResponsibleMandatoryID,
      safeAndResponsibleSignsAdvisingMinors: licenceEvent.safeAndResponsibleSignsAdvisingMinors,
      safeAndResponsibleMinorsOther: licenceEvent.safeAndResponsibleMinorsOther,
      safeAndResponsibleMinorsOtherDescription: licenceEvent.safeAndResponsibleMinorsOtherDescription,
      safeAndResponsibleSignsAdvisingRemoval: licenceEvent.safeAndResponsibleSignsAdvisingRemoval,
      safeAndResponsibleSignsAdvisingTwoDrink: licenceEvent.safeAndResponsibleSignsAdvisingTwoDrink,
      safeAndResponsibleOverConsumptionOther: licenceEvent.safeAndResponsibleOverConsumptionOther,
      safeAndResponsibleOverConsumptionOtherDescription: licenceEvent.safeAndResponsibleOverConsumptionOtherDescription,
      safeAndResponsibleReadAppendix2: licenceEvent.safeAndResponsibleReadAppendix2,
      safeAndResponsibleDisturbancesOther: licenceEvent.safeAndResponsibleDisturbancesOther,
      safeAndResponsibleDisturbancesOtherDescription: licenceEvent.safeAndResponsibleDisturbancesOtherDescription,
      safeAndResponsibleAdditionalSafetyMeasures: licenceEvent.safeAndResponsibleAdditionalSafetyMeasures,
      declarationIsAccurate: false
    });
  }

  save() {
    this.updateLicence();
  }

  clearRelatedFormFieldIfNotOther(options: any, fieldName: string, relatedField: string) {
    const option = this.getOptionFromValue(options, this.securityForm.controls[fieldName].value);
    if (option.label !== 'Other') {
      this.securityForm.controls[relatedField].setValue('');
      this.securityForm.controls[relatedField].setValidators([]);
    } else {
      this.securityForm.controls[relatedField].setValidators([Validators.required]);
    }
    this.securityForm.controls[relatedField].updateValueAndValidity();
  }

  updateLicence() {
    this.busy = this.licenceEvents.updateLicenceEvent(this.securityForm.get('id').value, {...this.securityForm.value})
    .subscribe((licenceEvent) => {
      this.router.navigate(['/licences']);
    });
  }

  createLicence() {
    this.securityForm.removeControl('id');
    this.busy = this.licenceEvents.createLicenceEvent({...this.securityForm.value})
    .subscribe((licenceEvent) => {
      this.router.navigate(['/licences']);
    });
  }

  compareFn(c1: any, c2: any): boolean {
    return c1 && c2 ? c1.value === c2.value : c1 === c2;
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
  
  printValidity() {
    return Object.keys(this.securityForm.controls)
    .map( control => {
        return `${control} - ${this.securityForm.controls[control].valid}\n`;
     });
  }

  isFormInvalid() {
    return this.securityForm.invalid || !this.securityForm.controls['declarationIsAccurate'].value;
  }

  cancel() {
    if (this.isEditMode) {
      const id = this.securityForm.get('id').value;
      this.securityForm.reset();
      this.securityForm.controls['id'].setValue(id);
      this.securityForm.controls['status'].setValue(this.getOptionFromLabel(this.eventStatus, 'Cancelled').value);
      this.updateLicence();
    } else {
      this.router.navigate(['/licences']);
    }
  }
}
