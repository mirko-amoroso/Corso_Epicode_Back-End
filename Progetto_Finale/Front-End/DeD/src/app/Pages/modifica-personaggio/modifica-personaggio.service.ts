import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IPersonaggio } from '../../modules/personaggio';
import { IAttributiModifica } from '../../modules/attributiModifica';
import { IBackgroundModifica } from '../../modules/backgroundMdifica';
import { IPersonaggioModifica } from '../../modules/PersonaggioModifica';
import { IClassi } from '../../modules/classi';

@Injectable({
  providedIn: 'root',
})
export class ModificaPersonaggioService {
  private ApiUrl = 'https://localhost:7075/';

  constructor(private http: HttpClient) {}

  personaggioCompleto = (PersonaggioID: number): Observable<any> => {
    return this.http.get<IPersonaggio>(
      this.ApiUrl.concat(`Personaggio/Completo/${PersonaggioID}`)
    );
  };

  PutAttributi = (attributi: IAttributiModifica) => {
    return this.http.put(this.ApiUrl.concat(`Attributi`), attributi);
  };

  PutAllineamento = (back: IBackgroundModifica) => {
    return this.http.put(this.ApiUrl.concat(`Background`), back);
  };

  PutPersonaggio = (personaggio: IPersonaggioModifica) => {
    return this.http.put(this.ApiUrl.concat(`Personaggio`), personaggio);
  };

  PutClasse = (classe: IClassi) => {
    return this.http.put(this.ApiUrl.concat(`Classi`), classe);
  };
}
