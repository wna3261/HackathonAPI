import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-candidato-aprovados',
  templateUrl: './candidato-aprovados.component.html',
  styleUrls: ['./candidato-aprovados.component.css']
})
export class CandidatoAprovadosComponent implements OnInit {
  numVagas: any;

  constructor(
    private candidatoService: CandidatoService,
    private router: Router) { }

  ngOnInit() {
  }

  exibirResultados() {
    this.candidatoService.exibirResultados(this.numVagas).subscribe(data => {
      console.log(data);
      this.router.navigate(['home']);
    }, error => {
      console.log(error);
    });
  }

}
