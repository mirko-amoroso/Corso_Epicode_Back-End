import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BackgroundComponent } from './background.component';
import { BackgroundRoutingModule } from './background-routing.module';


@NgModule({
  declarations: [
    BackgroundComponent
  ],
  imports: [
    CommonModule,
    BackgroundRoutingModule
  ]
})
export class BackgroundModule { }
