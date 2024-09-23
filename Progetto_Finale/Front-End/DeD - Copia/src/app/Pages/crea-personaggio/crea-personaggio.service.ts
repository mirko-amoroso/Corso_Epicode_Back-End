
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IClassi } from '../../modules/classi';
import { IAttributi } from '../../modules/attributi';
import { IBackground } from '../../modules/background';
import { InewPersonaggio } from '../../modules/newPersonaggio';
import { IAbility } from '../../modules/ability';
import { IAttribut } from '../../modules/attribut';
import { IBack } from '../../modules/back';
import { ITiriSalvezza } from '../../modules/tiri-salvezza';

@Injectable({
  providedIn: 'root',
})
export class CreaPersonaggioService {
  private ApiUrl = 'https://localhost:7075/';

  constructor(private http: HttpClient) {}

  // //FUNZIONI UTILI
  // Personaggioid(IdUtente : number): Observable<any> {
  //   return this.http.get(this.ApiUrl.concat(`Personaggio/Utente/${IdUtente}`))
  // }

  //CREA FUNZIONI
  //CreaPersonaggio
  CreaPers(CreaPers: InewPersonaggio): Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Personaggio'), CreaPers);
  }
  // Crea Classe
  CreaClasse(classe :IClassi) : Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Classi'), classe);
  }
  // Crea Attributi
  CreaAttributi(attributi : IAttribut) :Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Attributi'), attributi);
  }
  // Crea Abilità
  CreaAbilita(abilita : IAbility) :Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Abilita'), abilita);
  }
  // Crea Abilità
  CreaBackground(back : IBack) :Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Background'), back);
  }

  CreaTiri_Salvezza(TS : ITiriSalvezza) : Observable<any> {
    return this.http.post<any>(this.ApiUrl.concat('Tiri_Salvezza'), TS);
  }
}
