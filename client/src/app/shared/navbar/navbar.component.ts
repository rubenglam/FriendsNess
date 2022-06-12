import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { AuthService } from '../../modules/auth/services/auth.service';

import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})
export class NavbarComponent implements OnInit {
  items: MenuItem[];

  constructor(private authService: AuthService) {}

  ngOnInit(): void {
    this.items = [
      {
        label: 'Home',
      },
      {
        label: 'Exercices'
      },
      {
        label: 'Workouts'
      },
      {
        label: 'Account'
      }
    ];
  }

  get isLogged() {
    return this.authService.userEmail !== undefined;
  }
}
