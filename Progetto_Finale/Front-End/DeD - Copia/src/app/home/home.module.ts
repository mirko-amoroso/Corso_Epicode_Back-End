import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { FooterModule } from '../Main-Components/footer/footer.module';
import { CarouselModule } from '../carousel/carousel.module';


@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    HomeRoutingModule,
    FooterModule,
    CarouselModule

  ]
})
export class HomeModule { }
