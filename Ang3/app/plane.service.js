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
var mock_planes_1 = require("../app/Mock/mock-planes");
var rxjs_1 = require("rxjs");
var message_service_1 = require("./message.service");
//const httpOptions = {
//  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
//};
var PlaneService = /** @class */ (function () {
    function PlaneService(
    //private http: HttpClient,
    messageService) {
        this.messageService = messageService;
        this.planeUrl = 'api/planes'; //URL to planes
    }
    PlaneService.prototype.getPlanes = function () {
        this.messageService.add('PlaneService: fetched planes');
        return rxjs_1.of(mock_planes_1.PLANES);
        //return this.http.get<Machine[]>(this.planeUrl)
        //.pipe(
        // tap(heroes => this.log(`fetched heroes`)),
        //  catchError(this.handleError('getPlanes',[]))
        //);
    };
    PlaneService.prototype.getPlane = function (id) {
        var url = this.planeUrl + "/" + id;
        this.messageService.add("PlaneService: fetched plane id=" + id);
        var founds = mock_planes_1.PLANES.find(function (pl) { return pl.id == id; });
        return rxjs_1.of(founds[0]);
        //return this.http.get<Machine>(url).pipe(
        //tap(_=> this.log(`fetched hero id=${id}`)),
        //catchError(this.handleError<Machine>(`getHero id=${id}`))
        //);
        //return of(PLANES.find(plane=> plane.id === id));
    };
    /** POST: add a new hero to the server */
    PlaneService.prototype.addMachine = function (plane) {
        return rxjs_1.of(mock_planes_1.PLANES[0]);
        //return this.http.post<Machine>(this.planeUrl, plane, httpOptions).pipe(
        //  tap((plane: Machine) => this.log(`added hero w/ id=${plane.id}`)),
        //  catchError(this.handleError<Machine>('addHero'))
        //);
    };
    /** DELETE: delete the hero from the server */
    PlaneService.prototype.deletePlane = function (deletedPlane) {
        var id = typeof deletedPlane === 'number' ? deletedPlane : deletedPlane.id;
        var url = this.planeUrl + "/" + id;
        return rxjs_1.of(mock_planes_1.PLANES[0]);
        //return this.http.delete<Machine>(url, httpOptions).pipe(
        //  tap(_ => this.log(`deleted plane id=${id}`)),
        //  catchError(this.handleError<Machine>('deletePlane'))
        //);
    };
    /** Search: search the hero in  the server */
    PlaneService.prototype.searchPlane = function (term) {
        if (!term.trim()) {
            return rxjs_1.of([]);
        }
        //return this.http.get<Machine[]>(`${this.planeUrl}/?name=${term}`).pipe(
        //  tap(_ => this.log(`found planes matching "${term}"`)),
        //    catchError(this.handleError<Machine[]>('searchAirplanes', []))
        //)
    };
    /** Log a HeroService message with the MessageService */
    PlaneService.prototype.log = function (message) {
        this.messageService.add('HeroService: ' + message);
    };
    PlaneService.prototype.updatePlane = function (plane) {
        return rxjs_1.of(mock_planes_1.PLANES[0]);
        //return this.http.put(this.planeUrl, plane, httpOptions ).pipe(
        //tap(_ => this.log(`updated plane id=${plane.id}`)),
        //    catchError(this.handleError<any>('updatedPlane'))
        //)
    };
    /**
  * Handle Http operation that failed.
  * Let the app continue.
  * @param operation - name of the operation that failed
  * @param result - optional value to return as the observable result
  */
    PlaneService.prototype.handleError = function (operation, result) {
        var _this = this;
        if (operation === void 0) { operation = 'operation'; }
        return function (error) {
            // TODO: send the error to remote logging infrastructure
            console.error(error); // log to console instead
            // TODO: better job of transforming error for user consumption
            _this.log(operation + " failed: " + error.message);
            // Let the app keep running by returning an empty result.
            return rxjs_1.of(result);
        };
    };
    PlaneService = __decorate([
        core_1.Injectable({
            providedIn: 'root'
        }),
        __metadata("design:paramtypes", [message_service_1.MessageService])
    ], PlaneService);
    return PlaneService;
}());
exports.PlaneService = PlaneService;
//# sourceMappingURL=plane.service.js.map