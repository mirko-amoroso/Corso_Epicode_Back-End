import { IPersonaggio } from './../../modules/personaggio';
import { IAttributi } from './../../modules/attributi';
import { Component, NgModule } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreaPersonaggioService } from './crea-personaggio.service';
import { IClassi } from '../../modules/classi';
import { IAbilita } from '../../modules/abilita';
import { IBackground } from '../../modules/background';
import BackgroundArray from '../../modules/backgrounds';
import { Router } from '@angular/router';

@Component({
  selector: 'app-crea-personaggio',
  templateUrl: './crea-personaggio.component.html',
  styleUrl: './crea-personaggio.component.scss',
})
export class CreaPersonaggioComponent {
  personaggioForm!: FormGroup;
  classiForm!: FormGroup;
  abilitaForm!: FormGroup;
  attributiForm!: FormGroup;
  tiriSalvezzaForm!: FormGroup;
  backgroundSceltaForm!: FormGroup;

  //Per attributi
  valore: number[] = [];
  valore_dado: number[] = [0];
  valore_dado_copia: number[] = [0];
  selectedValue: string | null = null;

  //Per il Salva
  IdUtente = Number(sessionStorage.getItem('IdUtente'));

  //Id Personaggio per salvare
  IdPersonaggio: number = 0;

  attributi: IAttributi = {
    attributiID: 0, // Assicurati di impostare un valore di default
    forza: 0, // Valore di esempio
    destrezza: 0, // Valore di esempio
    costituzione: 0, // Valore di esempio
    saggezza: 0, // Valore di esempio
    intelligenza: 0, // Valore di esempio
    carisma: 0, // Valore di esempio
    pv: 0,
  };

  background: IBackground = {
    backgroundId: 0,
    trattiCaratteriali: '',
    ideali: '',
    legami: '',
    difetti: '',
    allineamento: '',
    backGround: '',
  };

  contatore: number = 0;

  constructor(
    private fb: FormBuilder,
    private CreaPerSrv: CreaPersonaggioService,
    private router: Router
  ) {}

  ngOnInit() {
    this.personaggioForm = this.fb.group({
      Nome: this.fb.control(null, [Validators.required]),
      Razza: this.fb.control(null, [Validators.required]),
    });

    this.classiForm = this.fb.group({
      TipoClasse: this.fb.control(null, [Validators.required]),
    });

    this.backgroundSceltaForm = this.fb.group({
      Background: this.fb.control(null, [Validators.required]),
    });

    this.attributiForm = this.fb.group({
      Forza: this.fb.control(null, [Validators.required]),
      Destrezza: this.fb.control(null, [Validators.required]),
      Costituzione: this.fb.control(null, [Validators.required]),
      Saggezza: this.fb.control(null, [Validators.required]),
      Intelligenza: this.fb.control(null, [Validators.required]),
      Carisma: this.fb.control(null, [Validators.required]),
    });

    this.abilitaForm = this.fb.group({
      Acrobazia: this.fb.control(false),
      Addestrare_Animali: this.fb.control(false),
      Arcano: this.fb.control(false),
      Atletica: this.fb.control(false),
      Furtivita: this.fb.control(false),
      Indagare: this.fb.control(false),
      Inganno: this.fb.control(false),
      Intimidire: this.fb.control(false),
      Intrattenere: this.fb.control(false),
      Intuizione: this.fb.control(false),
      Medicina: this.fb.control(false),
      Natura: this.fb.control(false),
      Percezione: this.fb.control(false),
      Persuasione: this.fb.control(false),
      Rapidita_di_Mano: this.fb.control(false),
      Religione: this.fb.control(false),
      Sopravvivenza: this.fb.control(false),
      Storia: this.fb.control(false),
    });
  }

  continua() {
    this.contatore += 1;
    if (this.contatore === 3) {
      if (this.backgroundSceltaForm.valid) {
        this.SceltaBackground();
        console.log(this.background.difetti)
      }
    }
  }

