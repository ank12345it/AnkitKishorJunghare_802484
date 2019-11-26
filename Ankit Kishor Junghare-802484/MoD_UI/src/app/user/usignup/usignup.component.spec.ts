import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsignupComponent } from './usignup.component';

describe('UsignupComponent', () => {
  let component: UsignupComponent;
  let fixture: ComponentFixture<UsignupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsignupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsignupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
