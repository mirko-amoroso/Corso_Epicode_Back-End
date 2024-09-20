import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CreaPersonaggioRoutingModule } from './crea-personaggio-routing.module';
import { CreaPersonaggioComponent } from './crea-personaggio.component';


@NgModule({
  declarations: [
    CreaPersonaggioComponent
  ],
  imports: [
    CommonModule,
    CreaPersonaggioRoutingModule
  ]
})
export class CreaPersonaggioModule { }
