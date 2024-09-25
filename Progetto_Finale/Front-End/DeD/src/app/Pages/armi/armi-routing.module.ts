import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArmiComponent } from './armi.component';

const routes: Routes = [{ path: ':personaggioId', component: ArmiComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ArmiRoutingModule { }
