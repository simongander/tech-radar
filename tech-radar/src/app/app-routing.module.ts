import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { EditComponent } from './edit/edit.component';
import { RadarCategoryComponent } from './radar-category/radar-category.component';
import { RadarComponent } from './radar/radar.component';

const routes: Routes = [
  { path: 'category/:category', component: RadarCategoryComponent },
  { path: '', component: RadarComponent },
  { path: 'admin', component: AdminComponent },
  { path: 'edit', component: EditComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
