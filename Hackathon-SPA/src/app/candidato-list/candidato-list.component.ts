import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Observable } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-candidato-list',
  templateUrl: './candidato-list.component.html',
  styleUrls: ['./candidato-list.component.scss']
})
export class CandidatoListComponent implements OnInit {
  candidatos: any;

  constructor(
    private candidatoService: CandidatoService,
    private router: Router) { }

  ngOnInit() {
    this.listarCandidatos();
  }

  listarCandidatos() {
    this.candidatoService.listarCandidatos().subscribe(response => {
      this.candidatos = response;
    }, error => {
      console.log(error);
    });
  }

  getCandidato(id: any) {
    this.router.navigate(['get/', id]);
  }

  atualizarCandidato(id: any) {
    this.router.navigate(['put/', id]);
  }

  deletarCandidato(id: any) {
    this.candidatoService.deletarCandidato(id).subscribe(data => {
      this.listarCandidatos();
    }, error => {
      console.log(error);
    });
  }

}
