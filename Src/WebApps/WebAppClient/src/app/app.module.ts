import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatButtonModule} from '@angular/material/button';
import { FormsModule } from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';

import {MatDialogModule} from '@angular/material/dialog'; 

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { CatalogComponent } from './components/catalog/catalog.component';
import { AddCatalogComponent } from './components/add-catalog/add-catalog.component';

import { CatalogService } from './services/catalog/catalog.service';
import { DataService } from './services/data.service';

@NgModule({
  declarations: [
    AppComponent,
    CatalogComponent,
    AddCatalogComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatGridListModule, 
    BrowserAnimationsModule, 
    MatButtonModule,
    MatDialogModule,
    FormsModule,
    HttpClientModule
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
