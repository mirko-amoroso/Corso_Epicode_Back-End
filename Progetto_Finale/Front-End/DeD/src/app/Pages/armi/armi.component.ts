import { Component } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Iinventario } from '../../modules/inventario';
import { IArmi } from '../../modules/armi';
import { ArmiService } from './armi.service';

@Component({
  selector: 'app-armi',
  templateUrl: './armi.component.html',
  styleUrl: './armi.component.scss'
})
export class ArmiComponent {

  armiForm!: FormGroup;

  personaggioId: number = 0;
  arrayArmi: IArmi[] = [];

  armi : IArmi = {
    armaId: 0,
    personaggioId: 0,
    nome: '',
    danno: 0,
    bonusArma: ''
  }

  constructor(
    private route: ActivatedRoute,
    private armiSrv: ArmiService,
    private fb: FormBuilder,
    private  router: Router
  ) {}

  ngOnInit() {
    //inizializzaForm
    this.armiForm = this.fb.group({
      Nome: this.fb.control(null, [Validators.required]),
      Danno: this.fb.control(null, [Validators.required]),
      BonusArma: this.fb.control(null, [Validators.required])
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
    this.armiSrv.Armi(this.personaggioId).subscribe((data) => {
      console.log(data), (this.arrayArmi = data);
    });
  }

  Elimina = (inventarioId: number) => {
    this.armiSrv.EliminaItem(inventarioId).subscribe();
  };

  Aggiungi = () => {
    this.armi.nome = this.armiForm.get("Nome")?.value
    this.armi.danno = this.armiForm.get("Danno")?.value
    this.armi.bonusArma = this.armiForm.get("BonusArma")?.value
    this.armi.personaggioId = this.personaggioId
    this.armiSrv.AggiungiItem(this.armi).subscribe();
    window.location.reload()
  };

  redirect = async() => {
    await this.router.navigate(['infoPersonaggio', this.personaggioId])
  }
}
