import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ArmiRoutingModule } from './armi-routing.module';
import { ArmiComponent } from './armi.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    ArmiComponent
  ],
  imports: [
    CommonModule,
    ArmiRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class ArmiModule { }
