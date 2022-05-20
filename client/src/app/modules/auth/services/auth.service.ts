import { Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment';
import { LoginRequest } from '../models/login-request.model';
import { AuthResponse } from '../models/auth-response.model';
import { of, Observable } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { RegisterRequest } from '../models/register-request.model';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { ApplicationUser } from '../../../models/users/application-user.model';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private _baseUrl = environment.baseUrl;
  private _user! : ApplicationUser;

  constructor(private httpClient: HttpClient) {}

  register(registerRequest: RegisterRequest) {
    const url = `${this._baseUrl}/Authentication/Register`;
    return this.httpClient
      .post<AuthResponse>(url, registerRequest)
      .pipe(
        tap(response => {
          if (response.success) {
            localStorage.setItem('token', response.token!);
          }
        }),
        map(response => response.success),
        catchError((responseError) => of(responseError.error.msg))
      );
  }

  login(signInRequest: LoginRequest) {
    const url = `${this._baseUrl}/Authentication/Login`;
    return this.httpClient
      .post<AuthResponse>(url, signInRequest)
      .pipe(
        tap((response) => {
          if (response.success) {
            localStorage.setItem('token', response.token!);
          }
        }),
        map((response) => response.success),
        catchError((responseError) => of(responseError.error.msg))
      );
  }

  refreshToken(): Observable<boolean> {
    const url = `${this._baseUrl}/auth/refreshToken`;
    const headers = new HttpHeaders().set(
      'x-token',
      localStorage.getItem('token') || ''
    );

    return this.httpClient.get<AuthResponse>(url, { headers }).pipe(
      map(response => {
        localStorage.setItem('token', response.token!);
        this._user = {
          email: response.email!,
          id: response.userId!,
          userExercices: [],
          userName: response.userName!
        };
        return response.success;
      }),
      catchError((erorr) => of(false))
    );
  }

  logout() {
    localStorage.clear();
  }

  get user() : ApplicationUser {
    return { ...this._user };
  }
}
