import { Component, OnInit, Input, Output, EventEmitter, ViewChildren, QueryList } from '@angular/core';
import { LicenseeChangeLog } from '@models/licensee-change-log.model';
import { Account } from '@models/account.model';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { AssociateListComponent } from '../associate-list/associate-list.component';
import { forkJoin, of } from 'rxjs';
import { mergeMap } from 'rxjs/operators';

@Component({
  selector: 'app-org-structure',
  templateUrl: './org-structure.component.html',
  styleUrls: [ './org-structure.component.scss' ]
})
export class OrgStructureComponent implements OnInit {
  private _node: LicenseeChangeLog;
  @Input() set node(value: LicenseeChangeLog) {
    this._node = value;
    if (this.form) {
      this.form.patchValue(value);
    }
  }

  get node(): LicenseeChangeLog {
    return this._node;
  }

  @Input() account: Account;
  @Input() licencesOnFile: boolean;
  @Output() deletedChanges: EventEmitter<LicenseeChangeLog> = new EventEmitter<LicenseeChangeLog>();

  @ViewChildren('associateList') associateList: QueryList<AssociateListComponent>;

  Account = Account;
  form: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    let numberOfMembers: number = null;
    let annualMembershipFee: number = null;
    let totalShares: number = null;
    if (this.node) {
      numberOfMembers = this.node.numberOfMembers;
      annualMembershipFee = this.node.annualMembershipFee;
      totalShares = this.node.totalSharesOld;
    }


    this.form = this.fb.group({
      numberOfMembers: [numberOfMembers, [Validators.required]],
      annualMembershipFee: [annualMembershipFee, [Validators.required]],
      totalShares: [totalShares, [Validators.required]]
    });

    this.form.valueChanges
      .subscribe(value => {
        if (this.node) {
          this.node.numberOfMembers = value.numberOfMembers;
          this.node.annualMembershipFee = value.annualMembershipFee;
          this.node.totalSharesNew = value.totalShares;
        }
      });

  }

  asLicenseeChangeLog(val): LicenseeChangeLog { return val; }

  updateNumberOfFiles(numberOfFiles: number, docType: string) {
    if (!this.node.fileUploads) {
      this.node.fileUploads = {};
    }
    this.node.fileUploads[docType] = numberOfFiles;
  }

  updateChildren(children: LicenseeChangeLog[], changeType: string) {
   
    children = children || [];
    this.node.children = this.node.children || [];
    if (changeType === 'Leadership') {      
        this.node.children = [...children,
        ...this.node.individualShareholderChildren,
        ...this.node.businessShareholderChildren];          
    } else if (changeType === 'IndividualShareholder') {
      this.node.children = [...children,
      ...this.node.keyPersonnelChildren,
      ...this.node.businessShareholderChildren
      ];
    } else if (changeType === 'BusinessShareholder') {
      this.node.children = [...children,
      ...this.node.individualShareholderChildren,
      ...this.node.keyPersonnelChildren
      ];
    }
    
  }


    /**
   * saves all open associate list items
   * returns an Observable<boolean>. False means there is validation errors
   */
  saveAll() {
    const saveResults = [];

    // save all open associate list
    this.associateList.forEach(org => {
      saveResults.push(org.saveAll());
    });

    if (saveResults.length > 0) {
      return forkJoin(...saveResults)
        .pipe(mergeMap(results => {
          return of(results.indexOf(false) === -1);
        }));
    } else {
      // return true if there is nothing to save
      return of(true);
    }
  }
}
