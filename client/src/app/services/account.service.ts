import { inject, Injectable } from '@angular/core';
import { AppUser } from '../models/app-user.model';
import { Observable } from 'rxjs';
import { LoggedIn } from '../models/logged-in.model';
import { HttpClient } from '@angular/common/http';
import { Login } from '../models/login.model';
import { Member } from '../models/member.model';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  http = inject(HttpClient);
  private readonly _baseApiUrl: string = 'http://localhost:5000/api/';

  register(appUser: AppUser): Observable<LoggedIn> {
    return this.http.post<LoggedIn>(this._baseApiUrl + 'user/register', appUser)
  }

  login(userInput: Login): Observable<LoggedIn> {
    return this.http.post<LoggedIn>(this._baseApiUrl + 'user/login', userInput);
  }

  getAllMember(): Observable<Member[]> {
    return this.http.get<Member[]>(this._baseApiUrl + 'user');
  }
}
