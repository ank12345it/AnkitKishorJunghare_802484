import { Component, OnInit } from '@angular/core';
import {User} from '../user1';
import { Ulog } from './ulog';
import { HttpClient } from '@angular/common/http';
import {Router} from '@angular/router';
import { LoginSharedService } from 'src/app/Services/login-shared.service';


@Component({
  selector: 'app-ulogin',
  templateUrl: './ulogin.component.html',
  styleUrls: ['./ulogin.component.css']
})
export class UloginComponent implements OnInit {
  [x: string]: any;
  email;
  pwd;
  msg:string;
  
  
 userList:User[]=[];
  
  constructor(private http:HttpClient,private router:Router,private _service:LoginSharedService) { }
  ngOnInit() {
  }
  public Login()
  {
    this._service.Login(this.email,this.pwd).subscribe(data=>{
      console.log(data)
      if(data.message=='User')
      {
        console.log("HAHAHAHHAHAHA");
        
        console.log(data.token);
        console.log(data.message);
        localStorage.setItem('token',data.token);
        console.log(data.user_id);
        localStorage.setItem('user_id',data.user_id);
      // this.router.navigate(['dashm']);
        this.router.navigate(['dashb'],{relativeTo:this._activatedRoute});
      }
      else if(data.message=='Mentor')
      {
        localStorage.setItem('token',data.token);
      // this.router.navigate(['dashm']);
        this.router.navigate(['dashm'],{relativeTo:this._activatedRoute});
      }
      else if(data.message=='Admin')
      {
        localStorage.setItem('token',data.token);
        this.router.navigate(['dasha'],{relativeTo:this._activatedRoute});
        console.log(data.token);
     
      }

    },
    err=>{
       console.log("subscribe err");
    });
  }
    
  

// // // // //  login(form){
// // // // //   const data=new Ulog(form.value.email,form.value.pass);
    
// // // // //   const c = data;
  
// // // // //   const req=this.http.post('http://localhost:8091/api/ulogin',c).toPromise()
// // // // //   .then((data:any)=>{
// // // // //     console.log(data);
   
// // // // //     localStorage.setItem('token',data.toString());
// // // // //     this.router.navigate(['dashb']);
    
// // // // //   },
// // // // //   error=>{}
// // // // //   )
// // // //  }


 
  
}
