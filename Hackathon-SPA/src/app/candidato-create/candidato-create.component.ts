import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-candidato-create',
  templateUrl: './candidato-create.component.html',
  styleUrls: ['./candidato-create.component.css']
})
export class CandidatoCreateComponent implements OnInit {
  candidato: any = {};

  constructor(
    private candidatoService: CandidatoService,
    private router: Router) { }

  ngOnInit() {
  }

  cadastrarCandidato() {
    this.candidatoService.cadastrarCandidato(this.candidato).subscribe(data => {
      console.log('registrado com sucesso!');
      console.log(data);
      this.router.navigate(['home']);
    }, error => {
      console.log(error);
    });
    // this.router.navigate(['home']);
  }

  cancel() {
    this.router.navigate(['home']);
  }

}
