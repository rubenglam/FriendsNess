import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { catchError, map, Observable, of, tap } from 'rxjs';
import { Exercice } from '../models/exercices/exercice.model';
import { HttpClient } from '@angular/common/http';
import { ApiHelperService } from './api-helper.service';

@Injectable({
  providedIn: 'root'
})
export class ExercicesService {

  private baseUrl = environment.baseUrl;

  constructor(
    private apiHelper: ApiHelperService
  ) { }

  getExercices() : Observable<Exercice[]> {
    const url = `${this.baseUrl}/exercices`;
    return this.apiHelper.getAll<Exercice>(url);
  }
}
