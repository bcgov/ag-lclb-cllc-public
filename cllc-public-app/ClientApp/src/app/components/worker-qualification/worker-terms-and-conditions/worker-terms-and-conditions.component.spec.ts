import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WorkerTermsAndConditionsComponent } from './worker-terms-and-conditions.component';
import { NO_ERRORS_SCHEMA } from '@angular/core';

describe('WorkerTermsAndConditionsComponent', () => {
  let component: WorkerTermsAndConditionsComponent;
  let fixture: ComponentFixture<WorkerTermsAndConditionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WorkerTermsAndConditionsComponent ],
      schemas:  [NO_ERRORS_SCHEMA]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WorkerTermsAndConditionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
