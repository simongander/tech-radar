import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Technology } from '../models/technology';
import { TechRadarServiceService } from '../tech-radar-service.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent {

  constructor(techRadarService: TechRadarServiceService, private router: Router){
    techRadarService.GetRings().subscribe(value => { this.rings.push(value) });
    techRadarService.GetCategories().subscribe(value => { this.categories.push(value) });
  }

  @Input()
  addMode: boolean = false;

  @Input()
  radarItem: Technology = { name:"", description:"", category:"", ring: "" };

  categories: string[] = [];
  rings: string[] = [];

  saveAndPublish() {
    
  }
  
  save() {
    
  }

  exit() {
    this.router.navigateByUrl('admin')
  }
}
