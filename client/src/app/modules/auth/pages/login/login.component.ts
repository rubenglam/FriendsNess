import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { LoginRequest } from '../../models/login-request.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {
  constructor(private router: Router, private authService: AuthService) {}

  login() {
    let loginRequest: LoginRequest = {
      email: 'rubenbermudezsaez@gmail.com',
      password: '1234',
    };
    this.authService.login(loginRequest).subscribe((response) => {
      if (response.success) {
        this.router.navigateByUrl('/home');
      }
    });
  }
}
