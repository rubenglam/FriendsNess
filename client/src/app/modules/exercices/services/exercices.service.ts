import { Injectable } from '@angular/core';
import { catchError, Head, map, Observable, of, tap } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Exercice } from '../../../models/exercices/exercice.model';
import { environment } from '../../../../environments/environment';
import { CookieService } from 'ngx-cookie-service';

@Injectable({
  providedIn: 'root',
})
export class ExercicesService {
  private _baseUrl = environment.baseUrl;

  get token(): string {
    return this.cookieService.get('auth-token');
  }

  constructor(
    private httpClient: HttpClient,
    private cookieService: CookieService
  ) {}

  getExercices(): Observable<Exercice[]> {
    const url = `${this._baseUrl}/exercices`;
    const headers = new HttpHeaders({
      'Content-Type': 'application/json',
      Authorization: `Bearer ${this.token}`,
    });
    return this.httpClient
      .get<any>(url, { headers: headers })
      .pipe(map((response) => response!.exercices));
  }
}
