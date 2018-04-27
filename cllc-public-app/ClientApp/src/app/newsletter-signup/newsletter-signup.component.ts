import { Component, Input, OnInit, ViewContainerRef } from '@angular/core';
import { NewsletterDataService } from "../services/newsletter-data.service"
import { ToastsManager } from 'ng2-toastr/ng2-toastr';
import { FormGroup, FormControl, FormBuilder, Validators, EmailValidator, FormGroupDirective, NgForm } from '@angular/forms';
import { ErrorStateMatcher } from '@angular/material/core';

@Component({
    selector: 'app-newsletter-signup',
    templateUrl: './newsletter-signup.component.html',
    styleUrls: ['./newsletter-signup.component.scss']
})
/** newsletter-signup component*/
export class NewsletterSignupComponent implements OnInit  {
  public newsletterSignupForm: any;
  @Input('slug') slug: string;
  public description: string;
  public title: string;
  public email: string;
  public signupSuccess = false;

  emailFormControl = new FormControl('', [
    Validators.required,
    Validators.email,
  ]);

  matcher = new MyErrorStateMatcher();

    /** newsletter-signup ctor */
  constructor(private newsletterDataService: NewsletterDataService, public toastr: ToastsManager, vcr: ViewContainerRef) {
    this.toastr.setRootViewContainerRef(vcr);    
  }

  ngOnInit(): void {
    
      if (this.slug != null) {
        this.newsletterDataService.getNewsletter(this.slug)
          .then((newsletter) => {
            this.description = newsletter.description;
            this.title = newsletter.title;            
          });
      }
    }

  signup() {    
      // subscribe to the newsletter.
      this.newsletterDataService.signup(this.slug, this.email).then((results) => {
        this.toastr.success('Thanks for signing up!', 'Success!');
        this.signupSuccess = true;
      });
    }
}

/** Error when invalid control is dirty, touched, or submitted. */
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.touched || isSubmitted)); /*control.dirty*/
  }
}
