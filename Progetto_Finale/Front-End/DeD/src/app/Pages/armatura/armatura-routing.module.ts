import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArmaturaComponent } from './armatura.component';

const routes: Routes = [{ path: ':personaggioId', component: ArmaturaComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ArmaturaRoutingModule { }
