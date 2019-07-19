import { Component, OnInit, Input, Inject, ChangeDetectorRef } from '@angular/core';
import { MatPaginator, MatTableDataSource, MatSort, MatDialog, MatDialogConfig, MatDialogRef } from '@angular/material';
import { FormBuilder, FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { MatSnackBar } from '@angular/material';
import { Subscription } from 'rxjs';
import { MAT_DIALOG_DATA } from '@angular/material';
import { ActivatedRouteSnapshot, ActivatedRoute } from '@angular/router';
import { LegalEntityDataService } from '@services/legal-entity-data.service';
import { Account } from '@models/account.model';
import { DynamicsDataService } from '@services/dynamics-data.service';
import { Store } from '@ngrx/store';
import { AppState } from '@app/app-state/models/app-state';
import * as LegalEntitiesActions from '@app/app-state/actions/legal-entities.action';
import { LegalEntity } from '@models/legal-entity.model';

@Component({
  selector: 'app-shareholders',
  templateUrl: './shareholders.component.html',
  styleUrls: ['./shareholders.component.scss']
})

export class EditShareholdersComponent implements OnInit {
  @Input() accountId: string;
  @Input() parentLegalEntityId: string;
  @Input() businessType: string;

  shareholderForm: FormGroup;
  shareholderList: LegalEntity[] = [];
  dataSource = new MatTableDataSource<LegalEntity>();
  displayedColumns = ['additional', 'name', 'email', 'percentageVotingShares', 'commonvotingshares', 'edit', 'delete'];
  busy: Promise<any>;
  busyObsv: Subscription;
  form: FormGroup;
  showAddShareholder = false;


  constructor(private legalEntityDataservice: LegalEntityDataService,
    private route: ActivatedRoute,
    private store: Store<AppState>,
    private fb: FormBuilder,
    private dynamicsDataService: DynamicsDataService,
    public dialog: MatDialog,
    public snackBar: MatSnackBar) {
  }

  ngOnInit() {
    this.getShareholders();
    this.updateDisplayedColumns();

    this.form = this.fb.group({
      id: [''],
      name: [''],
      firstname: ['', Validators.required],
      lastname: ['', Validators.required],
      dateofbirth: [''],
      email: ['', Validators.email],
      commonvotingshares: ['', Validators.required],
      partnerType: ['', Validators.required],
      dateIssued: ['']
    });
  }

  updateDisplayedColumns() {
    if (['GeneralPartnership', 'LimitedPartnership', 'LimitedLiabilityPartnership'].indexOf(this.businessType) !== -1) {
      this.displayedColumns = ['partnerType', 'name', 'email', 'edit', 'delete'];
    } else {
      this.displayedColumns = ['name', 'additional', 'commonvotingshares', 'percentageVotingShares', 'email', 'edit', 'delete'];
    }
  }

  getShareholders() {
    let position = 'shareholders';
    if (['GeneralPartnership', 'LimitedLiabilityPartnership', 'LimitedPartnership'].indexOf(this.businessType) !== -1) {
      position = 'partners';
    }
    this.busyObsv = this.legalEntityDataservice.getLegalEntitiesbyPosition(this.parentLegalEntityId, position)
      .subscribe((data: LegalEntity[]) => {
        const totalShares = (data || [])
          .map(entity => entity.commonvotingshares || 0)
          .reduce((a, v) => a + v);

        data.forEach(d => {
          d.position = this.getPosition(d);
          if (totalShares > 0) {
            d.percentageVotingShares = 100 * ((d.commonvotingshares || 0) / totalShares);
            d.percentageVotingShares = Math.floor(d.percentageVotingShares * 100) / 100;
          }
        });
        this.dataSource.data = data;
      });
  }


  getPosition(shareholder: LegalEntity): string {
    let position = '';
    if (shareholder.isindividual) {
      position = 'Individual';
    } else {
      switch (shareholder.legalentitytype) {
        case 'PrivateCorporation':
          position = 'Private Corporation';
          break;
        case 'PublicCorporation':
          position = 'Public Corporation';
          break;
        case 'UnlimitedLiabilityCorporation':
          position = 'Unlimited Liability Corporation';
          break;
        case 'LimitedLiabilityCorporation':
          position = 'Limited Liability Corporation';
          break;
        case 'GeneralPartnership':
          position = 'General Partnership';
          break;
        case 'LimitedPartnership':
          position = 'Limited Partnership';
          break;
        case 'LimitedLiabilityPartnership':
          position = 'Limited Liability Partnership';
          break;
        case 'SoleProprietor':
          position = 'Sole Proprietor';
          break;
        case 'Society':
          position = 'Society';
          break;
        case 'Coop':
          position = 'Co-op';
          break;
        case 'Estate':
          position = 'Estate';
          break;
        case 'Trust':
          position = 'Trust';
          break;
        default:
          break;
      }
    }
    return position;
  }

  formDataToModelData(formData: any, shareholderType: string): LegalEntity {
    const adoxioLegalEntity: LegalEntity = new LegalEntity();
    adoxioLegalEntity.id = formData.id;
    if (['GeneralPartnership', 'LimitedPartnership', 'LimitedLiabilityPartnership'].indexOf(this.businessType) !== -1) {
      adoxioLegalEntity.isPartner = true;
      adoxioLegalEntity.isShareholder = false;
      if (this.businessType === 'GeneralPartnership') {
        adoxioLegalEntity.partnerType = 'General';
      } else if (this.businessType === 'LimitedLiabilityPartnership') {
        adoxioLegalEntity.partnerType = 'Limited';
      } else {
        adoxioLegalEntity.partnerType = formData.partnerType;
      }
    } else {
      adoxioLegalEntity.isShareholder = true;
      adoxioLegalEntity.isPartner = false;
    }
    adoxioLegalEntity.parentLegalEntityId = this.parentLegalEntityId;
    if (shareholderType === 'Person') {
      adoxioLegalEntity.isindividual = true;
      adoxioLegalEntity.firstname = formData.firstname;
      adoxioLegalEntity.lastname = formData.lastname;
      adoxioLegalEntity.name = formData.firstname + ' ' + formData.lastname;
      adoxioLegalEntity.email = formData.email;
    } else {
      adoxioLegalEntity.isindividual = false;
      adoxioLegalEntity.name = formData.name;
      adoxioLegalEntity.legalentitytype = formData.legalentitytype;
    }
    adoxioLegalEntity.commonnonvotingshares = formData.commonnonvotingshares;
    adoxioLegalEntity.commonvotingshares = formData.commonvotingshares;
    // adoxioLegalEntity.dateIssued = formData.dateIssued;
    // adoxioLegalEntity.relatedentities = [];
    // the accountId is received as parameter from the business profile
    if (this.accountId) {
      adoxioLegalEntity.account = <Account>{};
      adoxioLegalEntity.account.id = this.accountId;
    }
    return adoxioLegalEntity;
  }

  editShareholder(shareholder: LegalEntity) {
    this.form.patchValue(shareholder);
    this.showAddShareholder = true;
  }

  deleteShareholder(shareholder: LegalEntity) {
    if (confirm('Delete shareholder?')) {
      this.legalEntityDataservice.deleteLegalEntity(shareholder.id).subscribe(data => {
        this.getShareholders();
      });
    }
  }

  addShareholder() {
    this.form.reset();
    this.showAddShareholder = true;
  }

  cancelAddShareholder() {
    this.form.reset();
    this.showAddShareholder = false;
  }

  confirmAddShareholder() {
    this.showAddShareholder = false;
    const formData = this.form.value;
    if (formData) {
      const shareholderType = 'Person';
      const adoxioLegalEntity = this.formDataToModelData(formData, shareholderType);
      let save = this.legalEntityDataservice.createChildLegalEntity(adoxioLegalEntity);
      if (formData.id) {
        save = this.legalEntityDataservice.updateLegalEntity(adoxioLegalEntity, formData.id);
      }
      this.busyObsv = save.subscribe(
        res => {
          this.snackBar.open('Shareholder Details have been saved', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
          this.getShareholders();
        },
        err => {
          this.snackBar.open('Error saving Shareholder Details', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
          this.handleError(err);
        }
      );
    }
  }

  // Open Person shareholder dialog
  // openPersonDialog(shareholder: LegalEntity) {
  //   // set dialogConfig settings
  //   const dialogConfig: any = {
  //     disableClose: true,
  //     autoFocus: true,
  //     maxWidth: '400px',
  //     data: {
  //       businessType: this.businessType,
  //       shareholder: shareholder
  //     }
  //   };

  //   // open dialog, get reference and process returned data from dialog
  //   const dialogRef = this.dialog.open(ShareholderPersonDialogComponent, dialogConfig);
  //   dialogRef.afterClosed().subscribe(
  //     formData => {
  //       if (formData) {
  //         const shareholderType = 'Person';
  //         const adoxioLegalEntity = this.formDataToModelData(formData, shareholderType);
  //         let save = this.legalEntityDataservice.createChildLegalEntity(adoxioLegalEntity);
  //         if (formData.id) {
  //           save = this.legalEntityDataservice.updateLegalEntity(adoxioLegalEntity, formData.id);
  //         }
  //         this.busyObsv = save.subscribe(
  //           res => {
  //             this.snackBar.open('Shareholder Details have been saved', 'Success', { duration: 2500, panelClass: ['green-snackbar'] });
  //             this.getShareholders();
  //           },
  //           err => {
  //             this.snackBar.open('Error saving Shareholder Details', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
  //             this.handleError(err);
  //           }
  //         );
  //       }
  //     }
  //   );
  // }

  // Open Organization shareholder dialog
  // openOrganizationDialog(shareholder) {
  //   // set dialogConfig settings
  //   const dialogConfig = {
  //     disableClose: true,
  //     autoFocus: true,
  //     maxWidth: '400px',
  //     data: {
  //       businessType: this.businessType,
  //       shareholder: shareholder
  //     }
  //   };

  //   // open dialog, get reference and process returned data from dialog
  //   const dialogRef = this.dialog.open(ShareholderOrganizationDialogComponent, dialogConfig);
  //   dialogRef.afterClosed().subscribe(
  //     formData => {
  //       // console.log("ShareholderOrganizationDialog output:", data)
  //       if (formData) {
  //         const shareholderType = 'Organization';
  //         const adoxioLegalEntity = this.formDataToModelData(formData, shareholderType);
  //         let save = this.legalEntityDataservice.createChildLegalEntity(adoxioLegalEntity);
  //         if (formData.id) {
  //           save = this.legalEntityDataservice.updateLegalEntity(adoxioLegalEntity, formData.id);
  //         }
  //         this.busyObsv = save.subscribe(
  //           res => {
  //             this.snackBar.open('Shareholder Details have been saved', 'Success', { duration: 2500, panelClass: ['red-snackbar'] });
  //             this.getShareholders();
  //             this.legalEntityDataservice.getBusinessProfileSummary().subscribe(data => {
  //               this.store.dispatch(new LegalEntitiesActions.SetLegalEntitiesAction(data));
  //             });
  //           },
  //           err => {
  //             // console.log("Error occured");
  //             this.snackBar.open('Error saving Shareholder Details', 'Fail', { duration: 3500, panelClass: ['red-snackbar'] });
  //             this.handleError(err);
  //           }
  //         );
  //       }
  //     }
  //   );
  // }

  private handleError(error: Response | any) {
    let errMsg: string;
    if (error instanceof Response) {
      const body = error || '';
      const err = body || JSON.stringify(body);
      errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
    } else {
      errMsg = error.message ? error.message : error.toString();
    }
    console.error(errMsg);
  }


}

// /***************************************
//  * Shareholder Person Dialog
//  ***************************************/
// @Component({
//   selector: 'app-shareholders-person-dialog',
//   templateUrl: 'edit-shareholders-person-dialog.html',
// })
// export class ShareholderPersonDialogComponent implements OnInit {
//   form: FormGroup;

//   constructor(private fb: FormBuilder,
//     private dialogRef: MatDialogRef<ShareholderPersonDialogComponent>,
//     @Inject(MAT_DIALOG_DATA) public data: any) {
//     this.form = this.fb.group({
//       firstname: ['', Validators.required],
//       lastname: ['', Validators.required],
//       email: ['', Validators.email],
//       commonvotingshares: ['', Validators.required],
//       partnerType: ['', Validators.required],
//       dateIssued: ['']
//     });
//     if (this.data.shareholder) {
//       this.form.patchValue(this.data.shareholder);
//     }

//   }

//   ngOnInit() {
//   }

//   save() {
//     // console.log('shareholderForm', this.shareholderForm.value, this.shareholderForm.valid);
//     if (!this.form.valid) {
//       Object.keys(this.form.controls).forEach(field => {
//         const control = this.form.get(field);
//         control.markAsTouched({ onlySelf: true });
//       });
//     }
//     let formData = this.data.shareholder || {};
//     formData = (<any>Object).assign(formData, this.form.value);
//     this.dialogRef.close(formData);
//   }

//   isFieldError(field: string) {
//     const isError = !this.form.get(field).valid && this.form.get(field).touched;
//     return isError;
//   }

//   close() {
//     this.dialogRef.close();
//   }

// }

// /***************************************
//  * Shareholder Organization Dialog
//  ***************************************/
// @Component({
//   selector: 'app-shareholders-organization-dialog',
//   templateUrl: 'edit-shareholders-organization-dialog.html',
// })
// export class ShareholderOrganizationDialogComponent {
//   form: FormGroup;

//   constructor(private frmbuilder: FormBuilder,
//     private dialogRef: MatDialogRef<ShareholderOrganizationDialogComponent>,
//     @Inject(MAT_DIALOG_DATA) public data: any) {
//     this.form = frmbuilder.group({
//       legalentitytype: ['', Validators.required],
//       partnerType: ['', Validators.required],
//       name: ['', Validators.required],
//       commonvotingshares: ['', Validators.required],
//       commonnonvotingshares: ['', Validators.required],
//       dateIssued: ['']
//     });
//     if (data.shareholder) {
//       this.form.patchValue(data.shareholder);
//     }
//   }

//   save() {
//     // console.log('shareholderForm', this.shareholderForm.value, this.shareholderForm.valid);
//     if (!this.form.valid) {
//       Object.keys(this.form.controls).forEach(field => {
//         const control = this.form.get(field);
//         control.markAsTouched({ onlySelf: true });
//       });
//     }
//     let formData = this.data.shareholder || {};
//     formData = (<any>Object).assign(formData, this.form.value);
//     this.dialogRef.close(formData);
//   }



//   close() {
//     this.dialogRef.close();
//   }

// }