  //FUNZIONE CHE PERMETTE DI TIRARE UN DADO RANDOM
  rollDice() {
    this.valore = [];

    for (let i = 1; i <= 4; i++) {
      const numero = Math.floor(Math.random() * 5) + 2;
      this.valore.push(numero);
    }
    const valoreAttributo = this.creaAttributo();
    this.valore_dado.push(valoreAttributo);
    this.valore_dado_copia.push(valoreAttributo);
    console.log('Risultato dei dadi:', this.valore);
    console.log('Valore attributo:', valoreAttributo);
    console.log('lunghezza:', this.valore_dado.length);
  }

  //Calcolo Punti Ferita
  calcoloPv() {
    var classe = this.classiForm.get('TipoClasse')?.value;
    if (classe === 'Paldino' || classe === 'Guerriero' || classe === 'Ranger') {
      const numero = Math.floor(Math.random() * 10) + 1;
      this.attributi.pv =
        numero + Number(this.calcoloAttribbuto(this.attributi.costituzione));
    } else if (classe === 'Mago' || classe === 'Stregone') {
      const numero = Math.floor(Math.random() * 6) + 1;
      this.attributi.pv =
        numero + Number(this.calcoloAttribbuto(this.attributi.costituzione));
    } else if (classe === 'Barbaro') {
      const numero = Math.floor(Math.random() * 12) + 1;
      this.attributi.pv =
        numero + Number(this.calcoloAttribbuto(this.attributi.costituzione));
      console.log('ciao', classe, numero, this.attributi.pv);
    } else {
      const numero = Math.floor(Math.random() * 8) + 1;
      this.attributi.pv =
        numero + Number(this.calcoloAttribbuto(this.attributi.costituzione));
    }
  }

  //Resetta l'inseriment dei dati in attributi
  reset() {
    this.valore_dado = this.valore_dado_copia.slice();
    this.attributi = {
      attributiID: 0, // Assicurati di impostare un valore di default
      forza: 0, // Valore di esempio
      destrezza: 0, // Valore di esempio
      costituzione: 0, // Valore di esempio
      saggezza: 0, // Valore di esempio
      intelligenza: 0, // Valore di esempio
      carisma: 0, // Valore di esempio
      pv: 0,
    };
    this.selectedValue = null;
    console.log(this.valore_dado);
    console.log(this.valore_dado_copia);
  }

  //rimuovi i dati dall'array attributi
  rimuovi(e: Event, attributo: string) {
    const value = (e.target as HTMLSelectElement).value;
    console.log('valore value', value);
    switch (attributo) {
      case 'Forza':
        this.attributi.forza = Number(value);
        break;
      case 'Destrezza':
        this.attributi.destrezza = Number(value);
        break;
      case 'Costituzione':
        this.attributi.costituzione = Number(value);
        break;
      case 'Saggezza':
        this.attributi.saggezza = Number(value);
        break;
      case 'Intelligenza':
        this.attributi.intelligenza = Number(value);
        break;
      case 'Carisma':
        this.attributi.carisma = Number(value);
        break;
    }
    var index = this.valore_dado.indexOf(Number(value));
    this.valore_dado.splice(index, 1);
  }

  //ausiliare a creare il valore di attributi
  creaAttributo() {
    var valoreMin = Math.min(...this.valore);
    console.log(valoreMin);
    var index = this.valore.indexOf(valoreMin);
    console.log(this.valore);
    this.valore[index] = 0;
    return this.valore.reduce(
      (accumulator, currentValue) => accumulator + currentValue,
      0
    );
  }

  // calcola il modificatore in attributi
  calcoloAttribbuto(att: number) {
    var res: string;
    if (att >= 10) {
      res = '+'.concat(Math.floor((att - 10) / 2).toString());
    } else {
      res = '-'.concat(Math.floor(att - 2).toString());
    }
    return res;
  }

