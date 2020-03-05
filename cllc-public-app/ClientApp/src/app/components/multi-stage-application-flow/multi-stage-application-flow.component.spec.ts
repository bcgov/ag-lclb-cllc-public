import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MultiStageApplicationFlowComponent } from './multi-stage-application-flow.component';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { AppState } from '@app/app-state/models/app-state';
import { provideMockStore } from '@ngrx/store/testing';
import { ApplicationLicenseeChangesComponent } from '@components/applications/application-licensee-changes/application-licensee-changes.component';
import { AccountProfileComponent } from '@components/account-profile/account-profile.component';
import { ApplicationComponent } from '@components/applications/application/application.component';
import { FeatureFlagService } from '@services/feature-flag.service';
import { of } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { ActivatedRouteStub } from '@app/testing/activated-route-stub';

describe('MultiStageApplicationFlowComponent', () => {
  let component: MultiStageApplicationFlowComponent;
  let fixture: ComponentFixture<MultiStageApplicationFlowComponent>;
  let initialState = {
    onGoingLicenseeChangesApplicationIdState: {onGoingLicenseeChangesApplicationId: '1'},
  } as AppState;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MultiStageApplicationFlowComponent, ApplicationLicenseeChangesComponent, AccountProfileComponent, ApplicationComponent ],
      schemas: [NO_ERRORS_SCHEMA],
      providers: [
        provideMockStore({initialState}),
        { provide: ActivatedRoute, useValue: new ActivatedRouteStub() },
        { provide: FeatureFlagService, useValue: {featureOn: () => of(true)} }
      ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MultiStageApplicationFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  afterEach(() => { fixture.destroy(); });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
