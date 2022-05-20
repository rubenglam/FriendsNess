import { Component, Input, OnInit } from '@angular/core';
import { RegisterRequest } from '../../models/register-request.model';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  @Input() registerRequest : RegisterRequest;

  constructor(private router: Router, private authService: AuthService) { }

  register() {
    this.authService.register(this.registerRequest).subscribe(response => {
      if (response.success) {
        this.router.navigateByUrl("/login");
      }
    });
  }
}
