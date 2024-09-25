import { Injectable } from '@angular/core';
import { IArmi } from '../../modules/armi';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ArmiService {
  ApiUrl: string = 'https://localhost:7075/';

  constructor(private http: HttpClient) {}

  Armi = (PersonaggioID: number): Observable<any> => {
    return this.http.get<IArmi>(
      this.ApiUrl.concat(`Armi/Personaggio/${PersonaggioID}`)
    );
  };

  EliminaItem = (ArmId: number): Observable<any> => {
    return this.http.delete(
      this.ApiUrl.concat(`Armi/${ArmId}`)
    );
  }

  AggiungiItem = (ArmiItem: IArmi): Observable<any> => {
    console.log("qui entro")
    return this.http.post<any>(
      this.ApiUrl.concat(`Armi`), ArmiItem
    );
  }}
