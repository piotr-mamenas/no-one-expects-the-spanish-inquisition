import { Component, OnInit } from '@angular/core';
import { IProfile } from '../../../interfaces/iprofile.type';
import { ProfileService } from './../../services/profile.service';

@Component({
  selector: 'pairing-profile-card',
  templateUrl: './profile-card.component.html',
  styleUrls: ['./profile-card.component.css']
})
export class ProfileCardComponent implements OnInit {
  public profiles : IProfile[];

  constructor(private profileService: ProfileService) {

  }

  ngOnInit() {
    this.profileService.getProfiles().subscribe(profiles =>
    this.profiles = profiles);
    console.log(this.profiles);
  }

  displayProfile() {
    console.log("Hi");
  }
}
