import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-candidato-list',
  templateUrl: './candidato-list.component.html',
  styleUrls: ['./candidato-list.component.scss']
})
export class CandidatoListComponent implements OnInit {
  candidatos: any;

  constructor(private candidatoService: CandidatoService) { }

  ngOnInit() {
    this.listarCandidatos();
  }

  listarCandidatos() {
    this.candidatos = this.candidatoService.listarCandidatos();
    console.log(this.candidatos);
  }

}
