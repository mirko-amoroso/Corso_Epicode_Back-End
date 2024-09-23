import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ModificaPersonaggioComponent } from './modifica-personaggio.component';

const routes: Routes = [{ path: ':personaggioId', component: ModificaPersonaggioComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ModificaPersonaggioRoutingModule { }
