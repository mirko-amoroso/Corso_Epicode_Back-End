import { IPersonaggio } from './../../modules/personaggio';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { InfoPersonaggioService } from './info-personaggio.service';
import { IArmatura } from '../../modules/armatura';

@Component({
  selector: 'app-info-personaggio',
  templateUrl: './info-personaggio.component.html',
  styleUrl: './info-personaggio.component.scss',
})
export class InfoPersonaggioComponent implements OnInit {
  personaggioId!: number;
  PersonaggioFull!: IPersonaggio;
  Ca: number = 10;

  isLoading: boolean = true;

  constructor(
    private route: ActivatedRoute,
    private srvIPers: InfoPersonaggioService
  ) {}

  ngOnInit() {
    this.route.paramMap.subscribe((params) => {
      const id = params.get('personaggioId');
      if (id) {
        this.personaggioId = Number(id);
        console.log('ID del personaggio ricevuto:', this.personaggioId);
      } else {
        console.error('Parametro personaggioId non trovato!');
      }
    });
    this.srvIPers
      .personaggioCompleto(this.personaggioId)
      .subscribe((data: IPersonaggio) => {
        this.PersonaggioFull = data;
        console.log(this.PersonaggioFull);
        this.calcolaClasseArmatura();
        this.isLoading = false;
      });
  }

  calcoloAttribbuto(att: number) {
    var res: string;
    if (att >= 10) {
      res = '+'.concat(((att - 10) / 2).toFixed(0));
    } else {
      res = '-'.concat((att - 2).toFixed(0));
    }
    return res;
  }

  calcolaClasseArmatura() {
    if (this.PersonaggioFull.armatura) {
      for (let i = 0; i < this.PersonaggioFull.armatura.length; i++) {
        console.log(this.PersonaggioFull.armatura.length, "lunghezza array")
        console.log(this.PersonaggioFull.armatura[i])
        console.log(this.PersonaggioFull.armatura[i].indossato)
        if (this.PersonaggioFull.armatura[i].indossato === true) {
          this.Ca += this.PersonaggioFull.armatura[i].ca
        }
      }
    }
  }
}
