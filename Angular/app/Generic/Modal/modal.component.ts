import { Component, Input, ViewEncapsulation } from '@angular/core';
import { NgbModal, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';

@Component({
    selector: 'modal-component',
    templateUrl: 'modal.component.html',
    moduleId: module.id,
    styles: [`
        .fade.show {
          opacity: 1;
        }

        .modal.show .modal-dialog {
          -webkit-transform: translate(0, 0);
          -ms-transform: translate(0, 0);
          -o-transform: translate(0, 0);
          transform: translate(0, 0);
        }

        .modal-backdrop.show {
          opacity: 0.5;
        }
    `],
    encapsulation: ViewEncapsulation.None
})
export class ModalComponent {

    constructor(private modalService: NgbModal) { }

    closeResult: string;
    @Input() modalTitle: string;
    @Input() modalMessage: string;

    open(content: any) {
        this.modalService.open(content).result.then((result) => {
            this.closeResult = `Closed with: ${result}`;
        }, (reason) => {
            this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
        });
    }

    private getDismissReason(reason: any): string {
        if (reason === ModalDismissReasons.ESC) {
            return 'by pressing ESC';
        } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
            return 'by clicking on a backdrop';
        } else {
            return `with: ${reason}`;
        }
    }
}