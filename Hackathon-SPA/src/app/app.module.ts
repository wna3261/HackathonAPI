import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import { AppRouteModule } from './app-route/app-route.module';
import {FormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { CandidatoListComponent } from './candidato-list/candidato-list.component';
import { CandidatoService } from './_services/candidato.service';
import { CandidatoGetComponent } from './candidato-get/candidato-get.component';
import { CandidatoCreateComponent } from './candidato-create/candidato-create.component';
import { CandidatoUpdateComponent } from './candidato-update/candidato-update.component';
import { CandidatoAprovadosComponent } from './candidato-aprovados/candidato-aprovados.component';
import { ModalModule } from 'ngx-bootstrap/modal';

@NgModule({
   declarations: [
      AppComponent,
      CandidatoListComponent,
      CandidatoGetComponent,
      CandidatoCreateComponent,
      CandidatoUpdateComponent,
      CandidatoAprovadosComponent
   ],
   imports: [
      BrowserModule,
      AppRouteModule,
      FormsModule,
      HttpClientModule,
      ModalModule.forRoot()
   ],
   providers: [
      CandidatoService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
