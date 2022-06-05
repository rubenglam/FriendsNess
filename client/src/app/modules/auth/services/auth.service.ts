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
    const url = `${this._baseUrl}/authentication/register`;
    return this.httpClient.post<AuthResponse>(url, registerRequest).pipe(
      tap((response) => {
        if (response.success) {
          this.cookieService.set('auth-token', response.token!);
        }
      }),
      map((response) => response.success),
      catchError((responseError) => of(responseError.error))
    );
  }

  login(signInRequest: LoginRequest) {
    const url = `${this._baseUrl}/authentication/login`;
    return this.httpClient.post<AuthResponse>(url, signInRequest).pipe(
      tap((response) => {
        if (response.success) {
          this.cookieService.set('auth-token', response.token!);
        }
      }),
      map((response) => response.success),
      catchError((responseError) => of(responseError.error))
    );
  }

  refreshToken(): Observable<boolean> {
    const url = `${this._baseUrl}/authentication/refreshtoken`;
    const headers = new HttpHeaders().set(
      'auth-token',
      localStorage.getItem('token') || ''
    );

    return this.httpClient.get<AuthResponse>(url, { headers }).pipe(
      map((response) => {
        this.cookieService.set('auth-token', response.token!);
        // this._user = {
        //   email: response.email!,
        //   id: response.userId!,
        //   userExercices: [],
        //   userName: response.userName!
        // };
        return response.success;
      }),
      catchError((responseError) => of(false))
    );
  }

  getUserLogged(userId: string) {
    const url = `${this._baseUrl}/users/${userId}`;
    const token = this.cookieService.get('auth-token');
    const headers = new HttpHeaders().set('auth-token', token || '');
    this.httpClient.get<UserResponse>(url, { headers }).pipe(map(response) => {

    });
  }

  logout() {
    this.cookieService.delete('auth-token');
  }

  get userEmail(): string {
    return this._userEmail;
  }
}
