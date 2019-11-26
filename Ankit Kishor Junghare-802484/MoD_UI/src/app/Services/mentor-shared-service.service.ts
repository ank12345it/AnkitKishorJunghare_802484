import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Mentor} from "../Models/mentor";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class MentorSharedServiceService {
  path:string="http://localhost:25736/Mentor"
 
  constructor(private _client:HttpClient) { }
  public GetAll():Observable<Mentor[]>
  {
    return this._client.get<Mentor[]>(this.path+'/Mentor_GetAll');

  }
  public Block(item:number):Observable<string>
{
  return this._client.get<string>(this.path+'/Mentor_Block/'+item);
}
  public Add(item:Mentor):Observable<string>
  {
    return this._client.post<string>(this.path+'/Mentor_Add',item);

  }
  public Delete(item:number):Observable<string>
{
 return this._client.delete<string>(this.path+'/Mentor_Delete/'+item);}

}
