
import { Component } from '@angular/core';
import { ICredenziali } from '../../modules/credenziali';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginService } from './login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss',
})
export class LoginComponent {
  form!: FormGroup;

  constructor(private loginService: LoginService, private fb: FormBuilder) {}

  ngOnInit() {
    this.form = this.fb.group({
      email: this.fb.control(null, [Validators.required, Validators.email]),
      password: this.fb.control(null, [Validators.required]),
    });
  }

  OnLogin = () => {
    if (this.form.valid) {
      const credenziali: ICredenziali = this.form.value;
      console.log(credenziali)
      this.loginService.Login(credenziali).subscribe((data)=>{
        console.log(data)
        sessionStorage.setItem('IdUtente', data.utenteId)
        console.log('Login riuscito')})

    //  ,error => {
    //   console.error("Errore nel login", error);
    // });
  } else {
    console.error("Il modulo non è valido");
  }
    }
  };
