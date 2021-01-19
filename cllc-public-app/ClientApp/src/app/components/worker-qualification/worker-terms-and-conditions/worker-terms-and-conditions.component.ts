import { Component, OnInit, EventEmitter, Output } from "@angular/core";
import { faDownload } from "@fortawesome/free-solid-svg-icons"

@Component({
  selector: "app-worker-terms-and-conditions",
  templateUrl: "./worker-terms-and-conditions.component.html",
  styleUrls: ["./worker-terms-and-conditions.component.scss"]
})
export class WorkerTermsAndConditionsComponent implements OnInit {
  faDownload = faDownload;
  @Output()
  termsAccepted = new EventEmitter<boolean>();
  window = window;
  _termsAccepted: boolean;
  acceptEmailUse: boolean;

  constructor() {}

  ngOnInit() {
  }
}
