import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../../auth/services/auth.service';
import { User } from '../../../../models/users/user.model';

@Component({
  selector: 'app-profile-details',
  templateUrl: './profile-details.component.html',
  styles: [
  ]
})
export class ProfileDetailsComponent implements OnInit {
  user: User;

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
    this.user = this.authService.getUser;
  }

}
