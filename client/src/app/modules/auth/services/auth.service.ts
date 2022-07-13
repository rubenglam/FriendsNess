import { Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { LoginRequest } from '../models/login-request.model';
import { AuthResponse } from '../models/auth-response.model';
import { of, Observable } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { RegisterRequest } from '../models/register-request.model';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { ApplicationUser } from '../../../models/users/application-user.model';
import { CookieService } from 'ngx-cookie-service';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private _baseUrl = environment.baseUrl;

  constructor(
    private httpClient: HttpClient,
    private cookieService: CookieService
  ) {}

  register(registerRequest: RegisterRequest) {
    const url = `${this._baseUrl}/auth/register`;
    return this.httpClient.post<AuthResponse>(url, registerRequest).pipe(
      tap(response => {
        localStorage.setItem('auth-token', response.token);
        this.cookieService.set('auth-token', response.token);
      }),
      map(response => response.success),
      catchError(responseError => of(responseError.error))
    );
  }

  login(loginRequest: LoginRequest) {
    const url = `${this._baseUrl}/auth/login`;
    return this.httpClient.post<AuthResponse>(url, loginRequest).pipe(
      tap(response => {
        localStorage.setItem('auth-token', response.token);
        this.cookieService.set('auth-token', response.token);
      }),
      catchError(errorResponse => errorResponse)
    );
  }

  renewToken(): Observable<boolean> {
    const token = localStorage.getItem('auth-token') || '';

    const url = `${this._baseUrl}/auth/renewToken`;
    const headers = { 'auth-token': token };

    return this.httpClient
      .get<AuthResponse>(url, {
        headers,
      })
      .pipe(
        tap(response => {
          localStorage.setItem('auth-token', response.token);
          this.cookieService.set('auth-token', response.token);
        }),
        map(() => true),
        catchError(() => of(false))
      );
  }

  getUserLogged(userId: string) {
    const url = `${this._baseUrl}/users/${userId}`;
    const token = this.cookieService.get('auth-token');
    const headers = new HttpHeaders().set('auth-token', token || '');
    // this.httpClient.get<UserResponse>(url, { headers }).pipe(map(response) => {

    // });
  }

  logout() {
    localStorage.removeItem('auth-token');
    this.cookieService.delete('auth-token');
  }

  get userEmail(): string {
    return undefined;
    //return this._userEmail;
  }
}
