import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Iinventario } from '../../modules/inventario';

@Injectable({
  providedIn: 'root',
})
export class InventraioService {
  ApiUrl: string = 'https://localhost:7075/';

  constructor(private http: HttpClient) {}

  Inventario = (PersonaggioID: number): Observable<any> => {
    return this.http.get<Iinventario>(
      this.ApiUrl.concat(`Inventario/Personaggio/${PersonaggioID}`)
    );
  };

  EliminaItem = (InvId: number): Observable<any> => {
    return this.http.delete(
      this.ApiUrl.concat(`Inventario/${InvId}`)
    );
  }

  AggiungiItem = (InvItem: Iinventario): Observable<any> => {
    return this.http.post<any>(
      this.ApiUrl.concat(`Inventario`), InvItem
    );
  }
}
