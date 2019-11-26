import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdmindashComponent } from './admindash/admindash.component';
import { MentorlistComponent } from './mentorlist/mentorlist.component';
import { RouterModule } from '@angular/router';
import { UserlistComponent } from './userlist/userlist.component';
import { SkillslistComponent } from './skillslist/skillslist.component';
import { SkillsaddComponent } from './skillsadd/skillsadd.component';
import {FormsModule} from '@angular/forms';


@NgModule({
  declarations: [AdmindashComponent, MentorlistComponent, UserlistComponent, SkillslistComponent, SkillsaddComponent],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule.forChild([
      {path:'dasha',component:AdmindashComponent,children:[{path:'listmentor',component:MentorlistComponent},{path:'listuser',component:UserlistComponent},
    {path:'listskills',component:SkillslistComponent},{path:'addskills',component:SkillsaddComponent}]}
    ])
  ]
})
export class DashModule { }
