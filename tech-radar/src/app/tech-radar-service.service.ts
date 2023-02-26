import { Injectable } from '@angular/core';
import { Technology } from './models/technology';
import { HttpClient } from '@angular/common/http'
import { from, Observable } from 'rxjs';
import { Ring } from './models/ring';
import { Category } from './models/category';

@Injectable({
  providedIn: 'root'
})
export class TechRadarServiceService {

  private baseUrl: String
  constructor(private http: HttpClient) {
    this.baseUrl = "https://localhost:7192/api"
    //const test = this.http.get<Technology[]>("/test")
   }

  GetRings(): Observable<Ring[]> {
    return this.http.get<Ring[]>(this.baseUrl + "/ring/getRings");
    // return from([
    //   "Assess",
    //   "Trial",
    //   "Adopt",
    //   "Hold"
    // ])
  }

  GetCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(this.baseUrl + "/category/getCategories");
    // return from([
    //   "Techniques",
    //   "Platforms",
    //   "Tools",
    //   "Languages & Frameworks"
    // ])
  }

  GetTechnologies(categoryId: number): Observable<Technology[]> {
    return this.http
      .get<Technology[]>(this.baseUrl + "/ring/getTechnologiesInCategory?categoryId=" + categoryId);
    // return from([
    //   {
    //     technologyId: 1,
    //     name: "Angular",
    //     description: "Js Framework",
    //     category: "Languages & Frameworks",
    //     ring: "hold"
    //   },
    //   {
    //     technologyId: 2,
    //     name: "vue.js",
    //     description: "Js Framework",
    //     category: "Languages & Frameworks",
    //     ring: "hold"
    //   }
    // ])
  }
}
