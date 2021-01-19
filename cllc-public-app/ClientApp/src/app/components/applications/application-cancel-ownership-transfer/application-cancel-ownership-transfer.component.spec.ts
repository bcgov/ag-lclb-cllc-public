
import { ApplicationCancelOwnershipTransferComponent } from "./application-cancel-ownership-transfer.component";
import { ComponentFixture, TestBed, waitForAsync } from "@angular/core/testing";
import { ActivatedRoute } from "@angular/router";
import { NO_ERRORS_SCHEMA } from "@angular/core";
import { StoreModule } from "@ngrx/store";
import { reducers, metaReducers } from "@app/app-state/reducers/reducers";
import { PaymentDataService } from "@services/payment-data.service";
import { MatSnackBar, MatDialog } from "@angular/material";
import { RouterTestingModule } from "@angular/router/testing";
import { HttpClientTestingModule } from "@angular/common/http/testing";
import { DynamicsDataService } from "@services/dynamics-data.service";
import { FormBuilder } from "@angular/forms";
import { TiedHouseConnectionsDataService } from "@services/tied-house-connections-data.service";
import { of } from "rxjs";
import { provideMockStore } from "@ngrx/store/testing";
import { AppState } from "@app/app-state/models/app-state";
import { ActivatedRouteStub } from "@app/testing/activated-route-stub";
import { Account } from "@models/account.model";
import { LicenseDataService } from "@services/license-data.service";
import { License } from "@models/license.model";
import { FieldComponent } from "@shared/components/field/field.component";

let paymentDataServiceStub: Partial<PaymentDataService>;
let licenceDataServiceStub: Partial<LicenseDataService>;
let dynamicsDataServiceStub: Partial<DynamicsDataService>;
let tiedHouseConnectionsDataServiceStub: Partial<TiedHouseConnectionsDataService>;
let matDialogStub: Partial<MatDialog>;
let matSnackBarStub: Partial<MatSnackBar>;
let activatedRouteStub: ActivatedRouteStub;

describe("ApplicationCancelOwnershipTransferComponent",
  () => {
    let component: ApplicationCancelOwnershipTransferComponent;
    let fixture: ComponentFixture<ApplicationCancelOwnershipTransferComponent>;

    const account = new Account();
    account.businessType = "PublicCorporation";
    const initialState = {
      currentAccountState: { currentAccount: account },
      currentUserState: { currentUser: {} }
    } as AppState;

    beforeEach(waitForAsync(() => {
      paymentDataServiceStub = {};
      licenceDataServiceStub = {
        getLicenceById: () => of({} as License),

      };
      dynamicsDataServiceStub = { getRecord: () => of([]) };
      tiedHouseConnectionsDataServiceStub = {
        updateTiedHouse: () => of(null)
      };
      matDialogStub = {};
      matSnackBarStub = {};
      activatedRouteStub = new ActivatedRouteStub({ applicationId: 1 });
      TestBed.configureTestingModule({
          declarations: [ApplicationCancelOwnershipTransferComponent, FieldComponent],
          imports: [
            RouterTestingModule,
            HttpClientTestingModule,
            StoreModule.forRoot(reducers, { metaReducers }),
          ],
          providers: [
            provideMockStore({ initialState }),
            FormBuilder,
            { provide: PaymentDataService, useValue: paymentDataServiceStub },
            { provide: LicenseDataService, useValue: licenceDataServiceStub },
            { provide: DynamicsDataService, useValue: dynamicsDataServiceStub },
            { provide: TiedHouseConnectionsDataService, useValue: tiedHouseConnectionsDataServiceStub },
            { provide: MatDialog, useValue: matDialogStub },
            { provide: ActivatedRoute, useValue: activatedRouteStub },
            { provide: MatSnackBar, useValue: matSnackBarStub },
          ],
          schemas: [NO_ERRORS_SCHEMA]
        })
        .compileComponents();
    }));

    beforeEach(() => {
      fixture = TestBed.createComponent(ApplicationCancelOwnershipTransferComponent);
      component = fixture.debugElement.componentInstance;
      fixture.detectChanges();
    });

    afterEach(() => { fixture.destroy(); });

    it("should create",
      () => {
        expect(component).toBeTruthy();
      });
  });
