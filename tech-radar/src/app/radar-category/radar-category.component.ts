import { Component } from '@angular/core';
import { TechRadarServiceService } from '../tech-radar-service.service';
import { RouterModule, ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { Technology } from '../models/technology';

@Component({
  selector: 'app-radar-category',
  templateUrl: './radar-category.component.html',
  styleUrls: ['./radar-category.component.scss']
})
export class RadarCategoryComponent {

  constructor(techRadarService: TechRadarServiceService, private route: ActivatedRoute) {
    this.rings = techRadarService.GetRings();
    this.categories = techRadarService.GetCategories();
    this.technologies = techRadarService.GetTechnologies();
    this.route.paramMap.subscribe(params => this.category = params.get('category')!)
  }

  public name: string = "Simon"

  public rings: string[]
  public categories: string[]
  public technologies: Technology[]
  public columns: string[] = ["name", "description"]
  public category: string = ""
}
