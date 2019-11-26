import { Pessoa } from './../../model/pessoa';
import { Injectable } from '@angular/core';
import { Observable, of, throwError } from 'rxjs';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { catchError, tap, map } from 'rxjs/operators';

const httpOptions = {
  headers: new HttpHeaders({'Content-Type': 'application/json'})
};
const apiUrl = 'http://omagister-001-site2.atempurl.com/api/pessoas';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  getPessoas (): Observable<Pessoa[]> {
    return this.http.get<Pessoa[]>(apiUrl)
      .pipe(
        tap(pessoas => console.log('leu as pessoas')),
        catchError(this.handleError('getPessoas', []))
      );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      console.error(error);

      return of(result as T);
    };
  }
}
