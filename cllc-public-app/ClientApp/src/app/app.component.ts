import { Component, OnInit, Renderer2 } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { BreadcrumbComponent } from './breadcrumb/breadcrumb.component';
import { InsertService } from './insert/insert.service';
import { UserDataService } from './services/user-data.service';
import { User } from './models/user.model';
import { isDevMode } from '@angular/core';
import { AdoxioLegalEntityDataService } from './services/adoxio-legal-entity-data.service';
import { AdoxioLegalEntity } from './models/adoxio-legalentities.model';
import { Store } from '@ngrx/store';
import { AppState } from './app-state/models/app-state';
import { ClientConfigDataService } from './services/client-config.service';
import { Observable } from '../../node_modules/rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  businessProfiles: AdoxioLegalEntity[];
  title = '';
  previousUrl: string;
  public currentUser: User;
  public isNewUser: boolean;
  public isDevMode: boolean;
  isAssociate = false;
  showLogin: boolean;
  isLiteVersion: boolean;

  constructor(
    private renderer: Renderer2,
    private router: Router,
    private userDataService: UserDataService,
    private store: Store<AppState>,
    private clientConfigDataService: ClientConfigDataService,
    private adoxioLegalEntityDataService: AdoxioLegalEntityDataService
  ) {
    this.isDevMode = isDevMode();
    this.router.events.subscribe((event) => {
      if (event instanceof NavigationEnd) {
        let prevSlug = this.previousUrl;
        let nextSlug = event.url.slice(1);
        if (!nextSlug) nextSlug = 'home';
        if (prevSlug) {
          this.renderer.removeClass(document.body, 'ctx-' + prevSlug);
        }
        if (nextSlug) {
          this.renderer.addClass(document.body, 'ctx-' + nextSlug);
        }
        this.previousUrl = nextSlug;
      }
    });

    Observable.interval(20000).subscribe(_ => {
      clientConfigDataService.getConfig().subscribe(data => {
        this.showLogin = data.showLogin;
        this.isLiteVersion = data.isLiteVersion;
      });
    });
  }

  ngOnInit(): void {
    this.userDataService.getCurrentUser()
      .subscribe((data: User) => {
        this.currentUser = data;
        this.isNewUser = this.currentUser.isNewUser;
        this.isAssociate = (this.currentUser.businessname == null);
        if (!this.isAssociate) {
          this.adoxioLegalEntityDataService.getBusinessProfileSummary().subscribe(
            res => {
              this.businessProfiles = res;
            });
        }
      });

    this.store.select(state => state.legalEntitiesState)
      .filter(state => !!state)
      .subscribe(state => {
        this.businessProfiles = state.legalEntities;
      });

  }

  isIE10orLower() {
    let result, jscriptVersion;
    result = false;

    jscriptVersion = new Function('/*@cc_on return @_jscript_version; @*/')();

    if (jscriptVersion !== undefined) {
      result = true;
    }
    return result;
  }
}
