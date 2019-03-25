import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {CatalogComponent} from './components/catalog/catalog.component'
import { AddCatalogComponent } from './components/add-catalog/add-catalog.component'

const routes: Routes = [
  { path: '', component: CatalogComponent, canActivate: []},
  { path: 'addCar', component: AddCatalogComponent}
];

@NgModule({
  exports: [RouterModule],
  imports: [RouterModule.forRoot(routes)],
  declarations: []
})
export class AppRoutingModule { }
