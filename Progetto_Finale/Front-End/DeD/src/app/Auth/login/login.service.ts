import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICredenziali } from '../../modules/credenziali';

@Injectable({
  providedIn: 'root',
})
export class LoginService {
  private ApiUrl = 'https://localhost:7075/'; //Radice URL

  constructor(private http: HttpClient) {}

  Login(credenziali: ICredenziali): Observable<any> {
    var utente = this.http.post(
      this.ApiUrl.concat('Utente/Login'),
      credenziali
    );
    return utente;
  }
}
