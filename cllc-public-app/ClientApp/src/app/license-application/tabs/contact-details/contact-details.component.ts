import { Component, OnInit, Input } from '@angular/core';
import { AdoxioApplicationDataService } from '../../../services/adoxio-application-data.service';
import { FormBuilder, FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { MatSnackBar } from '@angular/material';
import { Subscription } from 'rxjs/Subscription';
import { auditTime } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';

@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html',
  styleUrls: ['./contact-details.component.scss']
})
export class ContactDetailsComponent implements OnInit {
  @Input() applicationId: string;
  contactDetailsForm: FormGroup;
  busy: Subscription;

  constructor(private applicationDataService: AdoxioApplicationDataService,
    private route: ActivatedRoute,
    private fb: FormBuilder, public snackBar: MatSnackBar) {
      this.applicationId =  this.route.parent.snapshot.params.applicationId;
    }

  ngOnInit() {
    // create entry form and set retrieved values
    this.createForm();
    // get application data, display form
    this.busy = this.applicationDataService.getApplicationById(this.applicationId).subscribe(
      res => {
        const data = res.json();
        this.contactDetailsForm.patchValue(data);
      },
      err => {
        this.snackBar.open('Error getting Contact Details', 'Fail', { duration: 3500, extraClasses: ['red-snackbar'] });
        console.log('Error occured getting Contact Details');
      }
    );
  }

  /**
 * Property Details Form
 * */
  createForm() {
    this.contactDetailsForm = this.fb.group({
      id: [''],
      contactpersonfirstname: [''], // Validators.required
      contactpersonlastname: [''],
      contactpersonrole: [''],
      contactpersonemail: ['', Validators.email],
      contactpersonphone: ['']
    });

    this.contactDetailsForm.valueChanges
    .pipe(auditTime(10000)).subscribe(formData => {
      this.save();
    });
  }

  canDeactivate(): Observable<boolean> | boolean {
    return this.save();
  }

  /**
   * Save data in Dynamics
   * */
  save(): Subject<boolean> {
    // console.log('contactDetailsForm valid, value: ', this.contactDetailsForm.valid, this.contactDetailsForm.value);
    const saveResult = new Subject<boolean>();
    if (this.contactDetailsForm.valid) {
      this.applicationDataService.updateApplication(this.contactDetailsForm.value).subscribe(
        res => {
          saveResult.next(true);
          // console.log("Application updated:", res.json());
          // this.snackBar.open('Contact Details have been saved', 'Success', { duration: 2500, extraClasses: ['red-snackbar'] });
        },
        err => {
          saveResult.next(false);
          this.snackBar.open('Error saving Contact Details', 'Fail', { duration: 3500, extraClasses: ['red-snackbar'] });
          console.log('Error occured saving Contact Details');
        });
    } else {
      Object.keys(this.contactDetailsForm.controls).forEach(field => {
        const control = this.contactDetailsForm.get(field);
        control.markAsTouched({ onlySelf: true });
      });
    }
    return saveResult;
  }

  /**
   * Check if entry field has an error
   * @param field
   */
  isFieldError(field: string) {
    const isError = !this.contactDetailsForm.get(field).valid && this.contactDetailsForm.get(field).touched;
    return isError;
  }

}
