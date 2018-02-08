// Angular Libs
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

// Module Components
import { AppComponent } from './app.component';

// Internal Modules
import { SharedModule } from './shared/shared.module';
import { CoreModule } from './core/core.module';
import { FacebookModule } from 'ng2-facebook-sdk';

import { routing } from './app.routing';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    CoreModule,
    SharedModule,
    FacebookModule,
    routing
  ],
  providers: [],
  bootstrap: [ AppComponent ]
})

export class AppModule { }
