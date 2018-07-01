import { Component, OnInit, ViewChild, Input } from '@angular/core';
import { User } from '../models/user.model';
import { UserDataService } from '../services/user-data.service';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';

@Component({
  selector: 'app-license-application',
  templateUrl: './license-application.component.html',
  styleUrls: ['./license-application.component.scss']
})
export class LicenseApplicationComponent implements OnInit {

  applicationId: string;
  @Input('currentUser') currentUser: User;
  @Input('accountId') accountId: string;

  public view_tab: string;
  public contactId: string;
  public componentLoaded: boolean;

  tabs: any = {
    application: ['contact-details', 'property-details', 'store-information', 'floor-plan', 'site-map', 'declaration', 'submit-pay'],
  };
  tabStructure: any[] = this.tabs.application;

  constructor(private userDataService: UserDataService, private route: ActivatedRoute) {
    // TODO check license status to set initial tab
    this.view_tab = "contact-details";
    this.applicationId = route.snapshot.params.applicationId;
  }

  ngOnInit(): void {

    // TODO - pass currentUser in as router data rather than doing another call to getCurrentUser.
    if (!this.currentUser) {
      this.userDataService.getCurrentUser()
        .then((data) => {
          this.currentUser = data;
          if (!this.accountId) {
            this.accountId = this.currentUser.accountid;
          }
          this.componentLoaded = true;
        });
    }
  }

  getTab() {
    let result = this.tabStructure.indexOf(this.view_tab);
    return result;
  }

  changeTab(tab) {
    this.view_tab = tab;
  }

  back() {
    var currentTab = this.getTab();
    currentTab--;
    if (currentTab < 0) {
      currentTab = this.tabStructure.length - 1;
    }
    this.view_tab = this.tabStructure[currentTab];
  }

  next() {
    var currentTab = this.getTab();
    currentTab++;
    if (currentTab >= this.tabStructure.length) {
      currentTab = 0;
    }
    this.view_tab = this.tabStructure[currentTab];
  }

}
