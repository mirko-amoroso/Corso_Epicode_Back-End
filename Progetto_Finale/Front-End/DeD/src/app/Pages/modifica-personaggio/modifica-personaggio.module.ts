import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ModificaPersonaggioRoutingModule } from './modifica-personaggio-routing.module';
import { ModificaPersonaggioComponent } from './modifica-personaggio.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ModificaPersonaggioComponent
  ],
  imports: [
    CommonModule,
    ModificaPersonaggioRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class ModificaPersonaggioModule { }
