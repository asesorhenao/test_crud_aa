import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { InscrptionsComponent } from './inscrptions.component';

describe('InscrptionsComponent', () => {
  let component: InscrptionsComponent;
  let fixture: ComponentFixture<InscrptionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ InscrptionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InscrptionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
