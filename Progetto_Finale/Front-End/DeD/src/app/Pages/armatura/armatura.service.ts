import { Injectable } from '@angular/core';
import { IArmatura } from '../../modules/armatura';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ArmaturaService {

  ApiUrl: string = 'https://localhost:7075/';

  constructor(private http: HttpClient) {}

  Armatura = (PersonaggioID: number): Observable<any> => {
    return this.http.get<IArmatura>(
      this.ApiUrl.concat(`Armatura/Personaggio/${PersonaggioID}`)
    );
  };

  EliminaItem = (ArmaturaId: number): Observable<any> => {
    return this.http.delete(
      this.ApiUrl.concat(`Armatura/${ArmaturaId}`)
    );
  }

  AggiungiItem = (ArmaturaItem: IArmatura): Observable<any> => {
    return this.http.post<any>(
      this.ApiUrl.concat(`Armatura`), ArmaturaItem
    );
  }

  ModificaItem = (Armatura : IArmatura) => {
    return this.http.put(
      this.ApiUrl.concat(`Armatura`), Armatura
    );
  }
}
