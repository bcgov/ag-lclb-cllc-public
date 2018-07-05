import { Component, OnInit, Input, Inject } from '@angular/core';
import { MatPaginator, MatTableDataSource, MatSort, MatDialog, MatDialogConfig, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material';
import { AdoxioLegalEntity } from '../models/adoxio-legalentities.model';
import { DynamicsAccount } from '../models/dynamics-account.model';
import { FormBuilder, FormGroup, FormControl, Validators, NgForm } from '@angular/forms';
import { AdoxioLegalEntityDataService } from "../services/adoxio-legal-entity-data.service";
import { MatSnackBar } from '@angular/material';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-directors-and-officers',
  templateUrl: './directors-and-officers.component.html',
  styleUrls: ['./directors-and-officers.component.scss']
})
export class DirectorsAndOfficersComponent implements OnInit {

  @Input() accountId: string;
  @Input() parentLegalEntityId: string;
  @Input() businessType: string;

  adoxioLegalEntityList: AdoxioLegalEntity[] = [];
  dataSource = new MatTableDataSource<AdoxioLegalEntity>();
  displayedColumns = ['name', 'email', 'position', 'dateofappointment', 'edit', 'delete'];
  busy: Promise<any>;
  busyObsv: Subscription;

  constructor(private legalEntityDataservice: AdoxioLegalEntityDataService, public dialog: MatDialog,
    public snackBar: MatSnackBar) { }

  ngOnInit() {
    this.getDirectorsAndOfficers();
  }

  getDirectorsAndOfficers() {
    this.busyObsv = this.legalEntityDataservice.getLegalEntitiesbyPosition(this.parentLegalEntityId, "directors-officers-management")
      .subscribe((result) => {
        let data: AdoxioLegalEntity[] = result.json();
        let positionList: string[] = [];
        data.forEach(d => {
          if (d.isDirector) {
            positionList.push("Director");
          }
          if (d.isOfficer) {
            positionList.push("Officer");
          }
          if (d.isSeniorManagement) {
            positionList.push("Senior Manager")
          }
          d.position = positionList.join(', ');
        })
        this.dataSource.data = data;
      });
  }

  formDataToModelData(formData: any): AdoxioLegalEntity {
    let adoxioLegalEntity: AdoxioLegalEntity = new AdoxioLegalEntity();
    adoxioLegalEntity.isShareholder = false;
    adoxioLegalEntity.parentLegalEntityId = this.parentLegalEntityId;
    adoxioLegalEntity.id = formData.id;
    adoxioLegalEntity.isindividual = true;
    adoxioLegalEntity.firstname = formData.firstname;
    adoxioLegalEntity.lastname = formData.lastname;
    adoxioLegalEntity.name = formData.firstname + " " + formData.lastname;
    adoxioLegalEntity.email = formData.email;
    adoxioLegalEntity.dateofappointment = formData.dateofappointment; //adoxio_dateofappointment
    // adoxioLegalEntity.legalentitytype = "PrivateCorporation";
    adoxioLegalEntity.isOfficer = formData.isOfficer;
    adoxioLegalEntity.isDirector = formData.isDirector;
    adoxioLegalEntity.isSeniorManagement = formData.isSeniorManagement;
    // the accountId is received as parameter from the business profile
    if (this.accountId) {
      adoxioLegalEntity.account = new DynamicsAccount();
      adoxioLegalEntity.account.id = this.accountId;
    }
    //adoxioLegalEntity.relatedentities = [];
    return adoxioLegalEntity;
  }

  // Open Person shareholder dialog
  openPersonDialog(person: AdoxioLegalEntity) {
    // set dialogConfig settings
    const dialogConfig = {
      disableClose: true,
      autoFocus: true,
      data: {
        person: person
      }
    }

    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(DirectorAndOfficerPersonDialog, dialogConfig);
    dialogRef.afterClosed().subscribe(
      formData => {
        if (formData) {
          let adoxioLegalEntity = this.formDataToModelData(formData);
          let save = this.legalEntityDataservice.createChildLegalEntity(adoxioLegalEntity);
          if (formData.id) {
            save = this.legalEntityDataservice.updateLegalEntity(adoxioLegalEntity, formData.id);
          }
          this.busyObsv = save.subscribe(
            res => {
              this.snackBar.open('Director / Officer Details have been saved', "Success", { duration: 2500, extraClasses: ['red-snackbar'] });
              this.getDirectorsAndOfficers();
            },
            err => {
              this.snackBar.open('Error saving Director / Officer Details', "Fail", { duration: 3500, extraClasses: ['red-snackbar'] });
              this.handleError(err);
            });
        }
      }
    );

  }

  deleteIndividual(person: AdoxioLegalEntity) {
    if (confirm('Delete person?')) {
      this.legalEntityDataservice.deleteLegalEntity(person.id).subscribe(data => {
        this.getDirectorsAndOfficers();
      })
    }
  }

  private handleError(error: Response | any) {
    let errMsg: string;
    if (error instanceof Response) {
      const body = error.json() || "";
      const err = body || JSON.stringify(body);
      errMsg = `${error.status} - ${error.statusText || ""} ${err}`;
    } else {
      errMsg = error.message ? error.message : error.toString();
    }
    console.error(errMsg);
  }

}

/***************************************
 * Director and Officer Person Dialog
 ***************************************/
@Component({
  selector: 'director-and-officer-person-dialog',
  templateUrl: 'director-and-officer-person-dialog.html',
})
export class DirectorAndOfficerPersonDialog {
  directorOfficerForm: FormGroup;

  constructor(private fb: FormBuilder, private dialogRef: MatDialogRef<DirectorAndOfficerPersonDialog>, @Inject(MAT_DIALOG_DATA) public data: any) {
    this.directorOfficerForm = fb.group({
      isDirector: [false],
      isOfficer: [false],
      isSeniorManagement: [false],
      firstname: ['', Validators.required],
      lastname: ['', Validators.required],
      email: ['', Validators.email],
      dateofappointment: ['', Validators.required]
    }, { validator: this.dateLessThanToday('dateofappointment') }
    );

    if (data && data.person) {
      this.directorOfficerForm.patchValue(data.person);
    }
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
    }
  }

  save() {
    if (this.directorOfficerForm.valid) {
      let formData = this.data.person || {};
      formData = (<any>Object).assign(formData, this.directorOfficerForm.value);
      this.dialogRef.close(formData);
    } else {
      Object.keys(this.directorOfficerForm.controls).forEach(field => {
        const control = this.directorOfficerForm.get(field);
        control.markAsTouched({ onlySelf: true });
      });
    }
  }

  close() {
    this.dialogRef.close();
  }

  isFieldError(field: string) {
    const isError = !this.directorOfficerForm.get(field).valid && this.directorOfficerForm.get(field).touched;
    return isError;
  }

}
