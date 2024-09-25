import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import { InventraioService } from './inventraio.service';
import { Iinventario } from '../../modules/inventario';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-inventario',
  templateUrl: './inventario.component.html',
  styleUrl: './inventario.component.scss',
})
export class InventarioComponent {
  //Form
  inventarioForm!: FormGroup;

  personaggioId: number = 0;
  arrayInventario: Iinventario[] = [];

  inventario : Iinventario = {
    inventarioId: 0,
    personaggioId: 0,
    nome: '',
    effetto: ''
  }

  constructor(
    private route: ActivatedRoute,
    private inventSrv: InventraioService,
    private fb: FormBuilder,
    private router : Router

  ) {}

  ngOnInit() {
    //inizializzaForm
    this.inventarioForm = this.fb.group({
      Nome: this.fb.control(null, [Validators.required]),
      Effetto: this.fb.control(null, [Validators.required]),
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
    this.inventSrv.Inventario(this.personaggioId).subscribe((data) => {
      console.log(data), (this.arrayInventario = data);
    });
    console.log(this.arrayInventario[0]);
  }

  Elimina = (inventarioId: number) => {
    this.inventSrv.EliminaItem(inventarioId).subscribe();
  };

  Aggiungi = () => {
    this.inventario.nome = this.inventarioForm.get("Nome")?.value
    this.inventario.effetto = this.inventarioForm.get("Effetto")?.value
    this.inventario.personaggioId = this.personaggioId
    this.inventSrv.AggiungiItem(this.inventario).subscribe();
    window.location.reload()
  };

  redirect = async() => {
    await this.router.navigate(['infoPersonaggio', this.personaggioId])
  }
}
