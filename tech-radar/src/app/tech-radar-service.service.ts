import { Injectable } from '@angular/core';
import { Technology } from './models/technology';
import { HttpClient } from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class TechRadarServiceService {

  constructor(private http: HttpClient) {
    //const test = this.http.get<Technology[]>("/test")
   }

  GetRings(): string[] {
    return [
      "Assess",
      "Trial",
      "Adopt",
      "Hold"
    ]
  }

  GetCategories(): string[] {
    return [
      "Techniques",
      "Platforms",
      "Tools",
      "Languages & Frameworks"
    ]
  }

  GetTechnologies(): Technology[] {
    return [
      {
        name: "Angular",
        description: "Js Framework",
        category: "Languages & Frameworks"
      },
      {
        name: "vue.js",
        description: "Js Framework",
        category: "Languages & Frameworks"
      }
    ]
  }
}
