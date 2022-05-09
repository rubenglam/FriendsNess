import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiHelperService {

constructor(
  private http: HttpClient
  ) { }

  getAll<T>(url: string) : Observable<T[]> {
    return this.http.get<T[]>(url);
  }

  get<T>(url: string) : Observable<T> {
    return this.http.get<T>(url);
  }

  post<T>(url: string, item: T) {
    console.log("sending");
  }
}
