import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {CatalogComponent} from './components/catalog/catalog.component'
import { AddCatalogComponent } from './components/add-catalog/add-catalog.component'
import { LoginComponent } from './components/user/login/login.component';
import { RegistrationComponent } from './components/user/registration/registration.component';
import { UserComponent } from './components/user/user/user.component';
import { CarBuyComponent } from './components/car-buy/car-buy.component';

const routes: Routes = [
  { path: '', component: CatalogComponent, canActivate: []},
  { path: 'addCar', component: AddCatalogComponent},
  { path: 'user', component: UserComponent },
  { path: 'login', component: LoginComponent },
  { path: 'registration', component: RegistrationComponent }, 
  { path: 'buyCar/:id', component: CarBuyComponent}
];

@NgModule({
  exports: [RouterModule],
  imports: [RouterModule.forRoot(routes)],
  declarations: []
})
export class AppRoutingModule { }
