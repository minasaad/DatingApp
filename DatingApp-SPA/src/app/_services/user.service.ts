import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { User } from '../_models/User';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})




export class UserService {
baseURL = environment.baseUrl;
constructor(private http: HttpClient) { }

getUsers(): Observable<User[]> {

  return this.http.get<User[]>(this.baseURL + 'users');
}

getUser(id): Observable<User> {

  return this.http.get<User>(this.baseURL + 'users/' + id);
}

updateUser(id: number, user: User) {
  return this.http.put(this.baseURL + 'users/' + id, user);
}

}
