import { Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { LoginRequest } from '../models/login-request.model';
import { AuthResponse } from '../models/auth-response.model';
import { of, Observable } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { RegisterRequest } from '../models/register-request.model';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { User } from '../../../models/users/user.model';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private readonly AUTH_TOKEN = 'auth-token';
  private readonly AUTH_USER = 'auth-user';
  private readonly BASE_URL = environment.baseUrl;

  constructor(private httpClient: HttpClient, private router: Router) {}

  register(registerRequest: RegisterRequest) {
    const url = `${this.BASE_URL}/auth/register`;
    return this.httpClient.post<AuthResponse>(url, registerRequest).pipe(
      tap((response) => {
        localStorage.setItem(this.AUTH_TOKEN, response.token);
        localStorage.setItem(this.AUTH_USER, JSON.stringify(response.user));
      }),
      catchError((responseError) => of(responseError.error))
    );
  }

  login(loginRequest: LoginRequest) {
    const url = `${this.BASE_URL}/auth/login`;
    return this.httpClient.post<AuthResponse>(url, loginRequest).pipe(
      tap((response) => {
        localStorage.setItem(this.AUTH_TOKEN, response.token);
        localStorage.setItem(this.AUTH_USER, JSON.stringify(response.user));
      }),
      catchError((errorResponse) => errorResponse)
    );
  }

  renewToken(): Observable<boolean> {
    const token = localStorage.getItem(this.AUTH_TOKEN) || '';

    const url = `${this.BASE_URL}/auth/renewToken`;
    const headers = { Authorization: `Bearer ${token}` };

    return this.httpClient
      .get<AuthResponse>(url, {
        headers,
      })
      .pipe(
        tap((response) => {
          localStorage.setItem(this.AUTH_TOKEN, response.token);
          localStorage.setItem(this.AUTH_USER, JSON.stringify(response.user));
        }),
        map(() => true),
        catchError((error) => {
          return of(false);
        })
      );
  }

  tokenExpired(token: string) {
    const expiry = JSON.parse(atob(token.split('.')[1])).exp;
    return Math.floor(new Date().getTime() / 1000) >= expiry;
  }

  logout() {
    localStorage.removeItem(this.AUTH_TOKEN);
    localStorage.removeItem(this.AUTH_USER);
    this.router.navigateByUrl('/auth/login');
  }

  logoutToHome() {
    localStorage.removeItem(this.AUTH_TOKEN);
    localStorage.removeItem(this.AUTH_USER);
    this.router.navigateByUrl('');
  }

  getToken() {
    return localStorage.getItem(this.AUTH_TOKEN);
  }

  validateToken(): boolean {
    const token = localStorage.getItem(this.AUTH_TOKEN);
    if (!token) {
      return false;
    }

    if (this.tokenExpired(token)) {
      return false;
    }

    return true;
  }

  get getUser(): User {
    const user = localStorage.getItem(this.AUTH_USER);
    if (user !== null) {
      return JSON.parse(user);
    }
    return null;
  }
}
