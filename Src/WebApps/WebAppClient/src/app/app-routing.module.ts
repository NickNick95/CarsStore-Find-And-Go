import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {CatalogComponent} from './components/catalog/catalog.component'

const routes: Routes = [
  { path: '', component: CatalogComponent, canActivate: []}
];

@NgModule({
  exports: [RouterModule],
  imports: [RouterModule.forRoot(routes)],
  declarations: []
})
export class AppRoutingModule { }
