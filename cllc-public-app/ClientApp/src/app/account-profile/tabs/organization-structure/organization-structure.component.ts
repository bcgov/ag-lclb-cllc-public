
import {filter} from 'rxjs/operators';
import { Component, OnInit, Input } from '@angular/core';
import { UserDataService } from '../../../services/user-data.service';
import { User } from '../../../models/user.model';
import { ActivatedRoute } from '@angular/router';
import { DynamicsDataService } from '../../../services/dynamics-data.service';
import { Store } from '@ngrx/store';
import { AppState } from '../../../app-state/models/app-state';

@Component({
  selector: 'app-organization-structure',
  templateUrl: './organization-structure.component.html',
  styleUrls: ['./organization-structure.component.scss']
})
export class OrganizationStructureComponent implements OnInit {
  @Input() accountId: string;
  @Input() businessType: string;

  constructor(private route: ActivatedRoute,
    private store: Store<AppState>,
    private dynamicsDataService: DynamicsDataService) { }

  ngOnInit() {
    this.store.select(state => state.currentAccountState.currentAccount).pipe(
      filter(account => !!account))
      .subscribe(account => {
        this.accountId = account.id;
        this.businessType = account.businessType;
      });
  }

}
