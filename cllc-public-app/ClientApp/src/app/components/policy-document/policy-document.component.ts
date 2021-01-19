
import { Component, OnInit, Input, Output, EventEmitter, ChangeDetectorRef } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { PolicyDocument } from "@models/policy-document.model";
import { PolicyDocumentDataService } from "@services/policy-document-data.service";
import { Title, DomSanitizer, SafeHtml } from "@angular/platform-browser";

@Component({
  selector: "app-policy-document",
  templateUrl: "./policy-document.component.html",
  styleUrls: ["./policy-document.component.scss"]
})
/** PolicyDocument component*/
export class PolicyDocumentComponent implements OnInit {
  policyDocument: PolicyDocument;
  title: string;
  category: string;
  body: SafeHtml;
  @Input()
  fullWidth: false;
  @Output()
  slugChange = new EventEmitter<string>();
  dataLoaded: boolean;
  busy: Promise<any>;

  /** PolicyDocument ctor */
  constructor(private policyDocumentDataService: PolicyDocumentDataService,
    private titleService: Title,
    private route: ActivatedRoute,
    private sanitizer: DomSanitizer,
    private cd: ChangeDetectorRef
  ) {

  }

  ngOnInit(): void {
    this.route.paramMap
      .subscribe((data) => {
        const slug = data.get("slug");
        if (slug) {
          this.setSlug(slug);
        }
      });
  }

  setSlug(slug) {
    this.slugChange.emit(slug);
    this.busy = this.policyDocumentDataService.getPolicyDocument(slug)
      .toPromise()
      .then((data) => {
        this.dataLoaded = true;
        this.policyDocument = data;
        this.title = this.policyDocument.title;
        this.body = this.sanitizer.bypassSecurityTrustHtml(this.policyDocument.body);
        this.category = this.policyDocument.category;
        this.titleService.setTitle(`${this.title} - Liquor and Cannabis Regulation Branch`);
        this.cd.detectChanges();
      }).catch(error => this.dataLoaded = true);
  }

}
