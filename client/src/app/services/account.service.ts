import { inject, Injectable } from '@angular/core';
import { AppUser } from '../models/app-user.model';
import { Observable } from 'rxjs';
import { LoggedIn } from '../models/logged-in.model';
import { HttpClient } from '@angular/common/http';
import { Login } from '../models/login.model';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  http = inject(HttpClient);

    register(appUser: AppUser): Observable<LoggedIn> {
     return this.http.post<LoggedIn>('http://localhost:5000/api/user/register', appUser);
    }
  
    login(userInput: Login): Observable<LoggedIn> {
      return this.http.post<LoggedIn>('http://localhost:5000/api/user/login', userInput);
    }
}
