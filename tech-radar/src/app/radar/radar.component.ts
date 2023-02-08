import { Component, Input } from '@angular/core';
import { Technology } from '../models/technology';
import { TechRadarServiceService } from '../tech-radar-service.service';

@Component({
  selector: 'app-radar',
  templateUrl: './radar.component.html',
  styleUrls: ['./radar.component.scss']
})
export class RadarComponent {

  constructor(techRadarService: TechRadarServiceService) {
    this.rings = techRadarService.GetRings();
    this.categories = techRadarService.GetCategories();
    this.technologies = techRadarService.GetTechnologies();
  }

  @Input()
  public name: string = "Simon"

  public rings: string[]
  public categories: string[]
  public technologies: Technology[]
  public columns: string[] = ["name", "description"]
}
