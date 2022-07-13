import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { LoginRequest } from '../../models/login-request.model';
import { Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent {
  loginForm: FormGroup = this.formBuilder.group({
    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(4)]],
  });
  errorMessage: string;

  constructor(
    private router: Router,
    private formBuilder: FormBuilder,
    private authService: AuthService
  ) {}

  login() {
    console.log('Login');
    // Resetear variables
    this.errorMessage = undefined;
    // Mapear los datos del formulario en un request
    const request: LoginRequest = {
      username: this.loginForm.value.email,
      password: this.loginForm.value.password,
    };
    // Enviar la petición de inició de sesión
    this.authService.login(request).subscribe(
      response => {
        // Enviar al usuario a la home page
        this.router.navigateByUrl('/home');
      },
      error => {
        this.errorMessage = error;
      }
    );
  }
}
