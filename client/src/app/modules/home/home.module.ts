import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeIndexPageComponent } from './pages/home-index-page/home-index-page.component';
import { SignInHomeComponent } from './components/login-home/sign-in-home.component';

@NgModule({
  declarations: [
    HomeIndexPageComponent,
    SignInHomeComponent
  ],
  exports: [
    HomeIndexPageComponent
  ],
  imports: [
    CommonModule
  ]
})
export class HomeModule { }
