import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { CandidatoListComponent } from './candidato-list/candidato-list.component';
import { CandidatoService } from './_services/candidato.service';

@NgModule({
   declarations: [
      AppComponent,
      CandidatoListComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule
   ],
   providers: [
     CandidatoService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
