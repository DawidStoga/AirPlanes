import { Component, OnInit } from '@angular/core';
import { Message } from '@angular/compiler/src/i18n/i18n_ast';
import { Machine } from '../Model/machine';
import { PlaneService } from '../plane.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-airplane',
  templateUrl: './airplane.component.html',
  styleUrls: ['./airplane.component.css']
})
export class AirplaneComponent implements OnInit {

    //machines: Observable<Machine[]>;
    machines:  Machine[];

   testMachines: Machine[] = [
        { id: 11, name: "A320", Smodel: "AirBus", Stype: "A380" },
        { id: 12, name: 'A380', Smodel: "AirBus", Stype: "A380" },
        { id: 13, name: 'A318', Smodel: "AirBus", Stype: "A380" },
        { id: 18, name: 'CRJ', Smodel: "AirBus", Stype: "A380" },
        { id: 19, name: 'Challenger', Smodel: "AirBus", Stype: "A380" },
        { id: 20, name: 'Learjet', Smodel: "AirBus", Stype: "A380" },
    ];
   plane: string  ="None";
   selectedPlane: Machine;

    getPlanes(): void 
    {
      //this.machines = this.planeService.getPlanes();
        this.planeService.getPlanes().subscribe(
            (machine: Machine[]) => {
                this.machines = machine;
                var mach = machine;


                //this.machines = this.testMachines;

                console.log(machine);}
        );
    }
    add(name: string): void {
      name = name.trim();
      if (!name) { return; }
      this.planeService.addMachine({ name } as Machine)
        .subscribe(hero => {
          this.machines.push(hero);
        });
    }

    delete(planeToDelete: Machine): void {
      this.machines= this.machines.filter(h => h !== planeToDelete);
      this.planeService.deletePlane(planeToDelete).subscribe();
    }

   onSelect(ClickedPlane: Machine)
   {
     this.selectedPlane  = ClickedPlane;
   }

  constructor(private planeService: PlaneService) { 
  }
  ngOnInit() { 
     this.getPlanes();
  }

}
