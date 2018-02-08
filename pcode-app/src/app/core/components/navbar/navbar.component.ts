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
        label: 'Articles',
        url: './home'
      },
      {
        label: 'Materials',
        url: './login'
      },
      {
        label: 'About',
        url: './notfound'
      },
    ];
  }

  ngOnInit() {
  }

}
