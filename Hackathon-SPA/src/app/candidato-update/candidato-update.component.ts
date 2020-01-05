import { Component, OnInit } from '@angular/core';
import { CandidatoService } from '../_services/candidato.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-candidato-update',
  templateUrl: './candidato-update.component.html',
  styleUrls: ['./candidato-update.component.css']
})
export class CandidatoUpdateComponent implements OnInit {
  candidato: any = {};
  id: any;

  constructor(
    private candidatoService: CandidatoService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit() {
    this.id = this.route.snapshot.params.id;
  }

  atualizarCandidato() {
    this.candidato.id = this.id;
    console.log(this.candidato.id);
    this.candidatoService.atualizarCandidato(this.candidato).subscribe(data => {
      console.log(data);
    });
  }

  cancel() {
    this.router.navigate(['home']);
  }

}
