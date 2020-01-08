import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-candidato-create',
  templateUrl: './candidato-create.component.html',
  styleUrls: ['./candidato-create.component.css']
})
export class CandidatoCreateComponent implements OnInit {
  candidato: any = {};

  constructor(
    private candidatoService: CandidatoService,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
  }

  cadastrarCandidato() {
    this.candidatoService.cadastrarCandidato(this.candidato).subscribe(data => {
      this.toastr.success('Cadastrado com Sucesso', 'Sucesso!');
      this.router.navigate(['home']);
    }, error => {
      this.toastr.error('Existem erros nos campos informados')
    });
    // this.router.navigate(['home']);
  }

  cancel() {
    this.router.navigate(['home']);
  }
}
