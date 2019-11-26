import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/Models/user';
import { UserSharedService } from 'src/app/Services/user-shared.service';


@Component({
  selector: 'app-admindash',
  templateUrl: './admindash.component.html',
  styleUrls: ['./admindash.component.css']
})
export class AdmindashComponent implements OnInit {
adminname='';
num:number;
list:User[];
num1:number=0;
num2:number=0;
msg:string;
delete:boolean[];
status:boolean[];



  constructor(private router:Router,private _service:UserSharedService) { 
    this.adminname=localStorage.getItem('token');
  
    // this.list=[];
    // this._service.GetAll().subscribe(k=>this.list=k);
    // console.log(this.list);
    // var l=this.list.length;
    // console.log(l);
    // this.status=new Array(l);
    // //console.log(this.status);
    // var i=0;
    // this.list.forEach(element => {
    //   this.status[i++]=element["user_active"];
    // });
  }

  ngOnInit() {
    if(localStorage.getItem('token')==null)
    {
      this.router.navigate(['Userlog']);   
    }
    
  }
//   checkBlock(id)
// {
//   this._service.BlockStatus(id).subscribe(k=>this.num=k);
//   if(k)
// }
// checkClick1()
// {
//   this.num=1;
//   return this.num;
  
// }

  logout()
  {
   localStorage.removeItem('token');
   this.router.navigate(['Userlog']);    
  }

  public  GetUser()
  {
    this.list=[];
   
    this._service.GetAll().subscribe(k=>{this.list=k
      console.log(this.list);
      var l=this.list.length;
      console.log(l);
      this.status=new Array(l);
      this.delete=new Array(l);
      this.delete.forEach(element => {
        element=false;
        
      });
      console.log(this.delete);
      //console.log(this.status);
      var i=0;
      this.list.forEach(element => {
        this.status[i++]=element["user_active"];
      });});
    
    
    console.log(this.status);
    this.num1=1;

  //   if(this.list["user_Active"]==true){
  //     return 1;
  //   }
  //   else 
  //   return 0;
   }
  //  public changeText(){
  //    if(this.status=="Block")
  //       this.status="UnBlock";
  //     else
  //     this.status="Block";
  //  }

   public BlockUser(i:number)
   {
     this._service.Block(this.list[i]["user_Id"]).subscribe(k=>this.msg=k);
  console.log(this.msg);
     console.log(this.list[i]["user_Id"]);
     if(this.status[i]==true)
      this.status[i]=false;
      else
      this.status[i]=true;
   }

   public DeleteUser(i:number)
   {
     console.log((this.list[i])["user_Id"]);
     console.log(i);
     this._service.Delete((this.list[i])["user_Id"]).subscribe(k=>this.msg=k);
      this.delete[i]=true;
      // console.log(this.msg); 
        
   }
   public checkBlock(i:number){
    
     if((this.list[i])["user_active"]==true){
       this.status[i]=true;
       return 1;
     }
     else{
       this.status[i]=false;
       return 0;
     }
   }

}
