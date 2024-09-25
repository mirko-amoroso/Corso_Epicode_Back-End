import { IPersonaggio } from './../../modules/personaggio';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
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
  Velocita: number = 9;
  Dadi_Vita: Array<string> = new Array<string>();
  Saggezza_passiva: number = 10;
  Competenza: number = 0;
  isLoading: boolean = true;

  constructor(
    private route: ActivatedRoute,
    private srvIPers: InfoPersonaggioService,
    private router : Router
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
        this.calcolaCompetenza();
        this.calcolaClasseArmatura();
        this.calcolaVelocita();
        this.saggezzaPassiva();
        this.dadiVita();
        this.isLoading = false;
      });
  }

  calcoloAttribbuto(att: number) {
    var res: string;
    if (att >= 10) {
      res = '+'.concat(Math.floor((att - 10) / 2).toString());
    } else {
      res = (Math.floor((att -10)/2).toString());
    }
    return res;
  }

  calcolaClasseArmatura() {
    if (this.PersonaggioFull.armatura) {
      for (let i = 0; i < this.PersonaggioFull.armatura.length; i++) {
        console.log(this.PersonaggioFull.armatura.length, 'lunghezza array');
        console.log(this.PersonaggioFull.armatura[i]);
        console.log(this.PersonaggioFull.armatura[i].indossato);
        if (this.PersonaggioFull.armatura[i].indossato === true) {
          this.Ca += this.PersonaggioFull.armatura[i].ca;
        }
      }
    }
  }

  calcolaVelocita() {
    if (this.PersonaggioFull.razza) {
      if (this.PersonaggioFull.razza === 'Elfo') this.Velocita += 1.5;
      else if (
        this.PersonaggioFull.razza === 'Nano' ||
        this.PersonaggioFull.razza === 'Gnomo' ||
        this.PersonaggioFull.razza === 'Halfling'
      )
        this.Velocita -= 1.5;
    }
  }

  dadiVita() {
    if (this.PersonaggioFull.classi) {
    ;
    for (let i = 0; i < this.PersonaggioFull.classi.length; i++) {
      if (
        this.PersonaggioFull.classi[i].tipoClasse === 'Mago' ||
        this.PersonaggioFull.classi[i].tipoClasse === 'Stregone'
      ) {
        this.Dadi_Vita.push(
          this.PersonaggioFull.classi[i].livello.toString().concat('d6')
        );
        console.log(
          'entro dentro a dadi vita',
          this.Dadi_Vita)
        } else if (this.PersonaggioFull.classi[i].tipoClasse === 'Barbaro') {
          this.Dadi_Vita.push(
            this.PersonaggioFull.classi[i].livello.toString().concat('d12')
          );
        } else if (
          this.PersonaggioFull.classi[i].tipoClasse === 'Paladino' ||
          this.PersonaggioFull.classi[i].tipoClasse === 'Guerriero' ||
          this.PersonaggioFull.classi[i].tipoClasse === 'Ranger'
        ) {
          this.Dadi_Vita.push(
            this.PersonaggioFull.classi[i].livello.toString().concat('d10')
          );
        } else {
          this.Dadi_Vita.push(
            this.PersonaggioFull.classi[i].livello.toString().concat('d8')
          );
        }
      }
    }
  }

  calcolaCompetenza() {
    if (this.PersonaggioFull.classi![0]) {
      let lvl: number = 0;
        lvl += this.PersonaggioFull.classi![0].livello;


      if (lvl >= 1 && lvl < 4) {
        this.Competenza = 2;
      } else if (lvl >= 4 && lvl <= 8) {
        this.Competenza = 3;
      } else if (lvl >= 9 && lvl <= 12) {
        this.Competenza = 4;
      } else if (lvl >= 13 && lvl <= 16) {
        this.Competenza = 5;
      } else {
        this.Competenza = 6;
      }
    }
  }

  saggezzaPassiva() {
    if (this.PersonaggioFull.attributi) {
      this.Saggezza_passiva += Number(
        this.calcoloAttribbuto(this.PersonaggioFull.attributi.saggezza)
      );

      if (this.PersonaggioFull.abilita?.percezione === true) {
        this.Saggezza_passiva += this.Competenza;
      }
    }
  }

  Inventario = async() => {
    await this.router.navigate(['inventario',this.personaggioId]);
  }

  Armatura = async() => {
    await this.router.navigate(['armatura', this.personaggioId]);
  }

  Arma = async() => {
    await this.router.navigate(['armi', this.personaggioId]);
  }

  Background = async() => {
    await this.router.navigate(['background', this.personaggioId]);
  }
}
