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
  loginForm: FormGroup = this.fb.group({
    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(4)]],
    rememberMe: [false, [Validators.required]]
  });

  constructor(
    private router: Router,
    private fb: FormBuilder,
    private authService: AuthService
  ) { }

  login() {
    const formValue = { ...this.loginForm.value };
    // Mapear los datos del formulario en un request
    const request: LoginRequest = {
      username: formValue.email,
      password: formValue.password,
    };
    // Enviar la petición de inició de sesión
    this.authService.login(request).subscribe(
      response => {
        // Enviar al usuario a la home page
        this.router.navigateByUrl('/home');
      },
      error => {
        console.log(error);
      }
    );
  }
}
