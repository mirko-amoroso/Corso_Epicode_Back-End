import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IPersonaggio } from '../../modules/personaggio';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InfoPersonaggioService {

  private ApiUrl = "https://localhost:7075/"

  constructor(private http:HttpClient) { }

  personaggioCompleto = (PersonaggioID :number) : Observable<any> => {
    return this.http.get<IPersonaggio>(this.ApiUrl.concat(`Personaggio/Completo/${PersonaggioID}`))
  }
}
