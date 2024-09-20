import { Component } from '@angular/core';
import { PersonaggiService } from './personaggi.service';
import { FormBuilder } from '@angular/forms';
import { IPersonaggio } from '../../modules/personaggio';
import { Router } from '@angular/router';

@Component({
  selector: 'app-personaggi',
  templateUrl: './personaggi.component.html',
  styleUrl: './personaggi.component.scss',
})
export class PersonaggiComponent {
  utenteId: string | null = null;
  ArrayPersonaggi: IPersonaggio[] = [];

  constructor(
    private personaggioService: PersonaggiService, private router :Router
  ) {}

  ngOnInit() {
    this.getPersonaggi()
    //devo prendere il valore da session storage e passarlo all'altra funzione nel service e poi prendere tutti i personaggi dell'id dell'utente
  }
  //funzione per prendere tutti i personaggi di un utente
  getPersonaggi = () => {
    this.utenteId = sessionStorage.getItem('IdUtente');
    if (this.utenteId) {
      this.personaggioService
  .PersonaggiUtente(this.utenteId)
  .subscribe((data) => {
    this.ArrayPersonaggi = data;
  });
    } else {
      console.log('IdUtente non trovato in session storage');
    }
  };

  RedirectPersonaggio(personaggioId: number) {
    this.router.navigate(['/infoPersonaggio', personaggioId])
      .then(success => {
        if (success) {
        } else {
          console.error('Redirect fallito');
        }
      })
      .catch(error => console.error('Errore nel redirect:', error));
  }
}
