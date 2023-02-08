import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RadarCategoryComponent } from './radar-category.component';

describe('RadarCategoryComponent', () => {
  let component: RadarCategoryComponent;
  let fixture: ComponentFixture<RadarCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RadarCategoryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RadarCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
