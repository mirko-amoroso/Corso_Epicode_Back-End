import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CarouselComponent } from './carousel.component';

@NgModule({
  declarations: [
    CarouselComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    CarouselComponent
  ]
})
export class CarouselModule { }