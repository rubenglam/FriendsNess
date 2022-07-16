import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { AuthService } from '../../modules/auth/services/auth.service';
import { ThemeService } from '../../services/theme.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css'],
})
export class NavbarComponent {
  constructor(private authService: AuthService,
    private themeService: ThemeService) { }

  get isLogged() {
    return this.authService.isAuthenticated;
  }

  get getUser() {
    return this.authService.getUser;
  }

  logout() {
    this.authService.logout();
  }

  changeTheme() {
    this.themeService.toggleTheme();
  }
}
