import { Component, Input, OnInit, ViewEncapsulation } from '@angular/core';
import { Account } from "@models/account.model";
import { User } from '@models/user.model';

@Component({
  selector: 'app-police-nav',
  templateUrl: './police-nav.component.html',
  styleUrls: ['./police-nav.component.scss']
})
export class PoliceNavComponent implements OnInit {
  @Input() currentUser: User;
  @Input() account: Account;

  constructor() { }
  ngOnInit() { }
}
