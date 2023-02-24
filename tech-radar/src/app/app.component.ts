import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'tech-radar';

  constructor(private router: Router){

  }

  openAdminPage() {
    this.router.navigateByUrl('admin')
  }
}
