import { IAbilita } from './../../modules/abilita';
import { IPersonaggio } from './../../modules/personaggio';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IClassi } from '../../modules/classi';
import { IAttributi } from '../../modules/attributi';
import { IBackground } from '../../modules/background';

@Injectable({
  providedIn: 'root',
})
export class CreaPersonaggioService {
  private ApiUrl = 'https://localhost:7075/';

  constructor(private http: HttpClient) {}

  //FUNZIONI UTILI
  Personaggioid(IdUtente : number): Observable<any> {
    return this.http.get(this.ApiUrl.concat(`Personaggio/Utente/${IdUtente}`))
  }

  //CREA FUNZIONI
  //CreaPersonaggio
  CreaPers(CreaPers: IPersonaggio): Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Personaggio'), CreaPers);
  }
  // Crea Classe
  CreaClasse(classe :IClassi) : Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Classi'), classe);
  }
  // Crea Attributi
  CreaAttributi(attributi : IAttributi) :Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Attributi'), attributi);
  }
  // Crea Abilità
  CreaAbilita(abilita : IAbilita) :Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Abilita'), abilita);
  }
  // Crea Abilità
  CreaBackground(back : IBackground) :Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Abilita'), back);
  }
}
