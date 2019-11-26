import { Component, OnInit } from '@angular/core';
import { CommonService } from 'src/app/common.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-userdash',
  templateUrl: './userdash.component.html',
  styleUrls: ['./userdash.component.css']
})
export class UserdashComponent implements OnInit {
 username='';
 id='';
  constructor(private router:Router) {
    // this.myServ.getUserName().subscribe(
    //   data=>this.username=data.toString(),
    //   error=>this.router.navigate(['Userlog'])
    this.username=localStorage.getItem('token');
    this.id=localStorage.getItem('user_id');
    // )
   }

  ngOnInit() {
    if(localStorage.getItem('token')==null)
    {
      this.router.navigate(['Userlog']);   
    }
  }
  checkBlock()
  {}
  
logout(){
  localStorage.removeItem('token');
  this.router.navigate(['Userlog']);
}
}
