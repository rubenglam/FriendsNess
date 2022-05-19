import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ExercicesModule } from './modules/exercices/exercices.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { FlexLayoutModule } from '@angular/flex-layout';
import { HomeIndexPageComponent } from './modules/home/pages/home-index-page/home-index-page.component';
// import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './modules/auth/pages/register/register.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeIndexPageComponent,
    // LoginComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ExercicesModule,
    BrowserAnimationsModule,
    FlexLayoutModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
