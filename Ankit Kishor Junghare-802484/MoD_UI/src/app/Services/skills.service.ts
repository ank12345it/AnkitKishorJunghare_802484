import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Skills } from '../Models/skills';

@Injectable({
  providedIn: 'root'
})
export class SkillsService {

  
  path:string="http://localhost:25736/Skills"

  constructor(private _client:HttpClient) { }
  public GetAll():Observable<Skills[]>
  {
    return this._client.get<Skills[]>(this.path+'/Skills_GetAll') ;
 }
 public Add(item:Skills):Observable<string>
{
  return this._client.post<string>(this.path+'/Skills_Add',item);

}
public Block(item:number):Observable<string>
{
  return this._client.get<string>(this.path+'/User_Block/'+item);
}
public Delete(item:number):Observable<string>
{
 return this._client.delete<string>(this.path+'/User_Delete/'+item);}
}
