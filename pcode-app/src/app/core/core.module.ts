// Angular Libs
import { NgModule } from '@angular/core';

// Internal Modules
import { SharedModule } from '../shared/shared.module';
import { PairingModule } from '../pairing/pairing.module';

// Module Components
import { HomeComponent } from './components/home/home.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { LoginComponent } from './components/login/login.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { PairingViewComponent } from './components/pairing-view/pairing-view.component';

import 'hammerjs';

@NgModule({
  declarations: [
    HomeComponent,
    NotFoundComponent,
    LoginComponent,
    NavbarComponent,
    PairingViewComponent
  ],
  imports: [
    SharedModule,
    PairingModule
  ],
  providers: [ ],
  exports: [
    HomeComponent,
    NotFoundComponent,
    LoginComponent,
    NavbarComponent,
    PairingViewComponent
  ]
})

export class CoreModule { }
