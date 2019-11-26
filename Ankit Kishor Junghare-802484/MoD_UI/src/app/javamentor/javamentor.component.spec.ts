import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JavamentorComponent } from './javamentor.component';

describe('JavamentorComponent', () => {
  let component: JavamentorComponent;
  let fixture: ComponentFixture<JavamentorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JavamentorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JavamentorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
