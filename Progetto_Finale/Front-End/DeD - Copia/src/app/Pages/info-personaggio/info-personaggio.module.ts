import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InfoPersonaggioRoutingModule } from './info-personaggio-routing.module';
import { InfoPersonaggioComponent } from './info-personaggio.component';


@NgModule({
  declarations: [
    InfoPersonaggioComponent
  ],
  imports: [
    CommonModule,
    InfoPersonaggioRoutingModule
  ]
})
export class InfoPersonaggioModule { }
