import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormBuilder, FormControl, Validators, ReactiveFormsModule, FormsModule } from '@angular/forms';
import { AppUser } from './models/app-user.model';
import { AccountService } from './services/account.service';
import { Login } from './models/login.model';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [FormsModule,ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
[x: string]: any;
  accountService = inject(AccountService);
  fB = inject(FormBuilder);

  receivedUser: AppUser | undefined;
  receivedUsers: AppUser[] | undefined;
  errorMessage: string = '';

  registerFg = this.fB.group({
    emailCtrl: ['', [Validators.required, Validators.email]],
    nameCtrl: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],
    passwordCtrl: [],
    confirmPasswordCtrl: [],
    ageCtrl: ['', [Validators.required, Validators.min(18), Validators.max(80)]],
    genderCtrl: [],
    cityCtrl: [],
    countryCtrl: []
  });

  get EmailCtrl(): FormControl {
    return this.registerFg.get('emailCtrl') as FormControl;
  }

  get NameCtrl(): FormControl {
    return this.registerFg.get('nameCtrl') as FormControl;
  }

  get PasswordCtrl(): FormControl {
    return this.registerFg.get('passwordCtrl') as FormControl;
  }

  get ConfirmPasswordCtrl(): FormControl {
    return this.registerFg.get('confirmPasswordCtrl') as FormControl;
  }

  get AgeCtrl(): FormControl {
    return this.registerFg.get('ageCtrl') as FormControl;
  }

  get GenderCtrl(): FormControl {
    return this.registerFg.get('genderCtrl') as FormControl;
  }

  get CityCtrl(): FormControl {
    return this.registerFg.get('cityCtrl') as FormControl;
  }

  get CountryCtrl(): FormControl {
    return this.registerFg.get('countryCtrl') as FormControl;
  }


  create(): void {
    let appUser: AppUser = {
      email: this.EmailCtrl.value,
      name: this.NameCtrl.value,
      password: this.PasswordCtrl.value,
      confirmPassword: this.ConfirmPasswordCtrl.value,
      age: this.AgeCtrl.value,
      gender: this.GenderCtrl.value,
      city: this.CityCtrl.value,
      country: this.CountryCtrl.value
    }

    this.accountService.register(appUser).subscribe({
            next: (res) => console.log(res),
            error: (err) => console.log(err.error)
          });
  }


  login(): void {
    let userInput: Login = {
      email: this.EmailCtrl.value,
      password: this.PasswordCtrl.value
    }

    this.accountService.login(userInput).subscribe();
  // }

  // getAll(): void {
  //   this.http.get<AppUser[]>('http://localhost:5000/api/user').subscribe({
  //     next: (response: AppUser[]) => (this.receivedUsers = response, console.log(response))
  //   });
  // }

  // getByUserName(): void {
  //   this.http.get<AppUser>('http://localhost:5000/api/user/get-by-username/aaa').subscribe({
  //     next: (response: AppUser) => (this.receivedUser = response, console.log(response)),
  //     error: (errMessage) => (this.errorMessage = errMessage.error, console.log(errMessage.error))
  //   });
  // }

  // update(): void {
  //   let appUser: AppUser = {
  //     email: this.EmailCtrl.value,
  //     name: this.NameCtrl.value,
  //     password: this.PasswordCtrl.value,
  //     confirmPassword: this.ConfirmPasswordCtrl.value,
  //     age: this.AgeCtrl.value,
  //     gender: this.GenderCtrl.value,
  //     city: this.CityCtrl.value,
  //     country: this.CountryCtrl.value
  //   }

  //   this.http.put('http://localhost:5000/api/user/update/67a777f85029c437d77aa2e6', appUser).subscribe();
  // }

  // delete(): void {
  //   this.http.delete<AppUser>('http://localhost:5000/api/user/delete/67a77bf75029c437d77aa2e7').subscribe({
  //     error: (err) => (this.errorMessage = err.error, console.log(err.error))
  //   });
  }
}
