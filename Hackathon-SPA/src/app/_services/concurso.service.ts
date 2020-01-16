import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {environment} from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ConcursoService {
  private baseUrl = environment.baseUrl;
  private serviceUrl = 'concurso/';

  constructor(private http: HttpClient) { 
    this.baseUrl = this.baseUrl + this.serviceUrl;
  }

  listarConcursos() {
    return this.http.get(this.baseUrl);
  }

  getConcurso(id: any) {
    return this.http.get(this.baseUrl + id);
  }

  cadastrarConcurso(candidato: any) {
    return this.http.post(this.baseUrl, candidato);
  }

  atualizarConcurso(candidato: any) {
    return this.http.put(this.baseUrl, candidato);
  }

  deletarConcurso(id: any) {
    return this.http.delete(`${this.baseUrl}${id}`);
  }

  updateVagas(numVagas: any) {
    return this.http.patch(this.baseUrl + numVagas, null);
  }
}
