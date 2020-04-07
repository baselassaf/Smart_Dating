import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
//  create obj called model of type "any" for un and pw
  model: any = {};
  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log('Logged in successfully');
    }, error => {
      console.log(error);
    });
  }

  loggedIn() {
   const token = localStorage.getItem('token');
  //  check if token have value return t or f
   return !!token;
  }

  logout() {
    localStorage.removeItem('token');
    console.log('logged out');
  }
}
