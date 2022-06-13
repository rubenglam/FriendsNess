import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { AuthService } from '../../modules/auth/services/auth.service';

import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})
export class NavbarComponent {
  constructor(private authService: AuthService) {}

  navTogglerClicked(e: Event) : void {
    const element = e.target;
  }

  get isLogged() {
    return this.authService.userEmail !== undefined;
  }
}
