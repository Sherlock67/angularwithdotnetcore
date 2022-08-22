import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Person } from "./person";
@Injectable({
  providedIn: 'root'
})
export class PersonService {
  private apiUrl = "https://localhost:44456/api";
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type' : 'application/json'
    })
  };
  constructor(private httpClient: HttpClient) { }
  createPerson(person: object): Observable<Person> {
    return this.httpClient.post<Person>(this.apiUrl + '/CreatePerson/', JSON.stringify(person), this.httpOptions)
      .pipe(
        catchError(this.errorHandler)
      );
  }
  errorHandler(error: { error: { message: string; }; status: any; message: any; }) {
    let errorMessage = '';

    if (error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(errorMessage);
  }
}
