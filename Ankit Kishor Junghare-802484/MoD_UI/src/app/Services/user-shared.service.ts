import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { User } from '../Models/user';

@Injectable({
  providedIn: 'root'
})
export class UserSharedService {
  path:string="http://localhost:25736/User"

  constructor(private _client:HttpClient) { }
  public GetAll():Observable<User[]>
  {
    return this._client.get<User[]>(this.path+'/User_GetAll') ;
 }
 public Add(item:User):Observable<string>
{
  return this._client.post<string>(this.path+'/User_Add',item);

}
public Block(item:number):Observable<string>
{
  return this._client.get<string>(this.path+'/User_Block/'+item);
}
public Delete(item:number):Observable<string>
{
 return this._client.delete<string>(this.path+'/User_Delete/'+item);}

}