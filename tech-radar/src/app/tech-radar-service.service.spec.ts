import { TestBed } from '@angular/core/testing';

import { TechRadarServiceService } from './tech-radar-service.service';

describe('TechRadarServiceService', () => {
  let service: TechRadarServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TechRadarServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
