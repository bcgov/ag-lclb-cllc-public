import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardComponent } from './dashboard.component';
import { Component, Input, NO_ERRORS_SCHEMA } from '@angular/core';
import { StoreModule, Store } from '@ngrx/store';
import { reducers, metaReducers } from '@app/app-state/reducers/reducers';
import { MockStore, provideMockStore } from '@ngrx/store/testing';
import { Account } from '@models/account.model';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material';
import { LegalEntityDataService } from '@services/legal-entity-data.service';
import { ApplicationDataService } from '@services/application-data.service';
import { of } from 'rxjs/internal/observable/of';
import { AppState } from '@app/app-state/models/app-state';
import { AssociateContentComponent } from './associate-content/associate-content.component';
import { LicenseDataService } from '@services/license-data.service';
import { FeatureFlagDataService } from '@services/feature-flag-data.service';

const httpClientSpy: { get: jasmine.Spy } = jasmine.createSpyObj('HttpClient', ['get']);

@Component({ selector: 'app-applications-and-licences', template: '' })
class ApplicationsAndLicencesComponent {
  @Input() account: any;
}

describe('DashboardComponent', () => {
  let component: DashboardComponent;
  let fixture: ComponentFixture<DashboardComponent>;
  let store: MockStore<AppState>;

  const account = new Account();
  account.businessType = 'PublicCorporation';
  const initialState = {
    currentAccountState: { currentAccount: account },
    currentUserState: { currentUser: {} },
    indigenousNationState: { indigenousNationModeActive: false }
  } as AppState;


  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [
        StoreModule.forRoot(reducers, { metaReducers }),
      ],
      declarations: [DashboardComponent, AssociateContentComponent, ApplicationsAndLicencesComponent],
      schemas: [NO_ERRORS_SCHEMA],
      providers: [
        provideMockStore({ initialState }),
        { provide: Router, useValue: {} },
        { provide: FeatureFlagDataService, useValue: { getFeatureFlags: () => of([]) } },
        { provide: ApplicationDataService, useValue: {} },
        { provide: LicenseDataService, useValue: { getAllCurrentLicenses: () => of([]) } },
        { provide: LegalEntityDataService, useValue: { getCurrentHierachy: () => of({}) } },
        { provide: MatSnackBar, useValue: {} }
      ]
    })
      .compileComponents();

    store = TestBed.get(Store);
    // applicationService = TestBed.get(ApplicationDataService)
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  afterEach(() => { fixture.destroy(); });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should have "Cannabis" in the title', () => {
    const bannerElement: HTMLElement = fixture.nativeElement;
    const header = bannerElement.querySelector('h1');
    expect(header.textContent).toContain('Cannabis');
  });
});
