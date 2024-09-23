import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonaggiComponent } from './personaggi.component';

const routes: Routes = [{ path: '', component: PersonaggiComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PersonaggiRoutingModule { }
