import { Injectable } from '@angular/core';
import { Technology } from './models/technology';
import { HttpClient } from '@angular/common/http'
import { from, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TechRadarServiceService {

  constructor(private http: HttpClient) {
    //const test = this.http.get<Technology[]>("/test")
   }

  GetRings(): Observable<string> {
    return from([
      "Assess",
      "Trial",
      "Adopt",
      "Hold"
    ])
  }

  GetCategories(): Observable<string> {
    return from([
      "Techniques",
      "Platforms",
      "Tools",
      "Languages & Frameworks"
    ])
  }

  GetTechnologies(): Observable<Technology> {
    return from([
      {
        name: "Angular",
        description: "Js Framework",
        category: "Languages & Frameworks",
        ring: "hold"
      },
      {
        name: "vue.js",
        description: "Js Framework",
        category: "Languages & Frameworks",
        ring: "hold"
      }
    ])
  }
}
