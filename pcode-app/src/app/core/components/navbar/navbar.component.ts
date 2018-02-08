import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  navLinks: any[];

  constructor() {
    this.navLinks = [
      {
        label: 'Developers',
        url: './home'
      },
      {
        label: 'Sessions',
        url: './login'
      },
      {
        label: 'Profile',
        url: './notfound'
      },
    ];
  }

  ngOnInit() {
  }

}
