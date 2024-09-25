import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginService } from '../login/login.service';
import { INewCredenziali } from '../../modules/new-credenziali';
import { RegisterService } from './register.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss',
})
export class RegisterComponent {
  userForm!: FormGroup;
  constructor(
    private registerService: RegisterService,
    private fb: FormBuilder,
    private router: Router
  ) {}

  ngOnInit() {
    this.userForm = this.fb.group({
      email: this.fb.control(null, [Validators.required, Validators.email]),
      password: this.fb.control(null, [Validators.required]),
      NomeUtente: this.fb.control(null, [Validators.required]),
    });
  }

  OnRegister = async () => {
    console.log("Funzione OnRegister chiamata");
    if (this.userForm.valid) {
      const NuoveCredenziali: INewCredenziali = this.userForm.value;
      console.log(NuoveCredenziali);
      await this.registerService.Register(NuoveCredenziali).subscribe()
      await this.redirect()
    };
  }
  redirect = async() =>{
   await this.router.navigate(['login']);
  }
}
