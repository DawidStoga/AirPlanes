import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { DashboardComponent } from './dashboard/dashboard.component';

@NgModule({
    imports: [
        BrowserModule,
        AppRoutingModule
         ],
    declarations: [AppComponent,
        DashboardComponent],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
