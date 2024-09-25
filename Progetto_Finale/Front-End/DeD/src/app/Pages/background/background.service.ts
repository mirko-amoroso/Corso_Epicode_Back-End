import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IBackgroundModifica } from '../../modules/backgroundMdifica';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BackgroundService {

  private ApiUrl = 'https://localhost:7075/';

  constructor(private http: HttpClient) { }

  GetBackground = (PersonaggioId : number): Observable<any> => {
    return this.http.get<IBackgroundModifica>(this.ApiUrl.concat(`Background/Personaggio/${PersonaggioId}`))
  }
}
