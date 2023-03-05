import { Component, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-radar',
  templateUrl: './radar.component.html',
  styleUrls: ['./radar.component.scss']
})
export class RadarComponent {

  constructor(private router: Router) {
  }

  openCategory(category: string) {
    this.router.navigateByUrl('category/' + category);
  }
}