  //funzione per il background
  SceltaBackground = () => {
    this.background.backGround = this.backgroundSceltaForm.get('Background')?.value
    for (let i = 0; i < BackgroundArray.length; i++) {
      if (
        this.background.backGround === BackgroundArray[i].nome
      ) {
        let numeroDifetti = Math.floor(Math.random() * 6) + 1;
        this.background.difetti = BackgroundArray[i].difetti[numeroDifetti];
        let numeroLegami = Math.floor(Math.random() * 6) + 1;
        this.background.legami = BackgroundArray[i].legami[numeroLegami];
        let numeroIdeali = Math.floor(Math.random() * 6) + 1;
        this.background.ideali = BackgroundArray[i].ideali[numeroIdeali];
        let numeroTratti =
          Math.floor(
            Math.random() * BackgroundArray[i].tratti_caratteriali!.length
          ) + 1;
        this.background.trattiCaratteriali =
          BackgroundArray[i].tratti_caratteriali![numeroTratti];
      }
    }
    console.log(this.background.trattiCaratteriali);
  };

  //funzione che richiama tutte le funzioni di salvataggio
  Salva = async () => {
    await this.SalvaPersonaggio();
    await this.SalvaClasse();
    await this.SalvaBackground();
    await this.SalvaAttributi();
    await this.SalvaAbilita();
    this.router.navigate(['infoPersonaggio', this.IdPersonaggio]);
  };

  //Salva Personaggio
  SalvaPersonaggio = async () => {
    var NewPersonaggio: IPersonaggio = {
      personaggioID: null,
      idUtente: Number(this.IdUtente),
      nome: this.personaggioForm.get('Nome')?.value,
      utente: null,
      razza: this.personaggioForm.get('Razza')?.value,
      moneteOro: null,
      armi: null,
      armatura: null,
      inventario: undefined,
      abilita: null,
      attributi: null,
      backgound: null,
      classi: null,
      tiri_Salvezza: null,
    };
    this.CreaPerSrv.CreaPers(NewPersonaggio);
    this.IdPersonaggio = Number(
      this.CreaPerSrv.Personaggioid(this.IdUtente).subscribe(
        (data: IPersonaggio) => {
          data.personaggioID;
        }
      )
    );
  };

  //Salva Classe
  SalvaClasse = async () => {
    var classe: IClassi = {
      classiId: 0,
      livello: 1,
      tipoClasse: this.classiForm.get('TipoClasse')?.value,
      personaggioId: Number(this.IdPersonaggio),
    };
    this.CreaPerSrv.CreaClasse(classe);
  };

  //Salva Background
  SalvaBackground = async () => {
    this.CreaPerSrv.CreaBackground(this.background);
  };

  //Salva Attributi
  SalvaAttributi = async () => {
    this.CreaPerSrv.CreaAttributi(this.attributi);
  };

  //Funzione che salva le abilità
  SalvaAbilita = async () => {
    var Abilita: IAbilita = {
      personaggioID: this.IdPersonaggio,
      acrobazia: this.abilitaForm.get('Acrobazia')?.value,
      addestrare_Animali: this.abilitaForm.get('Addestrare_Animali')?.value,
      arcano: this.abilitaForm.get('Arcano')?.value,
      atletica: this.abilitaForm.get('Atletica')?.value,
      furtivita: this.abilitaForm.get('Furtivita')?.value,
      indagare: this.abilitaForm.get('Indagare')?.value,
      inganno: this.abilitaForm.get('Inganno')?.value,
      intimidire: this.abilitaForm.get('Intimidire')?.value,
      intrattenere: this.abilitaForm.get('Intrattenere')?.value,
      intuizione: this.abilitaForm.get('Intuizione')?.value,
      medicina: this.abilitaForm.get('Medicina')?.value,
      natura: this.abilitaForm.get('Natura')?.value,
      percezione: this.abilitaForm.get('Percezione')?.value,
      persuasione: this.abilitaForm.get('Persuasione')?.value,
      rapidita_di_Mano: this.abilitaForm.get('Rapidita_di_Mano')?.value,
      religione: this.abilitaForm.get('Religione')?.value,
      sopravvivenza: this.abilitaForm.get('Sopravvivenza')?.value,
      storia: this.abilitaForm.get('Storia')?.value,
      abilitaId: 0,
    };
    this.CreaPerSrv.CreaAbilita(Abilita);
  };
}
