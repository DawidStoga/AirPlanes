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
var forms_1 = require("@angular/forms");
var http_service_1 = require("../Service/http.service");
var HomeComponent = /** @class */ (function () {
    function HomeComponent(httpService) {
        this.httpService = httpService;
        this.formErrors = {
            username: '',
            password: ''
        };
        this.validationMessages = {
            username: {
                required: 'Username is required.',
                minlength: 'Minimum length is 3 characters.',
                pattern: 'Username is invalid.'
            },
            password: {
                required: 'Password is required.'
            }
        };
        this.alertType = 0;
    }
    HomeComponent.prototype.ngOnInit = function () {
        this.form = new forms_1.FormGroup({
            username: new forms_1.FormControl("", forms_1.Validators.compose([
                forms_1.Validators.required,
                forms_1.Validators.minLength(3),
                forms_1.Validators.pattern('[a-zA-Z0-9 ]*')
            ])),
            password: new forms_1.FormControl("", forms_1.Validators.compose([
                forms_1.Validators.required
            ])),
        });
    };
    HomeComponent.prototype.ngDoCheck = function () {
        var _this = this;
        this.form.valueChanges.subscribe(function (data) { return _this.onValueChanged(data); });
    };
    HomeComponent.prototype.onValueChanged = function (data) {
        for (var field in this.formErrors) {
            this.formErrors[field] = '';
            var control = this.form.get(field);
            if (control && control.dirty && control.invalid) {
                var messages = this.validationMessages[field];
                for (var key in control.errors) {
                    this.formErrors[field] = messages[key];
                }
            }
        }
    };
    HomeComponent.prototype.getLoggedIn = function () {
        var _this = this;
        var data = {
            username: this.username,
            password: this.password
        };
        this.httpService.postData('api/Metadata', data).then(function (response) {
            if (response) {
                _this.alertType = 1;
                _this.alertMessage = 'Logged in successfully.';
                _this.modalTitle = 'Success';
                _this.modalMessage = 'Logged in successfully.';
                _this.isLoggedIn = true;
            }
            else {
                _this.alertType = 2;
                _this.alertMessage = 'Failed to login.';
                _this.isLoggedIn = false;
            }
        });
    };
    HomeComponent = __decorate([
        core_1.Component({
            templateUrl: 'home.component.html',
            moduleId: module.id,
            styles: ["h3.sub-head{\n                background-color: #eee;\n                padding: 6px;\n                margin: 8px 0px 0px 0px;\n            }"]
        }),
        __metadata("design:paramtypes", [http_service_1.HttpService])
    ], HomeComponent);
    return HomeComponent;
}());
exports.HomeComponent = HomeComponent;
//# sourceMappingURL=home.component.js.map