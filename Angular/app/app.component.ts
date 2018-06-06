import { Component } from '@angular/core';

@Component({
    selector: 'root-container',
    templateUrl: 'app.component.html',
    styleUrls: ['app.component.css'],
    moduleId: module.id
})
export class AppComponent {
    name = 'Angular 4';
    title = 'Angular 4';
    menu = [
        { title: 'Home', link: '/home' },
        { title: 'About Us', link: '/about' }
    ]
}
