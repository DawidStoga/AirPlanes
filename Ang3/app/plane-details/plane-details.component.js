"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var machine_1 = require("../Model/machine");
var router_1 = require("@angular/router");
var plane_service_1 = require("../plane.service");
var common_1 = require("@angular/common");
var PlaneDetailsComponent = /** @class */ (function () {
    function PlaneDetailsComponent(route, planeService, location) {
        this.route = route;
        this.planeService = planeService;
        this.location = location;
    }
    PlaneDetailsComponent.prototype.ngOnInit = function () {
        this.getPlane();
    };
    PlaneDetailsComponent.prototype.getPlane = function () {
        var _this = this;
        var id = +this.route.snapshot.paramMap.get('id');
        this.planeService.getPlane(id).subscribe(function (plane) { return _this.InputPlane = plane; });
    };
    PlaneDetailsComponent.prototype.goBack = function () {
        this.location.back();
    };
    PlaneDetailsComponent.prototype.save = function () {
        var _this = this;
        this.planeService.updatePlane(this.InputPlane).subscribe(function () { return _this.goBack(); });
    };
    __decorate([
        core_1.Input(),
        __metadata("design:type", machine_1.Machine)
    ], PlaneDetailsComponent.prototype, "InputPlane", void 0);
    PlaneDetailsComponent = __decorate([
        core_1.Component({
            selector: 'app-plane-details',
            templateUrl: './plane-details.component.html',
            styleUrls: ['./plane-details.component.css']
        }),
        __metadata("design:paramtypes", [router_1.ActivatedRoute,
            plane_service_1.PlaneService,
            common_1.Location])
    ], PlaneDetailsComponent);
    return PlaneDetailsComponent;
}());
exports.PlaneDetailsComponent = PlaneDetailsComponent;
//# sourceMappingURL=plane-details.component.js.map