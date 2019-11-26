import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SkillsService } from 'src/app/Services/skills.service';
import { Skills } from 'src/app/Models/skills';

@Component({
  selector: 'app-skillslist',
  templateUrl: './skillslist.component.html',
  styleUrls: ['./skillslist.component.css']
})
export class SkillslistComponent implements OnInit {
list:Skills[];
item:Skills;
  constructor(private router:Router,private _service:SkillsService) { 
    this.item=new Skills();
    this._service.GetAll().subscribe(k=>this.list=k
    );

  }

  ngOnInit() {
    // this._service.GetAll().subscribe(k=>this.list=k);
   
  }

}
