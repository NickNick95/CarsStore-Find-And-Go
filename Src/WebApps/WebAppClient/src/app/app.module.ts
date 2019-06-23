import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatButtonModule} from '@angular/material/button';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';

import { ToastrModule } from 'ngx-toastr';

import {MatDialogModule} from '@angular/material/dialog'; 

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { CatalogComponent } from './components/catalog/catalog.component';
import { AddCatalogComponent } from './components/add-catalog/add-catalog.component';

import { CatalogService } from './services/catalog/catalog.service';
import { DataService } from './services/data.service';

import { LoginComponent } from './components/user/login/login.component';
import { RegistrationComponent } from './components/user/registration/registration.component';
import { UserComponent } from './components/user/user/user.component';
import { CarBuyComponent } from './components/car-buy/car-buy.component';

@NgModule({
  declarations: [
    AppComponent,
    CatalogComponent,
    AddCatalogComponent,
    RegistrationComponent,
    LoginComponent, 
    UserComponent, 
    CarBuyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatGridListModule, 
    ReactiveFormsModule,
    BrowserAnimationsModule, 
    MatButtonModule,
    MatDialogModule,
    FormsModule,
    HttpClientModule, 
    ToastrModule.forRoot({
      progressBar: true
    }),
  ],
  providers: [
    HttpClientModule,
    CatalogService,
    DataService
  ],
  bootstrap: [AppComponent], 
  entryComponents: [ ]
})
export class AppModule { }
