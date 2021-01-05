
import { filter } from 'rxjs/operators';
import { Component, OnInit, ViewChild, AfterViewInit, ChangeDetectionStrategy, ChangeDetectorRef } from '@angular/core';
import { PolicyDocumentComponent } from '../../policy-document/policy-document.component';
import { MatDialogRef, MatDialog } from '@angular/material';
import { ActivatedRoute } from '@angular/router';
import { of } from 'rxjs';
import { faChevronRight, faIdCard, faQuestion } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-worker-home',
  templateUrl: './worker-home.component.html',
  styleUrls: ['./worker-home.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class WorkerHomeComponent implements OnInit, AfterViewInit {
  faIdCard = faIdCard;
  faQuestion = faQuestion;
  policySlug = 'worker-qualification-training';
  currentSlug = this.policySlug;
  @ViewChild('policyDocs', { static: true }) policyDocs: PolicyDocumentComponent;
  constructor(public dialog: MatDialog, private route: ActivatedRoute, private ref: ChangeDetectorRef) {
    this.route.data.pipe(
      filter(data => !!data && !!data.slug))
      .subscribe((data: any) => {
        this.policySlug = data.slug;
      });
  }

  ngOnInit() {
    this.policyDocs.setSlug(this.policySlug);
  }

  ngAfterViewInit(): void {
    this.ref.detectChanges();
  }


  openRegisterDialog() {
    // set dialogConfig settings
    const dialogConfig: any = {
      autoFocus: true,
      disableClose: false,
      maxWidth: '500px',
      data: {
      }
    };


    // open dialog, get reference and process returned data from dialog
    const dialogRef = this.dialog.open(WorkerHomeDialogComponent, dialogConfig);
    dialogRef.afterClosed().subscribe(
      formData => {
        if (formData === 'login') {
          window.location.href = '/bcservice';
        } else if (formData === 'create-account') {
          window.location.href = 'https://justice.gov.bc.ca/cannabislicensing/policy-document/worker-qualification-training';
        }
      }
    );
  }

}



/***************************************
 * Confirm registration Dialog
 ***************************************/
@Component({
  selector: 'app-register-dialog',
  templateUrl: 'register-dialog.html',
})
export class WorkerHomeDialogComponent {
  faChevronRight = faChevronRight;

  constructor(public dialogRef: MatDialogRef<WorkerHomeDialogComponent>) {
  }

  register() {
  }
}