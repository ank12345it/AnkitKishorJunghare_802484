import { Component, OnInit } from '@angular/core';
import { CommonService } from 'src/app/common.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-mentordash',
  templateUrl: './mentordash.component.html',
  styleUrls: ['./mentordash.component.css']
})
export class MentordashComponent implements OnInit {
mentorname='';
  constructor(private router:Router) { 
    this.mentorname=localStorage.getItem('token');
  }

  ngOnInit() {
    if(localStorage.getItem('token')==null)
    {
      this.router.navigate(['Userlog']);   
    }
  }
 

  logout(){
    localStorage.removeItem('token');
    this.router.navigate(['Userlog']);
  }

}
