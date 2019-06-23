import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {

  public userTokeId:string;
  public userName: string;

  constructor(private router:Router){
    this.userTokeId = localStorage.getItem('token')
    this.userName = "userName";
  }

  onLogout() {
    localStorage.removeItem('token');
    this.router.navigateByUrl('login');
  }
}

