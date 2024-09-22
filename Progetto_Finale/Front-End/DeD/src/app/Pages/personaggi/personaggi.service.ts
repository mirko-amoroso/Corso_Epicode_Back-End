import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IPersonaggio } from '../../modules/personaggio';

@Injectable({
  providedIn: 'root'
})
export class PersonaggiService {

  private ApiUrlGet = 'https://localhost:7075/';

  constructor(private http:HttpClient) { }

  // PersonaggiUtente1(IdUtente : string) : Observable<IPersonaggio[]>{
  //   var ArrayPersonaggi: IPersonaggio[] = this.http.get(this.ApiUrlGet.concat(`Personaggio/Utente/${IdUtente}`))
  //   return ArrayPersonaggi
  // }

  PersonaggiUtente(IdUtente: string): Observable<IPersonaggio[]> {
    return this.http.get<IPersonaggio[]>(`${this.ApiUrlGet}Personaggio/Utente/${IdUtente}`);
  }

}