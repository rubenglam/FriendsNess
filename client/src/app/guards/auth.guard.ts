import { Injectable } from '@angular/core';
import { CanActivate, CanLoad, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../modules/auth/services/auth.service';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate, CanLoad {
  constructor(private authService: AuthService) {}

  canActivate(): Observable<boolean> | boolean {
    const isAuthenticated = this.authService.validateToken();
    if (!isAuthenticated) {
      this.authService.logout();
    }
    return isAuthenticated;
  }

  canLoad(): Observable<boolean> | boolean {
    const isAuthenticated = this.authService.validateToken();
    if (!isAuthenticated) {
      this.authService.logout();
    }
    return isAuthenticated;
  }
}
