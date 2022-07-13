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
  private AUTH_TOKEN = 'auth-token';
  private AUTH_USER = 'auth-user';
  private BASE_URL = environment.baseUrl;

  constructor(
    private httpClient: HttpClient,
    private cookieService: CookieService
  ) {}

  verifyAuthenticated(): Observable<boolean> {
    // Si existe el token en los cookies, generamos un nuevo token. Si todo funciona correctamente el usuario esta autenticado
    if (this.cookieService.get(this.AUTH_TOKEN)) {
      return this.renewToken();
    }

    // Como no existe ningún token, devolvemos que el usuario no esta autenticado
    return of(false);
  }

  register(registerRequest: RegisterRequest) {
    const url = `${this.BASE_URL}/auth/register`;
    return this.httpClient.post<AuthResponse>(url, registerRequest).pipe(
      tap(response => {
        this.cookieService.set(this.AUTH_TOKEN, response.token);
        this.cookieService.set(this.AUTH_USER, response.user);
      }),
      catchError(responseError => of(responseError.error))
    );
  }

  login(loginRequest: LoginRequest) {
    const url = `${this.BASE_URL}/auth/login`;
    return this.httpClient.post<AuthResponse>(url, loginRequest).pipe(
      tap(response => {
        this.cookieService.set(this.AUTH_TOKEN, response.token);
        this.cookieService.set(this.AUTH_USER, response.user);
      }),
      catchError(errorResponse => errorResponse)
    );
  }

  renewToken(): Observable<boolean> {
    const token = this.cookieService.get(this.AUTH_TOKEN) || '';

    const url = `${this.BASE_URL}/auth/renewToken`;
    const headers = { Authorization: `Bearer ${token}` };

    return this.httpClient
      .get<AuthResponse>(url, {
        headers,
      })
      .pipe(
        tap(response => {
          console.log(response);
          this.cookieService.set(this.AUTH_TOKEN, response.token);
          this.cookieService.set(this.AUTH_USER, response.user);
        }),
        map(() => true),
        catchError(error => {
          console.log(error);
          return of(false);
        })
      );
  }

  logout() {
    this.cookieService.delete(this.AUTH_TOKEN);
    this.cookieService.delete(this.AUTH_USER);
  }

  get isAuthenticated(): boolean {
    return this.cookieService.get(this.AUTH_TOKEN) != null;
  }

  get getUser(): any {
    return this.cookieService.get(this.AUTH_USER);
  }
}
