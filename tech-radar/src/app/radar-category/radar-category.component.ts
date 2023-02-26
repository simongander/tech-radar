import { Component } from '@angular/core';
import { TechRadarServiceService } from '../tech-radar-service.service';
import { RouterModule, ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { Technology } from '../models/technology';
import { Ring } from '../models/ring';
import { Category } from '../models/category';

@Component({
  selector: 'app-radar-category',
  templateUrl: './radar-category.component.html',
  styleUrls: ['./radar-category.component.scss']
})
export class RadarCategoryComponent {
  constructor(techRadarService: TechRadarServiceService, private route: ActivatedRoute) {
    this.route.paramMap.subscribe(params => {
      this.categoryName = params.get('category')!
      techRadarService.GetCategories().subscribe(value => {
        for(const category of value){
          this.categories.push(category) 
        }
        this.category = this.categories.find(c => c.name === this.categoryName)!!
        techRadarService.GetTechnologies(this.category.categoryId).subscribe(value => {
          for(const technology of value){
            this.technologies.push(technology)
          }
          });
      });
    })
    techRadarService.GetRings().subscribe(value => {
      for(const ring of value){
        this.rings.push(ring)
      }
    });
  }

  public name: string = "Simon"

  public rings: Ring[] = []
  public categories: Category[] = []
  public technologies: Technology[] = []
  public columns: string[] = ["name", "description", "explanation"]
  public categoryName: string = ""
  public category: Category = { categoryId: 0, name: "", description: ""}

  public getTechnologies(ringId: number): Technology[]  {
    return this.technologies.filter(tech => tech.ringId === ringId)
  }
}
