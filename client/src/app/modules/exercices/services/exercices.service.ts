import { Injectable } from '@angular/core';
import { catchError, Head, map, Observable, of, tap } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Exercice } from '../../../models/exercices/exercice.model';
import { environment } from '../../../../environments/environment';
import { CookieService } from 'ngx-cookie-service';
import { AuthService } from '../../auth/services/auth.service';
import { UserExercice } from 'src/app/models/exercices/user-exercice.model';

@Injectable({
  providedIn: 'root',
})
export class ExercicesService {
  private BASE_URL = environment.baseUrl;

  constructor(
    private httpClient: HttpClient,
    private AuthService: AuthService
  ) {}

  getExercices(): Observable<Exercice[]> {
    const url = `${this.BASE_URL}/exercices`;
    const token = this.AuthService.getToken();
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      Authorization: `Bearer ${token}`,
    });

    return this.httpClient
      .get<any>(url, { headers: headers })
      .pipe(map((response) => response!.exercices));
  }

  getMyExercices(): Observable<UserExercice[]> {
    const url = `${this.BASE_URL}/user-exercices`;
    const headers = this.getHeaders();

    return this.httpClient
      .get<any>(url, { headers: headers })
      .pipe(map((response) => response!.userExercices));
  }

  createUserExercice(userExercice: UserExercice): Observable<UserExercice> {
    const url = `${this.BASE_URL}/user-exercices`;
    const headers = this.getHeaders();

    return this.httpClient
      .post<any>(url, userExercice, { headers })
      .pipe(map((response) => response!.userExercice));
  }

  getHeaders(): HttpHeaders {
    const token = this.AuthService.getToken();
    return new HttpHeaders({
      'Content-Type': 'application/json',
      Authorization: `Bearer ${token}`,
    });
  }
}
