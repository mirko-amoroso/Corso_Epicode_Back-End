import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CreaPersonaggioRoutingModule } from './crea-personaggio-routing.module';
import { CreaPersonaggioComponent } from './crea-personaggio.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    CreaPersonaggioComponent
  ],
  imports: [
    CommonModule,
    CreaPersonaggioRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class CreaPersonaggioModule { }
