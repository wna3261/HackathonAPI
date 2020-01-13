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
  public candidato: any = { nome: '', cidade: '', nota: 0 };

  constructor(
    private candidatoService: CandidatoService,
    private router: Router,
    private toastr: ToastrService) { }

  ngOnInit() {
  }

  public cadastrarCandidato() {
    if (!isNullOrUndefined(this.candidato.nota)) {
      this.candidatoService.cadastrarCandidato(this.candidato).subscribe(data => {
        this.toastr.success("Candidato cadastrado com sucesso.", 'Sucesso!');
        this.router.navigate(['home']);
      }, error => {
        error.error.errors ?
          Object.values(error.error.errors).forEach(fieldErrors => {
            let errors = fieldErrors as Array<string>;
            errors.forEach(error => {
              this.toastr.error(error)
            });
          }) :
          this.toastr.warning(error.error);
      });
    }
    else {
      this.toastr.error("O campo Nota é obrigatório.");
      this.candidato.nota = 0;
    }
  }

  public cancel() {
    this.router.navigate(['home']);
  }
}
