import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RadarCategoryComponent } from './radar-category/radar-category.component';
import { RadarComponent } from './radar/radar.component';

const routes: Routes = [
  { path: 'category/:category', component: RadarCategoryComponent },
  { path: '', component: RadarComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
