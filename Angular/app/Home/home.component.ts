import { Component, DoCheck } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

import { HttpService } from '../Service/http.service';
import { AlertComponent } from '../Generic/Alert/alert.component';
import { ModalComponent } from '../Generic/Modal/modal.component';

@Component({
    templateUrl: 'home.component.html',
    moduleId: module.id,
    styles: [`h3.sub-head{
                background-color: #eee;
                padding: 6px;
                margin: 8px 0px 0px 0px;
            }`]
})
export class HomeComponent {
    isLoggedIn: boolean;
    username: string;
    password: string;
    alertMessage: string;
    alertType: number;
    modalTitle: string;
    modalMessage: string;
    form: FormGroup;

    ngOnInit() {
        this.form = new FormGroup({
            username: new FormControl("", Validators.compose([
                Validators.required,
                Validators.minLength(3),
                Validators.pattern('[a-zA-Z0-9 ]*')
            ])),
            password: new FormControl("", Validators.compose([
                Validators.required
            ])),
        });
    }

    ngDoCheck() {
        this.form.valueChanges.subscribe(data => this.onValueChanged(data));
    }

    constructor(private httpService: HttpService) {
        this.alertType = 0;
    }

    private onValueChanged(data?: any) {
        for (const field in this.formErrors) {
            this.formErrors[field] = '';
            const control = this.form.get(field);
            if (control && control.dirty && control.invalid) {
                const messages = this.validationMessages[field];
                for (const key in control.errors) {
                    this.formErrors[field] = messages[key];
                }
            }
        }
    }

    private getLoggedIn() {
        var data = {
            username: this.username,
            password: this.password
        };

        this.httpService.postData('api/Metadata', data).then(response => {
            if (response) {
                this.alertType = 1;
                this.alertMessage = 'Logged in successfully.';
                this.modalTitle = 'Success';
                this.modalMessage = 'Logged in successfully.';
                this.isLoggedIn = true;
            } else {
                this.alertType = 2;
                this.alertMessage = 'Failed to login.';
                this.isLoggedIn = false;
            }
        });
    }

    private formErrors = {
        username: '',
        password: ''
    }

    private validationMessages = {
        username: {
            required: 'Username is required.',
            minlength: 'Minimum length is 3 characters.',
            pattern: 'Username is invalid.'
        },
        password: {
            required: 'Password is required.'
        }
    };
}