import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(public authService: AuthService, private alertifyService: AlertifyService,
    private router: Router) {}

  ngOnInit() {}

  login() {
    this.authService.Login(this.model).subscribe(
      next => {
        console.log('Logged In Successfully');
        this.alertifyService.success('Logged In Successfully');
      },
      error => {
        console.log(error);
        this.alertifyService.error(error);
      }, () => {
        this.router.navigate(['/members']);
      }
    );
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    console.log('logged out');
    this.alertifyService.message('logged out');
    this.router.navigate(['/home']);
  }
}
