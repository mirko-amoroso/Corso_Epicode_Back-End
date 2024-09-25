import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ArmaturaRoutingModule } from './armatura-routing.module';
import { ArmaturaComponent } from './armatura.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ArmaturaComponent
  ],
  imports: [
    CommonModule,
    ArmaturaRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class ArmaturaModule { }
