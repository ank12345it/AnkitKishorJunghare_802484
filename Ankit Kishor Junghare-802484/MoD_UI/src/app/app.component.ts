import { Component, OnInit } from '@angular/core';
import { RouterModule, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'test';
  constructor(private router:Router){}
  ngOnInit(){}
  checkTok(){
    var one='';
    one=localStorage.getItem('token');
     if(one==null){
       return 0;
     }
    else
       return 1;
     }
     logout(){
      localStorage.removeItem('token');
      this.router.navigate(['Userlog']);
    }
  }

