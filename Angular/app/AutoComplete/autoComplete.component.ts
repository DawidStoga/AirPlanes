import { Component, ViewChild } from '@angular/core';
import { AutoCompleteComponent } from '@progress/kendo-angular-dropdowns';

@Component({
    selector: 'autoComplete-component',
    templateUrl: 'autoComplete.component.html',
    moduleId: module.id
})
export class AutoComplete {
    @ViewChild('autocomplete') public autocomplete: AutoCompleteComponent;

    public listItems: Array<string> = [
        "Albania",
        "Andorra",
        "Armenia",
        "Austria",
        "Azerbaijan",
        "Belarus",
        "Belgium",
        "Bosnia & Herzegovina",
        "Bulgaria",
        "Croatia",
        "Cyprus",
        "Czech Republic",
        "Denmark",
        "Estonia",
        "Finland",
        "France",
        "Georgia",
        "Germany",
        "Greece",
        "Hungary",
        "Iceland",
        "Ireland",
        "Italy",
        "Kosovo",
        "Latvia",
        "Liechtenstein",
        "Lithuania",
        "Luxembourg",
        "Macedonia",
        "Malta",
        "Moldova",
        "Monaco",
        "Montenegro",
        "Netherlands",
        "Norway",
        "Poland",
        "Portugal",
        "Romania",
        "Russia",
        "San Marino",
        "Serbia",
        "Slovakia",
        "Slovenia",
        "Spain",
        "Sweden",
        "Switzerland",
        "Turkey",
        "Ukraine",
        "United Kingdom",
        "Vatican City"
    ];

    public data: Array<string>;

    handleFilter(value: any) {
        console.log(typeof (value));
        if (value.length >= 3) {
            this.data = this.listItems.filter((s) => s.toLowerCase().indexOf(value.toLowerCase()) !== -1);
        } else {
            this.autocomplete.toggle(false);
        }
    }
}
