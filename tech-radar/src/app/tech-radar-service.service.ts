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
   }

  GetRings(): Observable<Ring[]> {
    return this.http.get<Ring[]>(this.baseUrl + "/ring/getRings");
  }

  GetCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(this.baseUrl + "/category/GetCategories");
  }

  GetTechnologies(categoryId: number): Observable<Technology[]> {
    return this.http
      .get<Technology[]>(this.baseUrl + "/technology/getTechnologiesInCategory?categoryId=" + categoryId);
  }

  AddOrEditTechnology(createNew: boolean, technology: Technology) : Observable<Technology> {
    return this.http.post<Technology>(this.baseUrl + "/technology/addTechnology?createNew=" + true, technology)
  }
}
