import { Component } from '@angular/core';
import { IArmatura } from '../../modules/armatura';
import { ArmaturaService } from './armatura.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-armatura',
  templateUrl: './armatura.component.html',
  styleUrl: './armatura.component.scss'
})
export class ArmaturaComponent {

  armaturaForm!: FormGroup;

  personaggioId: number = 0;
  arrayArmatura: IArmatura[] = [];

  armatura : IArmatura = {
    armaturaId: 0,
    personaggioId: 0,
    nome: '',
    ca: 0,
    effetto: '',
    indossato: false
  }

  constructor(
    private route: ActivatedRoute,
    private armaturaSrv: ArmaturaService,
    private fb: FormBuilder,
    private router : Router

  ) {}

  ngOnInit() {
    //inizializzaForm
    this.armaturaForm = this.fb.group({
      Nome: this.fb.control(null, [Validators.required]),
      Ca: this.fb.control(null, [Validators.required]),
      Effetto: this.fb.control(null, [Validators.required]),
      Indossato: this.fb.control(null, [Validators.required]),
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
    this.armaturaSrv.Armatura(this.personaggioId).subscribe((data) => {
      console.log(data), (this.arrayArmatura = data);
    });
    console.log(this.arrayArmatura[0]);
  }

  Elimina = (armaturaId: number) => {
    this.armaturaSrv.EliminaItem(armaturaId).subscribe();
  };

  Aggiungi = () => {
    this.armatura.nome = this.armaturaForm.get("Nome")?.value
    this.armatura.effetto = this.armaturaForm.get("Effetto")?.value
    this.armatura.ca = this.armaturaForm.get("Ca")?.value
    this.armatura.indossato = this.armaturaForm.get("Indossato")?.value ? this.armaturaForm.get("Indossato")?.value : false
    this.armatura.personaggioId = this.personaggioId
    this.armaturaSrv.AggiungiItem(this.armatura).subscribe();
    window.location.reload()
  };

  Modifica = (Item : IArmatura) => {
    Item.indossato = !Item.indossato
    console.log(Item.indossato)
    this.armaturaSrv.ModificaItem(Item).subscribe()
  }

  redirect = async() => {
    await this.router.navigate(['infoPersonaggio', this.personaggioId])
  }

}
