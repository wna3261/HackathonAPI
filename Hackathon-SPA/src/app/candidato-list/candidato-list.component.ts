import { Component, OnInit, TemplateRef } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Router } from '@angular/router';
import { BsModalService, BsModalRef } from 'ngx-bootstrap/modal';
@Component({
  selector: 'app-candidato-list',
  templateUrl: './candidato-list.component.html',
  styleUrls: ['./candidato-list.component.scss']
})
export class CandidatoListComponent implements OnInit {
  candidatos: any;
  modalRef: BsModalRef;
  message: string;
  constructor(
    private candidatoService: CandidatoService,
    private modalService: BsModalService,
    private router: Router) { }

  ngOnInit() {
    this.listarCandidatos();
  }

  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template, {class: 'modal-sm'});
  }
  
  decline(): void {
    this.message = 'Declined!';
    this.modalRef.hide();
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
    this.modalRef.hide();
  }

}
