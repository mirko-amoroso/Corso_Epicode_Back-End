import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full',
  },
  {
    path: 'home',
    loadChildren: () => import('./home/home.module').then((m) => m.HomeModule),
  },
  {
    path: 'login',
    loadChildren: () =>
      import('./Auth/login/login.module').then((m) => m.LoginModule),
  },
  {
    path: 'register',
    loadChildren: () =>
      import('./Auth/register/register.module').then((m) => m.RegisterModule),
  },
  {
    path: 'personaggi',
    loadChildren: () =>
      import('./Pages/personaggi/personaggi.module').then(
        (m) => m.PersonaggiModule
      ),
  },
  {
    path: 'creaPersonaggio',
    loadChildren: () =>
      import('./Pages/crea-personaggio/crea-personaggio.module').then(
        (m) => m.CreaPersonaggioModule
      ),
  },
  {
    path: 'infoPersonaggio',
    loadChildren: () =>
      import('./Pages/info-personaggio/info-personaggio.module').then(
        (m) => m.InfoPersonaggioModule
      ),
  },
  {
    path: 'modificaPersonaggio',
    loadChildren: () =>
      import('./Pages/modifica-personaggio/modifica-personaggio.module').then(
        (m) => m.ModificaPersonaggioModule
      ),
  },
  {
    path: 'inventario',
    loadChildren: () =>
      import('./Pages/inventario/inventario.module').then(
        (m) => m.InventarioModule
      ),
  },
  {
    path: 'armatura',
    loadChildren: () =>
      import('./Pages/armatura/armatura.module').then((m) => m.ArmaturaModule),
  },
  {
    path: 'armi',
    loadChildren: () =>
      import('./Pages/armi/armi.module').then((m) => m.ArmiModule),
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
