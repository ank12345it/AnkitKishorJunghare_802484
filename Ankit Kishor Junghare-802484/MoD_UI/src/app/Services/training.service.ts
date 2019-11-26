import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Training } from '../Models/training';

@Injectable({
  providedIn: 'root'
})
export class TrainingService {

  path:string="http://localhost:26266/api/Training"
  training:Training;

  constructor(private _client:HttpClient) { }
  public GetAll():Observable<Training[]> 
  {
    return this._client.get<Training[]>(this.path+'/Training_GetAll') ;
 }
 public Add():Observable<string>
{
  return this._client.post<string>(this.path+'/Training_Add',this.training);

}
public Assign(item:Training)
{
  this.training=item;
}
}
