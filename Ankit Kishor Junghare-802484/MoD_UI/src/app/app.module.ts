import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UloginComponent } from './user/ulogin/ulogin.component';
import { MloginComponent } from './mentor/mlogin/mlogin.component';
import { AloginComponent } from './alogin/alogin.component';
import { UsignupComponent } from './user/usignup/usignup.component';
import { MsignupComponent } from './mentor/msignup/msignup.component';
import { JavamentorComponent } from './javamentor/javamentor.component';
import { SearchComponent } from './search/search.component';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './home/home.component';
import { UserdashComponent } from './dash/userdash/userdash.component';
import { MentordashComponent } from './dash/mentordash/mentordash.component';
import{LoginSharedService} from './Services/login-shared.service';

import {MentorSharedServiceService} from "./Services/mentor-shared-service.service";
import{UserSharedService} from "./Services/user-shared.service";
import{SkillsService} from "./Services/skills.service";
import { AdmindashComponent } from './dash/admindash/admindash.component';
import { MentorlistComponent } from './dash/mentorlist/mentorlist.component';
import { DashModule } from './dash/dash.module';

@NgModule({
  declarations: [
    AppComponent,
    UloginComponent,
    MloginComponent,
    AloginComponent,
    UsignupComponent,
    MsignupComponent,
    JavamentorComponent,
    SearchComponent,
    HomeComponent,
    UserdashComponent,
    MentordashComponent,
    //MentorlistComponent,
    //AdmindashComponent
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    DashModule,
    FormsModule
  ],
  providers: [MentorSharedServiceService,UserSharedService,LoginSharedService,SkillsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
