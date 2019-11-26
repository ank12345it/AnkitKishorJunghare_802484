import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CommonService {
  

  constructor(private http:HttpClient) { }
 getUserName(){
   return this.http.get('http://localhost:8091/api/username',{
     observe:'body',
     params:new  HttpParams().append('token',localStorage.getItem('token'))
   });
 }
 getMentorName(){
  return this.http.get('http://localhost:8091/api/mentorname',{
    observe:'body',
    
    params:new  HttpParams().append('token',localStorage.getItem('token'))
  }
  );
}
}
