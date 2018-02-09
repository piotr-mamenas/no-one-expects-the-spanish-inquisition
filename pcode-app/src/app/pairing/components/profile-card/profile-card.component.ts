import { Component, OnInit } from '@angular/core';
import { IProfile } from '../../../interfaces/iprofile.type';

@Component({
  selector: 'pairing-profile-card',
  templateUrl: './profile-card.component.html',
  styleUrls: ['./profile-card.component.css']
})
export class ProfileCardComponent implements OnInit {
  public profile : IProfile;

  constructor() {
  }

  ngOnInit() {
  }

  displayProfile() {
    console.log("Hi");
  }
}
