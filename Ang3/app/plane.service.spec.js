"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var plane_service_1 = require("./plane.service");
describe('PlaneService', function () {
    beforeEach(function () {
        testing_1.TestBed.configureTestingModule({
            providers: [plane_service_1.PlaneService]
        });
    });
    it('should be created', testing_1.inject([plane_service_1.PlaneService], function (service) {
        expect(service).toBeTruthy();
    }));
});
//# sourceMappingURL=plane.service.spec.js.map