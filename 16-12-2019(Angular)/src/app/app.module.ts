import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CreatingOwnComponentComponent } from './creating-own-component/creating-own-component.component';

@NgModule({
  declarations: [
    AppComponent,
    CreatingOwnComponentComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
