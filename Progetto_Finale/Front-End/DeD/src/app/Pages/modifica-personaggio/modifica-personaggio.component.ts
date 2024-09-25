import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { InfoPersonaggioService } from '../info-personaggio/info-personaggio.service';
import { IPersonaggio } from '../../modules/personaggio';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { IAttributi } from '../../modules/attributi';
import { ModificaPersonaggioService } from './modifica-personaggio.service';
import { IAttributiModifica } from '../../modules/attributiModifica';
import { IPersonaggioModifica } from '../../modules/PersonaggioModifica';

@Component({
  selector: 'app-modifica-personaggio',
  templateUrl: './modifica-personaggio.component.html',
  styleUrl: './modifica-personaggio.component.scss',
})
export class ModificaPersonaggioComponent {
  //form
  nomeForm!: FormGroup;
  allineamentoForm!: FormGroup;
  livelloForm!: FormGroup;

  personaggioId!: number;
  PersonaggioFull!: IPersonaggioModifica;
  isLoading: boolean = true;
  selectedValue: string | null = null;
  Mo: number = 0;
  attributi: IAttributiModifica = {
    personaggioID: 0,
    attributiId: 0,
    forza: 0,
    destrezza: 0,
    costituzione: 0,
    saggezza: 0,
    intelligenza: 0,
    carisma: 0,
    pv: 0,
  };

  Allineamenti: string[] = [
    'Legale Buono',
    'Buono',
    'Neutrale Buono',
    'Caotico Buono',
    'Neutrale Caotico',
    'Neutrale',
    'Legame Neutrale',
    'Neutrale Malvagio',
    'Caotico Malvagio',
    'Malvagio',
    'Legale Malvagio',
  ];

  constructor(
    private route: ActivatedRoute,
    private srvModPers: ModificaPersonaggioService,
    private fb: FormBuilder,
    private router : Router
  ) {}

  ngOnInit() {
    //form
    this.nomeForm = this.fb.group({
      Nome: this.fb.control(null, [Validators.required]),
    });

    this.allineamentoForm = this.fb.group({
      allineamento: this.fb.control(null, [Validators.required]),
    });

    this.livelloForm = this.fb.group({
      livello: this.fb.control(null, [Validators.required]),
    });

    this.route.paramMap.subscribe((params) => {
      const id = params.get('personaggioId');
      if (id) {
        this.personaggioId = Number(id);
        console.log('ID del personaggio ricevuto:', this.personaggioId);
      } else {
        console.error('Parametro personaggioId non trovato!');
      }
    });
    this.srvModPers
      .personaggioCompleto(this.personaggioId)
      .subscribe((data: IPersonaggioModifica) => {
        this.PersonaggioFull = data;
        console.log(this.PersonaggioFull);
        //mette il nome allinterno dell'input Nome
        this.nomeForm.patchValue({
          Nome: this.PersonaggioFull.nome,
        });

        // mette l'allineamento allinterno della select allineamento
        this.allineamentoForm.patchValue({
          allineamento: this.PersonaggioFull.backgound?.allineamento,
        });

        // mette livello allinterno della select livello
        this.livelloForm.patchValue({
          livello: this.PersonaggioFull.classi![0].livello,
        });
        this.Mo = this.PersonaggioFull.moneteOro!;
        this.attributi = this.PersonaggioFull.attributi!;
        console.log('console log di this.attributi', this.attributi);
        this.isLoading = false;
      });
  }

