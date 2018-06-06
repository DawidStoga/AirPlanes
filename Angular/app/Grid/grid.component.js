"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var products_1 = require("../Data/products");
var kendo_data_query_1 = require("@progress/kendo-data-query");
var GridComponent = /** @class */ (function () {
    function GridComponent() {
        this.state = {
            skip: 0,
            take: 10,
            filter: {
                logic: "and",
                filters: []
            }
        };
        this.gridData = kendo_data_query_1.process(products_1.products, this.state);
    }
    GridComponent.prototype.dataStateChange = function (state) {
        this.state = state;
        this.gridData = kendo_data_query_1.process(products_1.products, this.state);
    };
    GridComponent = __decorate([
        core_1.Component({
            selector: 'grid-component',
            templateUrl: 'grid.component.html',
            moduleId: module.id
        })
    ], GridComponent);
    return GridComponent;
}());
exports.GridComponent = GridComponent;
//# sourceMappingURL=grid.component.js.map