import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { isNullOrUndefined } from 'util';

@Component({
  selector: 'app-candidato-create',
  templateUrl: './candidato-create.component.html',
  styleUrls: ['./candidato-create.component.css']
})
export class CandidatoCreateComponent implements OnInit {
  candidato: any = { nome: '', cidade: '', nota: 0 };

  constructor(
    private candidatoService: CandidatoService,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
  }

  cadastrarCandidato() {
    if (!isNullOrUndefined(this.candidato.nota)) {
      this.candidatoService.cadastrarCandidato(this.candidato).subscribe(data => {
        this.toastr.success('Cadastrado com Sucesso', 'Sucesso!');
        this.router.navigate(['home']);
      }, error => {
        error.error.errors ?
          Object.values(error.error.errors).forEach(fieldErrors => {
            let errors = fieldErrors as Array<string>;
            errors.forEach(error => {
              this.toastr.error(error)
            });
          }) :
          this.toastr.error(error.error);
      });
    }
    else {
      this.toastr.error("O campo Nota é obrigatório.");
    }

    // this.router.navigate(['home']);
  }

  cancel() {
    this.router.navigate(['home']);
  }
}
