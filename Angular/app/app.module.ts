import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { HttpModule } from '@angular/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { GridModule } from '@progress/kendo-angular-grid';
import { DropDownsModule } from '@progress/kendo-angular-dropdowns';

import { AppComponent } from './app.component';
import { HomeComponent } from './Home/home.component';
import { AboutComponent } from './About/about.component';
import { AutoComplete } from './AutoComplete/autoComplete.component';
import { GridComponent } from './Grid/grid.component';
import { AlertComponent } from './Generic/Alert/alert.component';
import { ModalComponent } from './Generic/Modal/modal.component';

import { HttpService } from './Service/http.service';

const appRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'about', component: AboutComponent }
];

@NgModule({
    imports:
    [
        BrowserModule,
        BrowserAnimationsModule,
        RouterModule.forRoot(appRoutes, { useHash: true }),
        HttpModule,
        FormsModule,
        ReactiveFormsModule,
        NgbModule.forRoot(),
        GridModule,
        DropDownsModule
    ],
    providers: [HttpService],
    declarations: [
        AppComponent,
        HomeComponent,
        AboutComponent,
        AutoComplete,
        GridComponent,
        AlertComponent,
        ModalComponent
    ],
    bootstrap: [
        AppComponent
    ]
})
export class AppModule { }
