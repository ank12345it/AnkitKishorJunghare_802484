import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MentorSharedServiceService } from 'src/app/Services/mentor-shared-service.service';
import { Mentor } from 'src/app/Models/mentor';

@Component({
  selector: 'app-mentorlist',
  templateUrl: './mentorlist.component.html',
  styleUrls: ['./mentorlist.component.css']
})
export class MentorlistComponent implements OnInit {
  list:Mentor[];
  status:boolean[];
  msg:string;
  delete:boolean[];
  constructor(private router:Router,private _service:MentorSharedServiceService) {
   
    // this.list=[];
    this._service.GetAll().subscribe(k=>{this.list=k
      console.log(this.list);
    var l=this.list.length;
    console.log(l);
    this.status=new Array(l);
   
      this.delete=new Array(l);
    this.delete.forEach(element => {
      element=false;
      
    });
    var i=0;
    this.list.forEach(element => {
      this.status[i++]=element["mentor_active"];
    });
    console.log(this.status);
    });
    
    
    
    }
  

  ngOnInit() {
    // this.list=[];
    //   this._service.GetAll().subscribe(k=>{this.list=k
    //     console.log(this.list);
    //   var l=this.list.length;
    //   console.log(l);
    //   this.status=new Array(l);
     
    //     this.delete=new Array(l);
    //   this.delete.forEach(element => {
    //     element=false;
        
    //   });
    //   var i=0;
    //   this.list.forEach(element => {
    //     this.status[i++]=element["mentor_active"];
    //   });
    //   console.log(this.status);
    //   });
      
      
      // this.delete=new Array(l);
      // this.delete.forEach(element => {
      //   element=false;
        
      // });
      // console.log(this.delete);
      //console.log(this.status);
     
  }

  logout()
  {
   localStorage.removeItem('token');
   this.router.navigate(['Userlog']);    
  }
//   public BlockUser(i:number)
//   {
//     this._service.Block(this.list[i]["user_Id"]).subscribe(k=>this.msg=k);
//  console.log(this.msg);
//     console.log(this.list[i]["user_Id"]);
//     if(this.status[i]==true)
//      this.status[i]=false;
//      else
//      this.status[i]=true;
//   }

public DeleteMentor(i:number)
{
  console.log((this.list[i])["mentor_Id"]);
  console.log(i);
  this._service.Delete((this.list[i])["mentor_Id"]).subscribe(k=>this.msg=k);
   this.delete[i]=true;
   // console.log(this.msg); 
     
}
  public checkBlock(i:number){
    
    if((this.list[i])["mentor_active"]==true){
      this.status[i]=true;
      return 1;
    }
    else{
      this.status[i]=false;
      return 0;
    }
  }
  public BlockMentor(i:number)
  {
    this._service.Block(this.list[i]["mentor_Id"]).subscribe(k=>this.msg=k);
 console.log(this.msg);
    console.log(this.list[i]["mentor_Id"]);
    if(this.status[i]==true)
     this.status[i]=false;
     else
     this.status[i]=true;
  }
}
