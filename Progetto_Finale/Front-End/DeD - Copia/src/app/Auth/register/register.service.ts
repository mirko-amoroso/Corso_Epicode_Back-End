import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, tap, throwError } from 'rxjs';
import { INewCredenziali } from '../../modules/new-credenziali';

@Injectable({
  providedIn: 'root',
})
export class RegisterService {
  private ApiUrl = 'https://localhost:7075/';

  constructor(private http: HttpClient) {}

  Register(newCredenziali: INewCredenziali): Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Utente/Register'), newCredenziali)
      .pipe(
        tap(response => console.log('Risposta del server:', response)),
        catchError((error: any) => {
          console.error('Errore durante la registrazione:', error);
          return throwError(() => new Error(error));
        })
      );
  }



}
