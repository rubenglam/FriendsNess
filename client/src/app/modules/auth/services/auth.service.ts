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
  private _userEmail!: string;

  constructor(private httpClient: HttpClient) {}

  register(registerRequest: RegisterRequest) {
    const url = `${this._baseUrl}/authentication/register`;
    return this.httpClient.post<AuthResponse>(url, registerRequest).pipe(
      tap((response) => {
        if (response.success) {
          localStorage.setItem('token', response.token!);
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
          localStorage.setItem('token', response.token!);
          this._userEmail = response.email;
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
        localStorage.setItem('token', response.token!);
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

  logout() {
    localStorage.clear();
  }

  get userEmail(): string {
    return this._userEmail;
  }
}
