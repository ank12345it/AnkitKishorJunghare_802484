import { Component, OnInit } from '@angular/core';
import { timeout } from 'q';
import { Mpass } from './mpass';
import { HttpClient } from '@angular/common/http';
import { Mentor } from 'src/app/Models/mentor';
import { MentorSharedServiceService } from 'src/app/Services/mentor-shared-service.service';

@Component({
  selector: 'app-msignup',
  templateUrl: './msignup.component.html',
  styleUrls: ['./msignup.component.css']
})
export class MsignupComponent implements OnInit {
 first;second;
 item:Mentor;
 list:Mentor[];
 msg:string;
  constructor(private http:HttpClient,private _service:MentorSharedServiceService) { 
    this.item=new Mentor();
    this._service.GetAll().subscribe(k=>this.list=k)
  }
  ngOnInit() {
  }
  public Add()
  {
    this.item.mentor_Active=true;
   this._service.Add(this.item).subscribe(k=>this.msg=k)
  }
  check(){
    //console.log(first,second);
     if(this.first!=this.second)
     {
         return false;
     }
     else{
       return true;
     }
 }
  
//  mregister(form){
//    console.log(form.value.email,form.value.contact,form.value.pass,form.value.c_pass,form.value.tech,form.value.exp,form.value.sttime,form.value.entime );
//   const data=new Mpass(form.value.email,form.value.contact,form.value.pass,form.value.c_pass,form.value.tech,form.value.exp,form.value.sttime,form.value.entime); 
//   const c = data;
    
//   const req=this.http.post('http://localhost:8091/api/mentor',c).toPromise()
//   .then((data:any)=>{
//     console.log(data);
//   })
// }
}
