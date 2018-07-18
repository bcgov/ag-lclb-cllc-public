import { Component, OnInit, Input, OnDestroy } from '@angular/core';
import { MatSnackBar } from '@angular/material';
import { FormBuilder } from '@angular/forms';
import { TiedHouseConnectionsDataService } from '../../../services/tied-house-connections-data.service';
import { TiedHouseConnection } from '../../../models/tied-house-connection.model';
import { auditTime } from 'rxjs/operators';
import { ActivatedRoute } from '@angular/router';
import { DynamicsDataService } from '../../../services/dynamics-data.service';
import { Observable, Subject, Subscription } from 'rxjs';
import { Store } from '@ngrx/store';
import { AppState } from '../../../app-state/models/app-state';

@Component({
  selector: 'app-connection-to-producers',
  templateUrl: './connection-to-producers.component.html',
  styleUrls: ['./connection-to-producers.component.css']
})
export class ConnectionToProducersComponent implements OnInit, OnDestroy {
  @Input() accountId: string;
  @Input() businessType: string;
  busy: Subscription;
  subscriptions: Subscription[] = [];
  savedFormData: any = {};

  operatingForMoreThanOneYear: any;
  form: any;
  _tiedHouseData: TiedHouseConnection;

  constructor(private fb: FormBuilder,
    public snackBar: MatSnackBar,
    private store: Store<AppState>,
    private tiedHouseService: TiedHouseConnectionsDataService,
    private dynamicsDataService: DynamicsDataService,
    private route: ActivatedRoute) { }

  ngOnInit() {
    this.form = this.fb.group({
      corpConnectionFederalProducer: [''],
      corpConnectionFederalProducerDetails: [''],
      federalProducerConnectionToCorp: [''],
      federalProducerConnectionToCorpDetails: [''],
      share20PlusConnectionProducer: [''],
      share20PlusConnectionProducerDetails: [''],
      share20PlusFamilyConnectionProducer: [''],
      share20PlusFamilyConnectionProducerDetail: [''],
      partnersConnectionFederalProducer: [''],
      partnersConnectionFederalProducerDetails: [''],
      societyConnectionFederalProducer: [''],
      societyConnectionFederalProducerDetails: ['']
    });



    const sub = this.store.select(state => state.currentAccountState)
      .filter(state => !!state)
      .subscribe(state => {
        this.accountId = state.currentAccount.id;
        this.businessType = state.currentAccount.businessType;
        this.busy = this.tiedHouseService.getTiedHouse(this.accountId)
          .subscribe(res => {
            this._tiedHouseData = res.json();
            this.form.patchValue(this._tiedHouseData);
            this.savedFormData = this.form.value;
            this.form.valueChanges
              .pipe(auditTime(10000)).subscribe(formData => {
                if (JSON.stringify(formData) !== JSON.stringify(this.savedFormData)) {
                  this.save();
                }
              });
          });
      });
    this.subscriptions.push(sub);

  }

  ngOnDestroy() {
    this.subscriptions.forEach(sub => sub.unsubscribe());
  }

  canDeactivate(): Observable<boolean> | boolean {
    if (JSON.stringify(this.savedFormData) === JSON.stringify(this.form.value)) {
      return true;
    } else {
      return this.save(true);
    }
  }

  save(showProgress: boolean = false): Subject<boolean> {
    const data = (<any>Object).assign(this._tiedHouseData, this.form.value);
    const saveData = this.form.value;
    const saveObservable = new Subject<boolean>();
    const subscription = this.tiedHouseService.updateTiedHouse(data, data.id).subscribe(res => {
      if (showProgress === true) {
        this.snackBar.open('Connections to producers have been saved', 'Success', { duration: 3500, extraClasses: ['red-snackbar'] });
      }
      saveObservable.next(true);
      this.savedFormData = saveData;
    },
      err => {
        this.snackBar.open('Error saving Connections to producers', 'Fail', { duration: 3500, extraClasses: ['red-snackbar'] });
        saveObservable.next(false);
        console.log('Error occured');
      });

    if (showProgress === true) {
      this.busy = subscription;
    }
    return saveObservable;
  }

}
