import { Component, OnInit } from '@angular/core';
import { Mlog } from './Mlog';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-mlogin',
  templateUrl: './mlogin.component.html',
  styleUrls: ['./mlogin.component.css']
})
export class MloginComponent implements OnInit {
  [x: string]: any;

  constructor(private http:HttpClient,private router:Router) { }

  ngOnInit() {
  }

  mlogin(form){
    const data=new Mlog(form.value.email,form.value.pass);
      
    const c = data;
    
    const req=this.http.post('http://localhost:8091/api/mlogin',c).toPromise()
    .then((data:any)=>{
      console.log(data);
      localStorage.setItem('token',data.toString());
      this.router.navigate(['dashm']);
    },
    error=>{}
    )
  }
  movetosignup(){
    this.router.navigate(['Msignup'],{relativeTo:this._activatedRoute})
  }

}
