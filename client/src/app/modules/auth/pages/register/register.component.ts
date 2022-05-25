import { Component, Input, OnInit } from '@angular/core';
import { RegisterRequest } from '../../models/register-request.model';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent {
  registerForm: FormGroup = this.formBuilder.group({
    userName: [''],
    email: ['', [Validators.required, Validators.email]],
    password: ['', [Validators.required, Validators.minLength(4)]],
  });
  registerRequest = new RegisterRequest();

  constructor(
    private router: Router,
    private formBuilder: FormBuilder,
    private authService: AuthService
  ) {}

  register() {
    this.authService.register(this.registerRequest).subscribe((success) => {
      if (success) {
        this.router.navigateByUrl('/login');
      }
    });
  }
}
