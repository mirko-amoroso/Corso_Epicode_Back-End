import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PersonaggiRoutingModule } from './personaggi-routing.module';
import { PersonaggiComponent } from './personaggi.component';


@NgModule({
  declarations: [
    PersonaggiComponent
  ],
  imports: [
    CommonModule,
    PersonaggiRoutingModule
  ]
})
export class PersonaggiModule { }
