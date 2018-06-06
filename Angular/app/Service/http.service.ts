import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptionsArgs } from '@angular/http';

import 'rxjs/add/operator/toPromise';

@Injectable()
export class HttpService {

    constructor(private http: Http) { }

    getData(dataUrl: string): Promise<any> {
        return this.http.get(dataUrl)
            .toPromise()
            .then(response => response.json())
            .catch(this.handleError);
    }

    postData(dataUrl: string, body: any, options?: RequestOptionsArgs): Promise<any> {
        return this.http.post(dataUrl, body, options)
            .toPromise()
            .then(response => response.json())
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        return Promise.reject(error.message || error);
    }
}