  calcoloAttribbuto(att: number) {
    var res: string;
    if (att >= 10) {
      res = '+'.concat(Math.floor((att - 10) / 2).toString());
    } else {
      res = Math.floor((att - 10) / 2).toString();
    }
    return res;
  }
  FunzioneMeno = (nomeAtt: string) => {
    switch (nomeAtt) {
      case 'F':
        this.attributi.forza -= 1;
        break;
      case 'D':
        this.attributi.destrezza -= 1;
        break;
      case 'CO':
        this.attributi.costituzione -= 1;
        break;
      case 'S':
        this.attributi.saggezza -= 1;
        break;
      case 'I':
        this.attributi.intelligenza -= 1;
        break;
      case 'CA':
        this.attributi.carisma -= 1;
        break;
      case 'MO':
        this.Mo -= 1;
        break;
    }
  };
  FunzionePiu = (nomeAtt: string) => {
    switch (nomeAtt) {
      case 'F':
        this.attributi.forza += 1;
        break;
      case 'D':
        this.attributi.destrezza += 1;
        break;
      case 'CO':
        this.attributi.costituzione += 1;
        break;
      case 'S':
        this.attributi.saggezza += 1;
        break;
      case 'I':
        this.attributi.intelligenza += 1;
        break;
      case 'CA':
        this.attributi.carisma += 1;
        break;
      case 'MO':
        this.Mo += 1;
        break;
    }
  };

  calcoloPv() {
    if (
      this.livelloForm.get('livello')?.value !==
      this.PersonaggioFull.classi![0].livello
    ) {
      this.PersonaggioFull.classi![0].livello += 1;
      var classe = this.PersonaggioFull.classi![0].tipoClasse;
      if (
        classe === 'Paldino' ||
        classe === 'Guerriero' ||
        classe === 'Ranger'
      ) {
        const numero = Math.floor(Math.random() * 10) + 1;
        this.attributi.pv +=
          numero + Number(this.calcoloAttribbuto(this.attributi.costituzione));
      } else if (classe === 'Mago' || classe === 'Stregone') {
        const numero = Math.floor(Math.random() * 6) + 1;
        this.attributi.pv +=
          numero + Number(this.calcoloAttribbuto(this.attributi.costituzione));
      } else if (classe === 'Barbaro') {
        const numero = Math.floor(Math.random() * 12) + 1;
        this.attributi.pv +=
          numero + Number(this.calcoloAttribbuto(this.attributi.costituzione));
      } else {
        const numero = Math.floor(Math.random() * 8) + 1;
        this.attributi.pv +=
          numero + Number(this.calcoloAttribbuto(this.attributi.costituzione));
      }
    } else {
      alert('Devi salire di livello per calcolare i punti ferita!');
    }
  }

  SalvaTutto = async () => {
    await this.SalvaAttributi();
    await this.SalvaAllineamento();
    await this.SalvaNome();
    await this.SalvaLivello();
    await this.redirect()
  };

  SalvaAttributi = async () => {
    console.log('primo log this.attributi', this.attributi);
    console.log(
      'secondo log this.personaggio.full.attributi',
      this.PersonaggioFull.attributi
    );
    console.log('entro dentro salva attributi');
    this.srvModPers.PutAttributi(this.attributi).subscribe();
  };
  SalvaAllineamento = async () => {
    if (
      this.allineamentoForm.get('allineamento')?.value !==
      this.PersonaggioFull.backgound?.allineamento
    ) {
      this.PersonaggioFull.backgound!.allineamento =
        this.allineamentoForm.get('allineamento')?.value;

      console.log(
        'entro dentro a salvaAllineamento',
        this.PersonaggioFull.backgound
      );
      this.srvModPers
        .PutAllineamento(this.PersonaggioFull.backgound!)
        .subscribe();
    }
  };
  SalvaNome = async () => {
    if (
      this.nomeForm.get('Nome')?.value !== this.PersonaggioFull.nome ||
      this.Mo !== this.PersonaggioFull.moneteOro
    ) {
      this.PersonaggioFull.nome = this.nomeForm.get('Nome')?.value;
      this.PersonaggioFull.moneteOro = this.Mo;
      this.srvModPers.PutPersonaggio(this.PersonaggioFull).subscribe();
    }
  };

  SalvaLivello = async () => {
    {
      this.PersonaggioFull.classi![0].livello =
        this.livelloForm.get('livello')?.value;
      console.log(
        'entro dentro salva livello',
        this.PersonaggioFull.classi![0].livello
      );
      this.srvModPers.PutClasse(this.PersonaggioFull.classi![0]).subscribe();
    }
  };

  redirect = async () => {
    await this.router.navigate(['infoPersonaggio', this.personaggioId]);
  }
}
