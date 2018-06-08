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
var plane_service_1 = require("../plane.service");
var AirplaneComponent = /** @class */ (function () {
    function AirplaneComponent(planeService) {
        this.planeService = planeService;
        this.plane = "None";
    }
    AirplaneComponent.prototype.getPlanes = function () {
        var _this = this;
        // this.machines = this.planeService.getPlanes();
        this.planeService.getPlanes().subscribe(function (machines) { return _this.machines = machines; });
    };
    AirplaneComponent.prototype.add = function (name) {
        var _this = this;
        name = name.trim();
        if (!name) {
            return;
        }
        this.planeService.addMachine({ name: name })
            .subscribe(function (hero) {
            _this.machines.push(hero);
        });
    };
    AirplaneComponent.prototype.delete = function (planeToDelete) {
        this.machines = this.machines.filter(function (h) { return h !== planeToDelete; });
        this.planeService.deletePlane(planeToDelete).subscribe();
    };
    AirplaneComponent.prototype.onSelect = function (ClickedPlane) {
        this.selectedPlane = ClickedPlane;
    };
    AirplaneComponent.prototype.ngOnInit = function () {
        this.getPlanes();
    };
    AirplaneComponent = __decorate([
        core_1.Component({
            selector: 'app-airplane',
            templateUrl: './airplane.component.html',
            styleUrls: ['./airplane.component.css']
        }),
        __metadata("design:paramtypes", [plane_service_1.PlaneService])
    ], AirplaneComponent);
    return AirplaneComponent;
}());
exports.AirplaneComponent = AirplaneComponent;
//# sourceMappingURL=airplane.component.js.map