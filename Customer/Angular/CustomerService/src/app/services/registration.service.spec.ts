import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TestBed } from '@angular/core/testing';
import { ApilistService } from '../apilist.service';

import { RegistrationService } from './registration.service';

describe('RegistrationService', () => {
  let service: RegistrationService;
  let http:HttpClient;
  let apilist:ApilistService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule]
    });
    service = TestBed.inject(RegistrationService);
    http= TestBed.inject(HttpClient);
    apilist=TestBed.inject(ApilistService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
