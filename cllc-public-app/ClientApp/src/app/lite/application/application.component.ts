import { Component, OnInit, OnDestroy } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Store } from '@ngrx/store';
import { AppState } from '../../app-state/models/app-state';
import { Subscription } from 'rxjs/Subscription';
import { Subject } from 'rxjs/Subject';
import { Observable } from 'rxjs/Observable';
import { MatSnackBar } from '@angular/material';
import * as currentApplicationActions from '../../app-state/actions/current-application.action';
import { ActivatedRoute, Router } from '@angular/router';
import { AdoxioApplicationDataService } from '../../services/adoxio-application-data.service';
import { PaymentDataService } from '../../services/payment-data.service';

@Component({
  selector: 'app-application',
  templateUrl: './application.component.html',
  styleUrls: ['./application.component.css']
})
export class ApplicationComponent implements OnInit, OnDestroy {

  form: FormGroup;
  savedFormData: any;
  subscriptions: Subscription[] = [];
  applicationId: string;
  busy: Subscription;
  accountId: string;
  payMethod: string;

  constructor(private store: Store<AppState>,
    private paymentDataService: PaymentDataService,
    public snackBar: MatSnackBar,
    public router: Router,
    private applicationDataService: AdoxioApplicationDataService,
    private route: ActivatedRoute,
    private fb: FormBuilder) {
    this.applicationId = this.route.snapshot.params.applicationId;
  }

  ngOnInit() {
    this.form = this.fb.group({
      id: [''],
      establishmentName: [''], // Validators.required
    });

    this.busy = this.applicationDataService.getApplicationById(this.applicationId).subscribe(
      res => {
        const data = res.json();
        // this.applicationName = data.name;
        // this.store.dispatch(new currentApplicatioActions.SetCurrentApplicationAction(data));
        this.form.patchValue(data);
        if (data.isPaid) {
          this.form.disable();
        }
        this.savedFormData = this.form.value;
      },
      err => {
        console.log('Error occured');
      }
    );

    const sub = this.store.select(state => state.currentApplicaitonState.currentApplication)
      .filter(state => !!state)
      .subscribe(currentApplication => {
        this.form.patchValue(currentApplication);
        if (currentApplication.isPaid) {
          this.form.disable();
        }
        this.savedFormData = this.form.value;
      });
    this.subscriptions.push(sub);
  }

  ngOnDestroy(): void {
    this.subscriptions.forEach(sub => sub.unsubscribe());
  }

  canDeactivate(): Observable<boolean> | boolean {
    if (JSON.stringify(this.savedFormData) === JSON.stringify(this.form.value)) {
      return true;
    } else {
      return this.save(true);
    }
  }

  /**
   * Save form data
   * @param showProgress
   */
  save(showProgress: boolean = false): Subject<boolean> {
    const saveResult = new Subject<boolean>();
    const saveData = this.form.value;
    const subscription = this.applicationDataService.updateApplication(this.form.value).subscribe(
      res => {
        saveResult.next(true);
        this.savedFormData = saveData;
        this.updateApplicationInStore();
        if (showProgress === true) {
          this.snackBar.open('Application has been saved', 'Success', { duration: 2500, extraClasses: ['red-snackbar'] });
        }
      },
      err => {
        saveResult.next(false);
        this.snackBar.open('Error saving Application', 'Fail', { duration: 3500, extraClasses: ['red-snackbar'] });
        console.log('Error occured');
      });

    if (showProgress === true) {
      this.busy = subscription;
    }

    return saveResult;
  }

  updateApplicationInStore() {
    this.applicationDataService.getApplicationById(this.applicationId).subscribe(
      res => {
        const data = res.json();
        this.store.dispatch(new currentApplicationActions.SetCurrentApplicationAction(data));
      }
    );
  }

  isFieldError(field: string) {
    const isError = !this.form.get(field).valid && this.form.get(field).touched;
    return isError;
  }

  submit_application() {
    this.busy = this.paymentDataService.getPaymentSubmissionUrl(this.applicationId).subscribe(
      res => {
        // console.log("applicationVM: ", res.json());
        const jsonUrl = res.json();
        // window.alert(jsonUrl['url']);
        window.location.href = jsonUrl['url'];
        return jsonUrl['url'];
      },
      err => {
        console.log('Error occured');
      }
    );


  }
}
