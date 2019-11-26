import { Component, OnInit } from '@angular/core';
import { Skills } from 'src/app/Models/skills';
import { Router } from '@angular/router';
import { SkillsService } from 'src/app/Services/skills.service';

@Component({
  selector: 'app-skillsadd',
  templateUrl: './skillsadd.component.html',
  styleUrls: ['./skillsadd.component.css']
})
export class SkillsaddComponent implements OnInit {
list:Skills;
msg:string;
  constructor(private router:Router,private _service:SkillsService) {
    this.list= new Skills();
   }

  ngOnInit() {
    
  }
Add()
{
  this._service.Add(this.list).subscribe(k=>this.msg=k);
 
}


}
