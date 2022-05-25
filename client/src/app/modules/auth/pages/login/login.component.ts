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
    // Resetear variables
    this.errorMessage = undefined;
    // Mapear los datos del formulario en un request
    const request: LoginRequest = {
      email: this.loginForm.value.email,
      password: this.loginForm.value.password,
    };
    // Enviar la petición de inició de sesión
    this.authService.login(request).subscribe((response) => {
      // Si devuvelve true, envia al usuario al home page. En caso contrario muestra un error
      if (response === true) {
        this.router.navigateByUrl('/home');
      }
      else{
        this.errorMessage = response;
      }
    });
  }
}
