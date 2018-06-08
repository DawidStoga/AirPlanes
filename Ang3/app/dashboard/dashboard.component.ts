import { Component, OnInit } from '@angular/core';
import { Machine } from '../Model/machine';
 
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [ './dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {
  planes: Machine[] = [];
 
 
  ngOnInit() {
   
  }
 

}