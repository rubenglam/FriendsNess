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

  verifyAuthenticated(): Observable<boolean> {
    // Si existe el token en los cookies
    const token = localStorage.getItem(this.AUTH_TOKEN);
    if (token) {
      return of(true);
    }

    // Como no existe ningún token, devolvemos que el usuario no esta autenticado
    return of(false);
  }

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
        console.log(response);
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
          console.log(response);
          localStorage.setItem(this.AUTH_TOKEN, response.token);
          localStorage.setItem(this.AUTH_USER, JSON.stringify(response.user));
        }),
        map(() => true),
        catchError((error) => {
          console.log(error);
          return of(false);
        })
      );
  }

  logout() {
    localStorage.removeItem(this.AUTH_TOKEN);
    localStorage.removeItem(this.AUTH_USER);
    this.router.navigateByUrl('/');
  }

  getToken() {
    return localStorage.getItem(this.AUTH_TOKEN);
  }

  get isAuthenticated(): boolean {
    return localStorage.getItem(this.AUTH_TOKEN) !== null;
  }

  get getUser(): any {
    const user = localStorage.getItem(this.AUTH_USER);
    if (user !== null) {
      return JSON.parse(user);
    }
    return null;
  }
}
