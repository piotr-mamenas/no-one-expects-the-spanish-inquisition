import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

import 'rxjs/add/operator/map';

@Injectable()
export class ProfileService {
  constructor(private http: Http) {
  }

  getProfiles() {
    return this.http.get('/api/profiles').map(res => res.json())
  }
}
