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
var kendo_angular_dropdowns_1 = require("@progress/kendo-angular-dropdowns");
var AutoComplete = /** @class */ (function () {
    function AutoComplete() {
        this.listItems = [
            "Albania",
            "Andorra",
            "Armenia",
            "Austria",
            "Azerbaijan",
            "Belarus",
            "Belgium",
            "Bosnia & Herzegovina",
            "Bulgaria",
            "Croatia",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Estonia",
            "Finland",
            "France",
            "Georgia",
            "Germany",
            "Greece",
            "Hungary",
            "Iceland",
            "Ireland",
            "Italy",
            "Kosovo",
            "Latvia",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Malta",
            "Moldova",
            "Monaco",
            "Montenegro",
            "Netherlands",
            "Norway",
            "Poland",
            "Portugal",
            "Romania",
            "Russia",
            "San Marino",
            "Serbia",
            "Slovakia",
            "Slovenia",
            "Spain",
            "Sweden",
            "Switzerland",
            "Turkey",
            "Ukraine",
            "United Kingdom",
            "Vatican City"
        ];
    }
    AutoComplete.prototype.handleFilter = function (value) {
        console.log(typeof (value));
        if (value.length >= 3) {
            this.data = this.listItems.filter(function (s) { return s.toLowerCase().indexOf(value.toLowerCase()) !== -1; });
        }
        else {
            this.autocomplete.toggle(false);
        }
    };
    __decorate([
        core_1.ViewChild('autocomplete'),
        __metadata("design:type", typeof (_a = typeof kendo_angular_dropdowns_1.AutoCompleteComponent !== "undefined" && kendo_angular_dropdowns_1.AutoCompleteComponent) === "function" && _a || Object)
    ], AutoComplete.prototype, "autocomplete", void 0);
    AutoComplete = __decorate([
        core_1.Component({
            selector: 'autoComplete-component',
            templateUrl: 'autoComplete.component.html',
            moduleId: module.id
        })
    ], AutoComplete);
    return AutoComplete;
    var _a;
}());
exports.AutoComplete = AutoComplete;
//# sourceMappingURL=autoComplete.component.js.map