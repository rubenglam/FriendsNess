import { Injectable } from '@angular/core';
import { catchError, map, Observable, of, tap } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Exercice } from '../../../models/exercices/exercice.model';
import { environment } from '../../../../environments/environment';

@Injectable({
  providedIn: 'root',
})
export class ExercicesService {
  private _baseUrl = environment.baseUrl;
  private _exercices!: Exercice[];

  constructor(private httpClient: HttpClient) {}

  getExercices(): Observable<Exercice[]> {
    const url = `${this._baseUrl}/Exercices`;
    return this.httpClient.get<Exercice[]>(url).pipe(
      tap((response) => {
        this._exercices = response;
      })
    );
  }

  get exercices() : Exercice[] {
    return { ...this.exercices };
  }
}
