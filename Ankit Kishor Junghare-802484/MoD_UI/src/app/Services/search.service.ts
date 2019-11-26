import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Mentor } from '../Models/mentor';

@Injectable({
  providedIn: 'root'
})
export class SearchService {
  path:string="http://localhost:25736/User"

  constructor(private _client:HttpClient) { }
  public Search(skill:string,from_time:string,to_time:string):Observable<Mentor[]>
  {
    return this._client.get<Mentor[]>(this.path+'/User_Search_Mentor/'+skill+'/'+from_time+'/'+to_time);
  }
}
