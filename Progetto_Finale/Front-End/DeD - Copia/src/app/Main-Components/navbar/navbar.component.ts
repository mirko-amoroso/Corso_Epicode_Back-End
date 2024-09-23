import { ChangeDetectorRef, Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.scss'
})
export class NavbarComponent {

  constructor(private cdRef: ChangeDetectorRef, private router: Router){}

  public nomeUtente: string = "" ;
  public Loog : boolean = false;


  ngOnInit() {
    if(sessionStorage.getItem("IdUtente")) {
      this.Loog = true
    }
    window.addEventListener("storage", () => {
      this.Loog = true
    })
  }

  Logout = () => {
    sessionStorage.removeItem("IdUtente")
    this.Loog = false
    this.cdRef.detectChanges(); // Forza l'aggiornamento della vista
    this.router.navigate(['home']);
  }
}
