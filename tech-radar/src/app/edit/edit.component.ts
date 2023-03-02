import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Category } from '../models/category';
import { Ring } from '../models/ring';
import { Technology } from '../models/technology';
import { TechRadarServiceService } from '../tech-radar-service.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent {

public techRadarService: TechRadarServiceService

  constructor(techRadarService: TechRadarServiceService, private router: Router){
    techRadarService.GetRings().subscribe(value => {
      for(const ring of value){
        this.rings.push(ring)
      }
     });
    techRadarService.GetCategories().subscribe(value => {
      for(const category of value){
        this.categories.push(category) 
      }
     });

     this.techRadarService = techRadarService
  }

  @Input()
  addMode: boolean = false;

  @Input()
  radarItem: Technology = { technologyId: 0, name:"", description:"", categoryId: 0, ringId: 0 };

  categories: Category[] = [];
  rings: Ring[] = [];

  saveAndPublish() {
    
  }
  
  save() {
    
  }

  exit() {
    this.router.navigateByUrl('admin')
  }
}
