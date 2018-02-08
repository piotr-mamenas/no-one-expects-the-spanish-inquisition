// Angular Libs
import { NgModule } from '@angular/core';

// Internal Modules
import { SharedModule } from '../shared/shared.module';

// Module Components
import { ProfileCardComponent } from './components/profile-card/profile-card.component'

import 'hammerjs';

@NgModule({
  declarations: [
    ProfileCardComponent
  ],
  imports: [
    SharedModule
  ],
  providers: [ ],
  exports: [
    ProfileCardComponent
  ]
})

export class PairingModule { }
