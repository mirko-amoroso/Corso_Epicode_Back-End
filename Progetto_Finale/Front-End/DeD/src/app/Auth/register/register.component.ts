import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginService } from '../login/login.service';
import { INewCredenziali } from '../../modules/new-credenziali';
import { RegisterService } from './register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss',
})
export class RegisterComponent {
  userForm!: FormGroup;
  constructor(
    private registerService: RegisterService,
    private fb: FormBuilder
  ) {}

  ngOnInit() {
    this.userForm = this.fb.group({
      email: this.fb.control(null, [Validators.required, Validators.email]),
      password: this.fb.control(null, [Validators.required]),
      NomeUtente: this.fb.control(null, [Validators.required]),
    });
  }

  OnRegister = () => {
    console.log("Funzione OnRegister chiamata");
    if (this.userForm.valid) {
      const NuoveCredenziali: INewCredenziali = this.userForm.value;
      console.log(NuoveCredenziali);
      this.registerService.Register(NuoveCredenziali).subscribe()
  };
}
}
