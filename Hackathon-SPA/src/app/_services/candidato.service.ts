import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CandidatoService {
  baseUrl = 'http://localhost:5000/candidatos';

  constructor(private http: HttpClient) { }

  listarCandidatos() {
    return this.http.get(this.baseUrl);
  }

  getCandidato(id: any) {
    return this.http.get(this.baseUrl + '/' + id);
  }

  cadastrarCandidato(candidato: any) {
    return this.http.post(this.baseUrl, candidato);
  }

  atualizarCandidato(candidato: any) {
    return this.http.put(this.baseUrl, candidato);
  }

  deletarCandidato(id: any) {
    return this.http.delete(this.baseUrl + '/' + id);
  }

  exibirResultados(numVagas: any) {
    return this.http.put(this.baseUrl + '/exibirResultados/' + numVagas, null);
  }
}
