import { Injectable } from '@angular/core';
import { CanActivate, CanLoad, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AuthService } from '../services/auth.service';
import { tap, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate, CanLoad {
  constructor(private authService: AuthService, private router: Router) {}

  canActivate(): Observable<boolean> | boolean {
    return this.authService.renewToken().pipe(
      tap(isAuth => {
        if (!isAuth) {
          this.router.navigateByUrl('/auth/login');
        }
      })
    );
  }

  canLoad(): Observable<boolean> | boolean {
    return this.authService.renewToken().pipe(
      tap(valid => {
        if (!valid) {
          this.router.navigateByUrl('/auth/login');
        }
      })
    );
  }
}
