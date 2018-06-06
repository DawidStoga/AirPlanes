import { Component } from '@angular/core';
import { HttpService } from '../Service/http.service';

@Component({
    templateUrl: 'about.component.html',
    moduleId: module.id
})
export class AboutComponent {

    aboutme: string[];

    constructor(private httpService: HttpService) {
    }

    ngOnInit() {
        this.httpService.getData('api/Metadata').then(response => {
            this.aboutme = response;
        });
    }
}