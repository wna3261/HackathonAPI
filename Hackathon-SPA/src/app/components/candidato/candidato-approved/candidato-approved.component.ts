import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../../../_services/candidato.service';
import { Router } from '@angular/router';
import { ConcursoService } from 'src/app/_services/concurso.service';
import { isNullOrUndefined } from 'util';

@Component({
  selector: 'app-candidato-approved',
  templateUrl: './candidato-approved.component.html',
  styleUrls: ['./candidato-approved.component.css']
})

export class CandidatoApprovedComponent implements OnInit {
  public numVagas: number = 0;

  constructor(
    private candidatoService: CandidatoService,
    private router: Router,
    private concursoService: ConcursoService) { }

  ngOnInit() {
  }

  public exibirResultados() {
    if (!isNullOrUndefined(this.numVagas)) {
      this.concursoService.updateVagas(this.numVagas).subscribe(data => {
        this.router.navigate(['home']);
      }, error => {
        console.log(error);
      });
    }
    else {
      console.log("O campo numero de vagas não pode ser nulo ou vazio");
    }
  }

  public cancel() {
    this.router.navigate(['home']);
  }
}
