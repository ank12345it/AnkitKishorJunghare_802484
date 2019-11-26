import { TestBed } from '@angular/core/testing';

import { LoginSharedService } from './login-shared.service';

describe('LoginSharedService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LoginSharedService = TestBed.get(LoginSharedService);
    expect(service).toBeTruthy();
  });
});
