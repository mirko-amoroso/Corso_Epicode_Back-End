import { ChangeDetectorRef, Component } from '@angular/core';
import { ICredenziali } from '../../modules/credenziali';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginService } from './login.service';
import { Router } from '@angular/router';
import { timeInterval, timeout } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrl: './login.component.scss',
})
export class LoginComponent {
  form!: FormGroup;

  constructor(
    private loginService: LoginService,
    private fb: FormBuilder,
    private cdRef: ChangeDetectorRef,
    private router: Router
  ) {}

  ngOnInit() {
    this.form = this.fb.group({
      email: this.fb.control(null, [Validators.required, Validators.email]),
      password: this.fb.control(null, [Validators.required]),
    });
  }

  OnLogin = async () => {
    if (this.form.valid) {
      const credenziali: ICredenziali = this.form.value;
      console.log(credenziali);
      (await this.loginService.Login(credenziali)).subscribe((data) => {
        console.log(data);
        sessionStorage.setItem('IdUtente', data.utenteId);
        console.log('Login riuscito');
        window.location.reload();
      });
      this.router.navigate(['home']);

    } else {
      console.error('Il modulo non è valido');
    }
  };
}
