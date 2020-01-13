import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-candidato-aprovados',
  templateUrl: './candidato-aprovados.component.html',
  styleUrls: ['./candidato-aprovados.component.css']
})
export class CandidatoAprovadosComponent implements OnInit {
  public numVagas: any;

  constructor(
    private candidatoService: CandidatoService,
    private router: Router) { }

  ngOnInit() {
  }

  public exibirResultados() {
    this.candidatoService.exibirResultados(this.numVagas).subscribe(data => {
      this.router.navigate(['home']);
    }, error => {
      console.log(error);
    });
  }

  public cancel() {
    this.router.navigate(['home']);
  }
}
