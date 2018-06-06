"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var router_1 = require("@angular/router");
var http_1 = require("@angular/http");
var forms_1 = require("@angular/forms");
var ng_bootstrap_1 = require("@ng-bootstrap/ng-bootstrap");
var animations_1 = require("@angular/platform-browser/animations");
var kendo_angular_grid_1 = require("@progress/kendo-angular-grid");
var kendo_angular_dropdowns_1 = require("@progress/kendo-angular-dropdowns");
var app_component_1 = require("./app.component");
var home_component_1 = require("./Home/home.component");
var about_component_1 = require("./About/about.component");
var autoComplete_component_1 = require("./AutoComplete/autoComplete.component");
var grid_component_1 = require("./Grid/grid.component");
var alert_component_1 = require("./Generic/Alert/alert.component");
var modal_component_1 = require("./Generic/Modal/modal.component");
var http_service_1 = require("./Service/http.service");
var appRoutes = [
    { path: 'home', component: home_component_1.HomeComponent },
    { path: 'about', component: about_component_1.AboutComponent }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        core_1.NgModule({
            imports: [
                platform_browser_1.BrowserModule,
                animations_1.BrowserAnimationsModule,
                router_1.RouterModule.forRoot(appRoutes, { useHash: true }),
                http_1.HttpModule,
                forms_1.FormsModule,
                forms_1.ReactiveFormsModule,
                ng_bootstrap_1.NgbModule.forRoot(),
                kendo_angular_grid_1.GridModule,
                kendo_angular_dropdowns_1.DropDownsModule
            ],
            providers: [http_service_1.HttpService],
            declarations: [
                app_component_1.AppComponent,
                home_component_1.HomeComponent,
                about_component_1.AboutComponent,
                autoComplete_component_1.AutoComplete,
                grid_component_1.GridComponent,
                alert_component_1.AlertComponent,
                modal_component_1.ModalComponent
            ],
            bootstrap: [
                app_component_1.AppComponent
            ]
        })
    ], AppModule);
    return AppModule;
}());
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map