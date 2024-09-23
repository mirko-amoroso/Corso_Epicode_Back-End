import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'DeD';

  // showFooter = true;

  // // Liste delle rotte dove il footer non deve essere mostrato
  // hiddenFooterRoutes: string[] = ['/login', '/register', '/infoPersonaggio'];

  // constructor(private router: Router) {
  //   this.router.events.subscribe((event: any) => {
  //     if (event.url) {
  //       this.showFooter = !this.hiddenFooterRoutes.includes(event.url);
  //     }
  //   });
  // }
}
