import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../environments/environment';
import { Observable, of } from 'rxjs';
import { Resource } from './resource';
import { Guess } from './guess';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor(private http: HttpClient) { }

  new() : Observable<string> {
    return this.http.post<string>(`${environment.apiUrl}/Game/create`, {}, {responseType: 'text' as 'json'});
  }

  perguntar(id: string, guess: Guess): Observable<number> {
    return this.http.post<number>(`${environment.apiUrl}/Game/guess`, { id, ...guess });
  }

  locais() : Observable<Resource> {
    return this.http.get<Resource>(`${environment.apiUrl}/locais`);
  }

  armas() : Observable<Resource> {
    return this.http.get<Resource>(`${environment.apiUrl}/armas`);
  }

  suspeitos() : Observable<Resource> {
    return this.http.get<Resource>(`${environment.apiUrl}/suspeitos`);
  }
}
