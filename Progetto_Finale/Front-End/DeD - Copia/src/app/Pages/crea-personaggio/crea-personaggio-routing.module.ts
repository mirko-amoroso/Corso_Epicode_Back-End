import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreaPersonaggioComponent } from './crea-personaggio.component';

const routes: Routes = [{ path: '', component: CreaPersonaggioComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CreaPersonaggioRoutingModule { }
