import { ComponentFixture, TestBed, waitForAsync } from "@angular/core/testing";

import { MapComponent } from "./map.component";
import { NO_ERRORS_SCHEMA } from "@angular/core";
import { HttpClientTestingModule } from "@angular/common/http/testing";
import { FormBuilder } from "@angular/forms";

describe("MapComponent",
  () => {
    let component: MapComponent;
    let fixture: ComponentFixture<MapComponent>;

    beforeEach(waitForAsync(() => {
      TestBed.configureTestingModule({
          imports: [HttpClientTestingModule],
          declarations: [MapComponent],
          providers: [FormBuilder],
          schemas: [NO_ERRORS_SCHEMA]
        })
        .compileComponents();
    }));

    beforeEach(() => {
      fixture = TestBed.createComponent(MapComponent);
      component = fixture.componentInstance;
      fixture.detectChanges();
    });

    it("should create",
      () => {
        expect(component).toBeTruthy();
      });
  });
