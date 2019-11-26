import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SkillsaddComponent } from './skillsadd.component';

describe('SkillsaddComponent', () => {
  let component: SkillsaddComponent;
  let fixture: ComponentFixture<SkillsaddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SkillsaddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SkillsaddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
