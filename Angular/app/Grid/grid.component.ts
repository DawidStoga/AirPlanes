import { Component } from '@angular/core';
import { products } from '../Data/products';
import { GridDataResult, DataStateChangeEvent } from '@progress/kendo-angular-grid';
import { process, State } from '@progress/kendo-data-query';

@Component({
    selector: 'grid-component',
    templateUrl: 'grid.component.html',
    moduleId: module.id
})
export class GridComponent {
    private state: State = {
        skip: 0,
        take: 10,

        filter: {
            logic: "and",
            filters: []
        }
    };

    private gridData: GridDataResult = process(products, this.state);

    protected dataStateChange(state: DataStateChangeEvent): void {
        this.state = state;
        this.gridData = process(products, this.state);
    }
}

