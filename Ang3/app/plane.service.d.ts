import { Machine } from "../app/Model/machine";
import { Observable } from 'rxjs';
import { MessageService } from './message.service';
import { HttpClient } from '@angular/common/http';
export declare class PlaneService {
    private http;
    private messageService;
    private planeUrl;
    constructor(http: HttpClient, messageService: MessageService);
    getPlanes(): Observable<Machine[]>;
    getPlane(id: number): Observable<Machine>;
    /** POST: add a new hero to the server */
    addMachine(plane: Machine): Observable<Machine>;
    /** DELETE: delete the hero from the server */
    deletePlane(deletedPlane: Machine | number): Observable<Machine>;
    /** Search: search the hero in  the server */
    searchPlane(term: string): Observable<Machine[]>;
    /** Log a HeroService message with the MessageService */
    private log(message);
    updatePlane(plane: Machine): Observable<any>;
    /**
  * Handle Http operation that failed.
  * Let the app continue.
  * @param operation - name of the operation that failed
  * @param result - optional value to return as the observable result
  */
    private handleError<T>(operation?, result?);
}
