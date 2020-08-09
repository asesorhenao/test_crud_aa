import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Inscription } from '../models/inscription';

@Injectable({
  providedIn: 'root'
})

export class InscriptionService {
  baseURL = environment.apiURL;
  constructor(private http: HttpClient) { }

  getInscription(insciptionId: string): Observable<Inscription> {
    const url = this.baseURL + '/' + insciptionId;
    return this.http.get<Inscription>(url);
  }

  getInscriptions(): Observable<Inscription[]> {
    return this.http.get<Inscription[]>(this.baseURL);    
  }

  CreateInscription(inscription: Inscription): Observable<Inscription> {
    return this.http.post<Inscription>(this.baseURL, inscription);
  }
  
  DeleteInscription(insciptionId: string): Observable<any>{
    const url = this.baseURL + '/' + insciptionId;
    return this.http.delete(url);
  }
}
