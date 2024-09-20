import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InfoPersonaggioComponent } from './info-personaggio.component';

const routes: Routes = [{ path: ':personaggioId', component: InfoPersonaggioComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InfoPersonaggioRoutingModule { }
