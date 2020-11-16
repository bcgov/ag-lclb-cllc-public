import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { FormBuilder, Validators } from '@angular/forms';
import { LicenceEvent, EventStatus } from '../../models/licence-event.model';
import { LicenceEventsService } from '@services/licence-events.service';
import { takeWhile } from 'rxjs/operators';
import { AppState } from '@app/app-state/models/app-state';
import { Store } from '@ngrx/store';
import { User } from '@models/user.model';
import { FormBase } from '@shared/form-base';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-offsite-storage',
  templateUrl: './offsite-storage.component.html',
  styleUrls: ['./offsite-storage.component.scss'],
})
export class OffsiteStorageComponent extends FormBase implements OnInit {
  isEditMode = true;
  isReadOnly = false;
  showErrorSection = false;

  licenceEvent: LicenceEvent;

  busy: Subscription;
  eventStatus = EventStatus;

  form = this.fb.group({
    status: ['', [Validators.required]],
    id: ['', []],
    name: ['', []],
    licenceId: ['', []],
    accountId: ['', []],
    contactName: ['', [Validators.required]],
    contactPhone: ['', [Validators.required]],
    contactEmail: ['', [Validators.required]],
    street1: ['', [Validators.required]],
    street2: ['', []],
    city: ['', [Validators.required]],
    province: ['BC', [Validators.required]],
    postalCode: ['', [Validators.required]],
    startDate: ['', [Validators.required]],
    endDate: ['', [Validators.required]],
    sepLicensee: ['', [Validators.required]],
    sepLicenceNumber: ['', [Validators.required]],
    sepContactName: ['', [Validators.required]],
    sepContactPhoneNumber: ['', [Validators.required]],
    agreement: [false, [Validators.required]]
  });

  constructor(
    private fb: FormBuilder,
    private licenceEvents: LicenceEventsService,
    private store: Store<AppState>,
    private router: Router,
    private route: ActivatedRoute
  ) {
    super();
    this.route.paramMap.subscribe(params => {
      this.form.get('licenceId').setValue(params.get('licenceId'));
    });
  }

  ngOnInit() {
    this.store
      .select(state => state.currentUserState.currentUser)
      .pipe(takeWhile(() => this.componentActive))
      .subscribe((data: User) => {
        this.form.controls['contactEmail'].setValue(data.email);
      });
  }

  retrieveSavedEvent(eventId: string) {
    this.busy = this.licenceEvents
      .getLicenceEvent(eventId)
      .subscribe((licenceEvent) => {
        this.setFormToLicenceEvent(licenceEvent);
      });
  }

  setFormToLicenceEvent(licenceEvent: LicenceEvent) {
    if (licenceEvent.status === this.getOptionFromLabel(this.eventStatus, 'Approved').value) {
      this.isReadOnly = true;
    }

    this.form.setValue({
      status: licenceEvent.status,
      id: licenceEvent.id,
      name: licenceEvent.name,
      licenceId: licenceEvent.licenceId,
      accountId: licenceEvent.accountId,
      contactName: licenceEvent.contactName,
      contactPhone: licenceEvent.contactPhone,
      contactEmail: licenceEvent.contactEmail,
      sepLicenceNumber: licenceEvent.sepLicenceNumber,
      sepLicensee: licenceEvent.sepLicensee,
      sepContactName: licenceEvent.sepContactName,
      sepContactPhoneNumber: licenceEvent.sepContactPhoneNumber,
      street1: licenceEvent.street1,
      street2: licenceEvent.street2,
      city: licenceEvent.city,
      province: licenceEvent.province,
      postalCode: licenceEvent.postalCode,
      startDate: new Date(licenceEvent.startDate),
      endDate: new Date(licenceEvent.endDate),
      agreement: false
    });

    if (this.isReadOnly) {
      this.form.disable();
    }
  }

  save(submit = false) {
    if (submit) {
      this.form.controls['status'].setValue(this.getOptionFromLabel(this.eventStatus, 'Submitted').value);
    }

    if (this.isEditMode) {
      this.updateLicence();
    } else {
      this.createLicence();
    }
  }

  updateLicence() {
    this.busy = this.licenceEvents.updateLicenceEvent(this.form.get('id').value, { ...this.form.value })
      .subscribe((licenceEvent) => {
        this.router.navigate(['/licences']);
      });
  }

  createLicence() {
    this.form.removeControl('id');
    this.busy = this.licenceEvents.createLicenceEvent({ ...this.form.value })
      .subscribe((licenceEvent) => {
        this.router.navigate(['/licences']);
      });
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


  isFormValid() {
    return this.form.invalid || !this.form.controls['agreement'].value;
  }

  cancel() {
    if (this.isEditMode) {
      const id = this.form.get('id').value;
      const status = this.getOptionFromLabel(this.eventStatus, 'Cancelled').value;
      this.busy = this.licenceEvents.updateLicenceEvent(id, { ...this.form.value, status: status, licenceId: this.form.get('licenceId').value })
        .subscribe((licenceEvent) => {
          this.router.navigate(['/licences']);
        });
    } else {
      this.router.navigate(['/licences']);
    }
  }
}