import { Component, OnInit } from '@angular/core';
import { User } from '../../../../models/users/user.model';
import { AuthService } from '../../../auth/services/auth.service';

@Component({
  selector: 'app-home-authorized',
  templateUrl: './home-authorized.component.html',
  styleUrls: ['./home-authorized.component.css'],
})
export class HomeAuthorizedComponent implements OnInit {
  user: User;

  constructor(private authService: AuthService) {}

  ngOnInit(): void {
    this.user = this.authService.getUser;
  }
}
