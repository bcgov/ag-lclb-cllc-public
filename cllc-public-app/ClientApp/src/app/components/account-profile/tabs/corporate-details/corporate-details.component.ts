
import {filter,  auditTime, takeWhile } from 'rxjs/operators';
import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { UserDataService } from '@services/user-data.service';
import { AccountDataService } from '@services/account-data.service';
import { User } from '@models/user.model';
import { Account } from '@models/account.model';
import { FormBuilder, FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { MatSnackBar } from '@angular/material';
import { Subscription, Subject, Observable } from 'rxjs';
import { DatePipe } from '@angular/common';
import { DynamicsDataService } from '@services/dynamics-data.service';
import { ActivatedRoute } from '@angular/router';
import { Store } from '@ngrx/store';
import { AppState } from '@app/app-state/models/app-state';
import * as currentAccountActions from '@app/app-state/actions/current-account.action';
import { FormBase } from '@shared/form-base';

@Component({
  selector: 'app-corporate-details',
  templateUrl: './corporate-details.component.html',
  styleUrls: ['./corporate-details.component.scss']
})
export class CorporateDetailsComponent extends FormBase implements OnInit, OnDestroy {
  @Input() accountId: string;
  @Input() businessType: string;
  corporateDetailsForm: FormGroup;
  accountModel: Account;
  busy: Subscription;
  subscriptionList: Subscription[] = [];
  savedFormData: any;

  constructor(private userDataService: UserDataService,
    private accountDataService: AccountDataService,
    private dynamicsDataService: DynamicsDataService,
    private store: Store<AppState>,
    private route: ActivatedRoute,
    private fb: FormBuilder, public snackBar: MatSnackBar) {
      super();
  }

  ngOnInit() {
    this.createForm();

    const sub = this.store.select(state => state.currentAccountState)
    .pipe(takeWhile(() => this.componentActive))
    .pipe(filter(state => !!state))
      .subscribe(state => {
        this.accountId = state.currentAccount.id;
        this.businessType = state.currentAccount.businessType;
        this.setFormData(state.currentAccount);
      });
    this.subscriptionList.push(sub);
  }

  ngOnDestroy() {
    this.subscriptionList.forEach(sub => sub.unsubscribe());
  }

  setFormData(data) {
    // format date based on user locale
    const dp = new DatePipe(this.getLang());
    const dateFormat = 'y-MM-dd'; // YYYY-MM-DD

    let dtr = '';
    if (data.dateOfIncorporationInBC != null) {
      dtr = dp.transform(new Date(data.dateOfIncorporationInBC), dateFormat);
      data.dateOfIncorporationInBC = dtr;
    }

    this.corporateDetailsForm.patchValue(data);
    this.savedFormData = this.corporateDetailsForm.value;
  }

  getLang() {
    if (navigator.languages !== undefined) {
      return navigator.languages[0];
    } else {
      return navigator.language;
    }
  }

  createForm() {
    this.corporateDetailsForm = this.fb.group({
      bcIncorporationNumber: [''], // Validators.required
      dateOfIncorporationInBC: [''],
      businessNumber: [''],
      contactEmail: [''],
      contactPhone: [''],
      mailingAddressName: [''],
      mailingAddressStreet: [''],
      mailingAddressCity: [''],
      mailingAddressCountry: [''],
      mailingAddressProvince: [''],
      mailingAddressPostalCode: ['']
    });
  }

  dateLessThanToday(field1) {
    return form => {
      const d1 = form.controls[field1].value;
      if (!d1) {
        return {};
      }
      const d1Date = new Date(d1.year, d1.month, d1.day);
      if (d1Date < new Date()) {
        return { dateLessThanToday: true };
      }
      return {};
    };
  }

  canDeactivate(): Observable<boolean> | boolean {
    if (JSON.stringify(this.savedFormData) === JSON.stringify(this.corporateDetailsForm.value)) {
      return true;
    } else {
      return this.save(true);
    }
  }

  save(showProgress: boolean = false): Subject<boolean> {
    const saveResult = new Subject<boolean>();
    const saveData = this.corporateDetailsForm.value;
    this.accountModel = this.toAccountModel(this.corporateDetailsForm.value);
    const sub = this.accountDataService.updateAccount(this.accountModel).subscribe(
      res => {
        if (showProgress === true) {
          this.snackBar.open('Corporate Details have been saved', 'Success', { duration: 2500, panelClass: ['red-snackbar'] });
        }
        saveResult.next(true);
        this.savedFormData = saveData;
        this.busy = this.accountDataService.getAccount(this.accountId).subscribe(data =>
          this.store.dispatch(new currentAccountActions.SetCurrentAccountAction(data))
        );
      },
      err => {
        this.snackBar.open('Error saving Corporate Details', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
        saveResult.next(false);
        console.log('Error occured');
      });

    if (showProgress === true) {
      this.busy = sub;
    }
    return saveResult;
  }

  isFieldError(field: string) {
    const isError = !this.corporateDetailsForm.get(field).valid && this.corporateDetailsForm.get(field).touched;
    return isError;
  }

  getAccount(accountId: string) {
    this.accountDataService.getAccount(accountId).subscribe(
      res => {
        return res;
      },
      err => {
        console.log('Error occured');
      }
    );
  }

  toAccountModel(formData) {
    formData.id = this.accountId;
    // let date = formData.dateOfIncorporationInBC;
    // formData.dateOfIncorporationInBC = new Date(date.year, date.month-1, date.day);
    return formData;
  }

  toFormModel(dynamicsData) {
    // let date: Date = new Date(dynamicsData.dateOfIncorporationInBC);
    // dynamicsData.dateOfIncorporationInBC = {
    //  year: date.getFullYear(),
    //  month: date.getMonth()+1,
    //  day: date.getDate()
    // }
    return dynamicsData;
  }

}
