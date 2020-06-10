import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { FeatureFlagService } from '@services/feature-flag.service';
import { ActivatedRoute } from '@angular/router';
import { of, Observable } from 'rxjs';
import { AccountProfileComponent } from '@components/account-profile/account-profile.component';
import { ApplicationLicenseeChangesComponent } from '@components/applications/application-licensee-changes/application-licensee-changes.component';
import { ApplicationComponent } from '@components/applications/application/application.component';
import { DynamicApplicationComponent } from '@components/applications/dynamic-application/dynamic-application.component';
import { ApplicationDataService } from '@services/application-data.service';
import { Application } from '@models/application.model';


@Component({
  selector: 'app-multi-stage-application-flow',
  templateUrl: './multi-stage-application-flow.component.html',
  styleUrls: ['./multi-stage-application-flow.component.scss']
})
export class MultiStageApplicationFlowComponent implements OnInit {
  securityScreeningEnabled: boolean;
  useDynamicFormMode: boolean = false;
  applicationId: string;
  isRAS: boolean = false;
  isFree: boolean = false;
  hasLGApproval: boolean = false;

  @ViewChild('accountProfile', { static: false }) accountProfileComponent: AccountProfileComponent;
  @ViewChild('orgStructure', { static: false }) licenseeChangesComponent: ApplicationLicenseeChangesComponent;
  @ViewChild('mainApplication', { static: false }) applicationComponent: ApplicationComponent;
  @ViewChild('dynamicApplication', { static: false }) dynamicApplicationComponent: DynamicApplicationComponent;


  constructor(public featureFlagService: FeatureFlagService, 
              private route: ActivatedRoute, 
              public applicationDataService: ApplicationDataService, 
              ) {

    featureFlagService.featureOn('SecurityScreening')
      .subscribe(featureOn => this.securityScreeningEnabled = featureOn);

    this.route.paramMap.subscribe(params => {
      this.useDynamicFormMode = params.get('useDynamicFormMode') === 'true';
      this.applicationId = params.get('applicationId');
    });

  }

  ngOnInit() {
    //this.isRAS = this.applicationComponent.isRAS();    
    //this.applicationDataService.getApplicationById(this.applicationId).Subscribe( ... 

    this.applicationDataService.getApplicationById(this.applicationId)
      .subscribe((data: Application) => {
        if (data.applicantType === 'IndigenousNation') {
          (<any>data).applyAsIndigenousNation = true;
        }

        this.isFree = data.applicationType.isFree;
        this.isRAS = data.licenseType == 'Rural Agency';
        //this.hasLGApproval = data.applicationType.show

      },
      () => {
        console.log('Error occured');
      }
    );


  }

  canDeactivate(): Observable<boolean> {
    let result: Observable<boolean> = of(true);
    if (this.accountProfileComponent) {
      result = this.accountProfileComponent.canDeactivate();
    }
    if (this.licenseeChangesComponent) {
      result = this.licenseeChangesComponent.canDeactivate();
    }
    if (this.applicationComponent) {
      result = this.applicationComponent.canDeactivate();
    }
    if (this.dynamicApplicationComponent) {
      result = this.dynamicApplicationComponent.canDeactivate();
    }
    return result;
  }


  selectionChange(event) {

  }

}
