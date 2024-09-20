import { Component, NgModule } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-crea-personaggio',
  templateUrl: './crea-personaggio.component.html',
  styleUrl: './crea-personaggio.component.scss',
})
export class CreaPersonaggioComponent {
  personaggioForm!: FormGroup;
  classiForm!: FormGroup;
  backGorundForm!: FormGroup;
  abilitaForm!: FormGroup;
  attributiForm!: FormGroup;
  tiriSalvezzaForm!: FormGroup;

  contatore: number = 0;

  constructor(private fb: FormBuilder) {}

  ngOnInit() {
    this.personaggioForm = this.fb.group({
      Nome: this.fb.control(null, [Validators.required]),
      Razza: this.fb.control(null, [Validators.required]),
    });

    this.classiForm = this.fb.group({
      TipoClasse: this.fb.control(null, [Validators.required]),
      // Livello: this.fb.control(null, [Validators.required]),
    });

    this.backGorundForm = this.fb.group({
      TrattiCartteriali: this.fb.control(null, [Validators.required]),
      Ideali: this.fb.control(null, [Validators.required]),
      Legami: this.fb.control(null, [Validators.required]),
      Difetti: this.fb.control(null, [Validators.required]),
      Allineamento: this.fb.control(null, [Validators.required]),
    });

    this.attributiForm = this.fb.group({
      Forza: this.fb.control(null, [Validators.required]),
      Destrezza: this.fb.control(null, [Validators.required]),
      Cosituzione: this.fb.control(null, [Validators.required]),
      Saggezza: this.fb.control(null, [Validators.required]),
      Intelligenza: this.fb.control(null, [Validators.required]),
      Carisma: this.fb.control(null, [Validators.required]),
    });

    this.abilitaForm = this.fb.group({
      Acrobazia: this.fb.control(null, [Validators.required]),
      Addestrare_Animali: this.fb.control(null, [Validators.required]),
      Arcano: this.fb.control(null, [Validators.required]),
      Atletica: this.fb.control(null, [Validators.required]),
      Furtivita: this.fb.control(null, [Validators.required]),
      Indagare: this.fb.control(null, [Validators.required]),
      Inganno: this.fb.control(null, [Validators.required]),
      Intimidire: this.fb.control(null, [Validators.required]),
      Intrattenere: this.fb.control(null, [Validators.required]),
      Intuizione: this.fb.control(null, [Validators.required]),
      Medicina: this.fb.control(null, [Validators.required]),
      Natura: this.fb.control(null, [Validators.required]),
      Percezione: this.fb.control(null, [Validators.required]),
      Persuasione: this.fb.control(null, [Validators.required]),
      Rapidita_di_Mano: this.fb.control(null, [Validators.required]),
      Religione: this.fb.control(null, [Validators.required]),
      Sopravvivenza: this.fb.control(null, [Validators.required]),
      Storia: this.fb.control(null, [Validators.required]),
    });

    this.tiriSalvezzaForm = this.fb.group({
      Forza: this.fb.control(null, [Validators.required]),
      Destrezza: this.fb.control(null, [Validators.required]),
      Cosituzione: this.fb.control(null, [Validators.required]),
      Saggezza: this.fb.control(null, [Validators.required]),
      Intelligenza: this.fb.control(null, [Validators.required]),
      Carisma: this.fb.control(null, [Validators.required]),
    });


  }

  continua() {
    this.contatore += 1;
  }
}
