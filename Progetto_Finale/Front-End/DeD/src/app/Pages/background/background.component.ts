import { Component } from '@angular/core';
import { BackgroundService } from './background.service';
import { IBackgroundModifica } from '../../modules/backgroundMdifica';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-bacground',
  templateUrl: './background.component.html',
  styleUrl: './background.component.scss',
})
export class BackgroundComponent {

  personaggioId :number = 0
  back: IBackgroundModifica = {
    personaggioID: 0,
    backgroundId: 0,
    trattiCaratteriali: '',
    ideali: '',
    legami: '',
    difetti: '',
    allineamento: '',
    backGround: '',
  };

  constructor(
    private BackSrv: BackgroundService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe((params) => {
      const id = params.get('personaggioId');
      if (id) {
        this.personaggioId = Number(id);
        console.log('ID del personaggio ricevuto:', this.personaggioId);

        // Sposta la chiamata qui, dopo aver ricevuto l'ID
        this.BackSrv.GetBackground(this.personaggioId).subscribe(
          (data) => {
            console.log('Dati ricevuti:', data);
            this.back = data;
            console.log("back", this.back)
          },
          (error) => {
            console.error('Errore nella chiamata al servizio:', error);
          }
        );
      } else {
        console.error('Parametro personaggioId non trovato!');
      }
    });
  }

}
