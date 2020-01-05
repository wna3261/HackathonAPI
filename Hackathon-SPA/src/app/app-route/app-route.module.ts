import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CandidatoListComponent } from '../candidato-list/candidato-list.component';
import { CandidatoGetComponent } from '../candidato-get/candidato-get.component';
import { CandidatoCreateComponent } from '../candidato-create/candidato-create.component';
import { CandidatoUpdateComponent } from '../candidato-update/candidato-update.component';

const routes: Routes = [
  { path: '', component: CandidatoListComponent},
  { path: 'home', component: CandidatoListComponent },
  { path: 'get/:id', component: CandidatoGetComponent },
  { path: 'cadastrar', component: CandidatoCreateComponent},
  { path: 'put/:id', component: CandidatoUpdateComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRouteModule { }
