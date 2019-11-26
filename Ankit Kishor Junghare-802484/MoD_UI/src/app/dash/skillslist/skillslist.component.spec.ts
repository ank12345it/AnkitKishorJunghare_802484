import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SkillslistComponent } from './skillslist.component';

describe('SkillslistComponent', () => {
  let component: SkillslistComponent;
  let fixture: ComponentFixture<SkillslistComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SkillslistComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SkillslistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
