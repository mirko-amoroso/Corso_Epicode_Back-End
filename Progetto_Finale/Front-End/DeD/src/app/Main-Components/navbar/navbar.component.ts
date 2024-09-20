import { Component, NgModule } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss'
})
export class NavbarComponent {

  constructor( ){}

  public nomeUtente: string = "" ;

  ngOnInit() {
    var Loggato = sessionStorage.getItem("IdUtente")
    if (Loggato)
    {

    }
  }
}
