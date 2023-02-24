import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Technology } from '../models/technology';
import { TechRadarServiceService } from '../tech-radar-service.service';

@Component({
  selector: 'app-radar',
  templateUrl: './radar.component.html',
  styleUrls: ['./radar.component.scss']
})
export class RadarComponent {

  constructor(techRadarService: TechRadarServiceService, private router: Router) {
  }

  @Input()
  public name: string = "Simon"

  openCategory(category: string) {
    this.router.navigateByUrl('category/' + category);
  }
}
