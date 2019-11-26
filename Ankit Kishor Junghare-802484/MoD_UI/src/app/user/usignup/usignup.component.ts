import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Upass } from './Upass';
import { CommonService } from 'src/app/common.service';
import { ReturnStatement } from '@angular/compiler';
import { UserSharedService } from 'src/app/Services/user-shared.service';
import { User } from 'src/app/Models/user';


@Component({
  selector: 'app-usignup',
  templateUrl: './usignup.component.html',
  styleUrls: ['./usignup.component.css']
})
export class UsignupComponent implements OnInit {
item:User;
list:User[];
msg:string;
  constructor(private http:HttpClient,private commonService:CommonService,private _service:UserSharedService ) {  
    this.item=new User();
    this._service.GetAll().subscribe(k=>this.list=k)

  }
  first;second;
  james="";
  public response:any=[];
  ngOnInit() {
  }
  public Add()
  {
    this.item.user_Active=true;
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
 

}
