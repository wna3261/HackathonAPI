import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CandidatoService } from '../_services/candidato.service';

@Component({
  selector: 'app-candidato-get',
  templateUrl: './candidato-get.component.html',
  styleUrls: ['./candidato-get.component.css']
})
export class CandidatoGetComponent implements OnInit {
  id: any;
  candidato: any;

  constructor(
    private route: ActivatedRoute,
    private candidatoService: CandidatoService,
    private router: Router
  ) { }

  ngOnInit() {
    this.id = this.route.snapshot.params.id;
    console.log(this.id);
    this.candidatoService.getCandidato(this.id).subscribe(response => {
      this.candidato = response;
    }, error => {
      console.log(error);
    });
  }

  home() {
    this.router.navigate(['home']);
  }
}
