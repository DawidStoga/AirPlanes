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
var rxjs_1 = require("rxjs");
var operators_1 = require("rxjs/operators");
var plane_service_1 = require("../plane.service");
var AirplaneSearchComponent = /** @class */ (function () {
    function AirplaneSearchComponent(planeService) {
        this.planeService = planeService;
        this.searchTerms = new rxjs_1.Subject();
    }
    // Push a search term into the observable stream.
    AirplaneSearchComponent.prototype.search = function (term) {
        this.searchTerms.next(term);
    };
    AirplaneSearchComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.planes$ = this.searchTerms.pipe(operators_1.debounceTime(300), operators_1.distinctUntilChanged(), operators_1.switchMap(function (term) { return _this.planeService.searchPlane(term); }));
    };
    AirplaneSearchComponent = __decorate([
        core_1.Component({
            selector: 'app-airplane-search',
            templateUrl: './airplane-search.component.html',
            styleUrls: ['./airplane-search.component.css']
        }),
        __metadata("design:paramtypes", [plane_service_1.PlaneService])
    ], AirplaneSearchComponent);
    return AirplaneSearchComponent;
}());
exports.AirplaneSearchComponent = AirplaneSearchComponent;
//# sourceMappingURL=airplane-search.component.js.map