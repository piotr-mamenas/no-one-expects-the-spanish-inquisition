import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { MdButtonModule} from '@angular/material';
import { MdCheckboxModule } from '@angular/material';
import { MatTabsModule } from '@angular/material';
import { MdToolbarModule } from '@angular/material';
import { MdCardModule } from '@angular/material';
import { MatProgressSpinnerModule } from '@angular/material';

import { Router, RouterModule } from '@angular/router';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FlexLayoutModule } from '@angular/flex-layout';

import 'hammerjs';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    HttpModule,
    MdButtonModule,
    MdCheckboxModule,
    MatTabsModule,
    MdToolbarModule,
    RouterModule,
    MdCardModule,
    MatProgressSpinnerModule
  ],
  providers: [ ],
  exports: [
    CommonModule,
    ReactiveFormsModule,
    MdButtonModule,
    MdCheckboxModule,
    MatTabsModule,
    BrowserAnimationsModule,
    MdToolbarModule,
    RouterModule,
    MdCardModule,
    HttpModule,
    MatProgressSpinnerModule
  ]
})

export class SharedModule { }
