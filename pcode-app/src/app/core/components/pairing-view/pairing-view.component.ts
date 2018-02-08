import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pairing-view',
  templateUrl: './pairing-view.component.html',
  styleUrls: ['./pairing-view.component.css']
})
export class PairingViewComponent implements OnInit {
  cards = [1,2,3,4,5,6,7,8];

  constructor() { }

  ngOnInit() {
  }

}
