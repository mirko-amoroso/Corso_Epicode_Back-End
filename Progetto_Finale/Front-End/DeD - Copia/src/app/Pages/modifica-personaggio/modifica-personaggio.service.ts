import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IPersonaggio } from '../../modules/personaggio';

@Injectable({
  providedIn: 'root'
})
export class ModificaPersonaggioService {

  private ApiUrl = "https://localhost:7075/"

  constructor(private http:HttpClient) { }

  personaggioCompleto = (PersonaggioID :number) : Observable<any> => {
    return this.http.get<IPersonaggio>(this.ApiUrl.concat(`Personaggio/Completo/${PersonaggioID}`))
  }
}
