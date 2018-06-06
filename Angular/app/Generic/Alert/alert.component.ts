import { Component, Input } from '@angular/core';

@Component({
    selector: 'alert-component',
    templateUrl: 'alert.component.html',
    moduleId: module.id
})
export class AlertComponent {
    @Input() alertMessage: string;
    @Input() alertType: number;
    //0-invalid
    //1-success
    //2-error
    //3-info
    //4-warning
}