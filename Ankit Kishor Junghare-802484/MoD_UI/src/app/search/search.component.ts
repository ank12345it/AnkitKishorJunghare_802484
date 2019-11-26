import { Component, OnInit } from '@angular/core';
import { Mentor } from '../Models/mentor';
import { HttpClient } from '@angular/common/http';
import { SearchService } from '../Services/search.service';
import { Training } from '../Models/training';
import { TrainingService } from '../Services/training.service';
import { SkillsService } from '../Services/skills.service';
import { Skills } from '../Models/skills';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  skill;
  from_time;
  to_time;
  list:Mentor[];
  training:Training;
  list2:Skills[];
  msg:string;
  training2:Training[];
  fees:number;
num1=0;

  
  constructor(private http:HttpClient,private _service:SearchService,private _service2:SkillsService,private _service3:TrainingService) { 
    this.training=new Training();

    
  }

  ngOnInit() {

  }
  public Search()
  {
    this._service.Search(this.skill,this.from_time,this.to_time).subscribe(k=>this.list=k)
     this.num1=0;
  }
  
public Subscribe(data:Mentor)
{
  
  // this.training.mentor_Id=data.mentor_Id;
  // console.log(data);
  this.training.user_Id=JSON.parse(localStorage.getItem("user_id"));
  this.training.mentor_Id=data.mentor_Id;
  //  if(data.mentor_PrimarySkill=="Java")
  //  {
  //    this.training.skill_Id=9;
  //  }
  //  else if(data.mentor_PrimarySkill==".NET")
  //  {
  //    this.training.skill_Id=10;
  //  }
  //  else if(data.mentor_PrimarySkill=="MachineLearning")
  //  {
  //    this.training.skill_Id=11;
  //  }
  //  else if(data.mentor_PrimarySkill=="Python")
  //  {
  //    this.training.skill_Id=12;
  //  }
  //  else 
  //  {
  //    this.training.skill_Id=13
  //  }
  this._service2.GetAll().subscribe(k=>{this.list2=k
    // console.log(this.list2);
    
    this.list2.forEach(element => {
      
      if(data.mentor_PrimarySkill==element["skill_Name"])
      {

        this.training.skill_Id=element["skill_Id"];
        this.fees=element["skill_Fee"];
        this.training.endTime=new Date();
        this.training.endTime.setDate(this.training.endTime.getDate()+element["skill_Duration"]);
        // console.log(this.training.endTime);
      }
       
    
    });
    
    
  });
  // console.log(this.training);
   this.training.mentor_From_TimeSlot=data.mentor_From_TimeSlot;
  //  console.log(data.mentor_From_TimeSlot);
  //  console.log(data.mentor_To_Timeslot);
   this.training.mentor_To_TimeSlot=data.mentor_To_TimeSlot;

   this.training.startTime=new Date();
   
  this.training.training_Id;
   this.training.training_Status="ongoing";
  //  console.log(this.training.endTime);
   console.log(this.training);
   

   this._service3.Assign(this.training);
   console.log(this.msg);
 
  // console.log(this.training);
  // console.log(this.list);
  this.num1=1;
  
}

// public Subscribe()
// {
//   this._service3.GetAll().subscribe(k=>{this.training2=k
//   console.log(this.training2);
//   }
//     );
//   // console.log(this.training2);
// }
public add()
{
  this._service3.Add().subscribe(k=>this.msg=k);
  console.log(this.msg);
}
}

