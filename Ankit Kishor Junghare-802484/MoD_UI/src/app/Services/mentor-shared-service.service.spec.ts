import { TestBed } from '@angular/core/testing';

import { MentorSharedServiceService } from './mentor-shared-service.service';

describe('MentorSharedServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MentorSharedServiceService = TestBed.get(MentorSharedServiceService);
    expect(service).toBeTruthy();
  });
});
