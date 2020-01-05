import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CandidatoService {
  baseUrl = 'http://localhost:5000/candidatos';

  constructor(private http: HttpClient) { }

  listarCandidatos() {
    return this.http.get(this.baseUrl).subscribe(next => {
      next.toString();
    });
  }

}
