import { Component } from '@angular/core';
import { NavigationExtras, Router } from '@angular/router';
import { Technology } from '../models/technology';
import { TechRadarServiceService } from '../tech-radar-service.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminComponent {
  constructor(techRadarService: TechRadarServiceService, private router: Router) {
    techRadarService.GetAllTechnologies().subscribe(value => {
      for(const technology of value){
        this.technologies.push(technology)
      }
    })
  }

  public technologies: Technology[] = [];

  public openEditPage(technology: Technology) {
      const navigationExtras: NavigationExtras = {
        state: { addMode: false, radarItem: technology }
      }

      this.router.navigateByUrl('edit', navigationExtras)
  }

  public openAddPage() {
    const navigationExtras: NavigationExtras = {
      state: { addMode: true}
    }
    this.router.navigateByUrl('edit', navigationExtras)
  }
  
}
