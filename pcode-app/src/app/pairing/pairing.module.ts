// Angular Libs
import { NgModule } from '@angular/core';

// Internal Modules
import { SharedModule } from '../shared/shared.module';

// Module Components
import { ProfileCardComponent } from './components/profile-card/profile-card.component'
import { ProfilePageComponent } from './components/profile-page/profile-page.component'

import 'hammerjs';

@NgModule({
  declarations: [
    ProfileCardComponent,
    ProfilePageComponent
  ],
  imports: [
    SharedModule
  ],
  providers: [ ],
  exports: [
    ProfileCardComponent,
    ProfilePageComponent
  ]
})

export class PairingModule { }
