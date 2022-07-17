import { Component, Input, OnInit } from '@angular/core';
import { RegisterRequest } from '../../models/register-request.model';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ValidatorsService } from '../../../../services/validators.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css'],
})
export class RegisterComponent {
  form: FormGroup = this.fb.group(
    {
      userName: ['', [Validators.required, Validators.minLength(3)]],
      email: [
        '',
        [
          Validators.required,
          Validators.pattern(this.validatorsService.EMAIL_PATTERN),
        ],
      ],
      password: ['', [Validators.required, Validators.minLength(6)]],
      confirmPassword: ['', [Validators.required, Validators.minLength(6)]],
    },
    {
      validators: [
        this.validatorsService.matchFields('password', 'confirmPassword'),
      ],
    }
  );
  registerRequest = new RegisterRequest();

  constructor(
    private router: Router,
    private fb: FormBuilder,
    private validatorsService: ValidatorsService,
    private authService: AuthService
  ) {}

  fieldInvalid(field: string) {
    return this.form.get(field)?.invalid && this.form.get(field)?.touched;
  }

  submit() {
    // Comprobar que todos los campos són correctos
    this.form.markAllAsTouched();

    // Si el formulario es válido, registra el usuario
    if (this.form.valid) {
      this.authService.register(this.registerRequest).subscribe((success) => {
        if (success) {
          this.router.navigateByUrl('/login');
        }
      });
    }
  }
}
