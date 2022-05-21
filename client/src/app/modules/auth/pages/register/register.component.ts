import { Component, Input, OnInit } from '@angular/core';
import { RegisterRequest } from '../../models/register-request.model';
import { AuthService } from '../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Input() name: string;

  setValue() {
    this.name = 'Nancy';
  }


  // @Input() public registerRequest = new RegisterRequest();
  // email: string = "Example";

  constructor(private router: Router, private authService: AuthService) { }

  ngOnInit(): void {

  }

  register() {
    console.log("Hola");
    // this.authService.register(this.registerRequest).subscribe(response => {
    //   if (response.success) {
    //     this.router.navigateByUrl("/login");
    //   }
    // });
  }
}
