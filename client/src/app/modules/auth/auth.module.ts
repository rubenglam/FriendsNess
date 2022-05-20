import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './pages/login/login.component';
import { RegisterComponent } from './pages/register/register.component';
import { FormsModule } from '@angular/forms';
import { AuthService } from './services/auth.service';

@NgModule({
  declarations: [
    LoginComponent,
    RegisterComponent
  ],
  exports: [
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  providers: [
    AuthService
  ]
})
export class AuthModule { }
