import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TestBed } from '@angular/core/testing';
import { ApilistService } from '../apilist.service';

import { CreaterequestService } from './createrequest.service';

describe('CreaterequestService', () => {
  let service: CreaterequestService;
  let http:HttpClient;
  let apilist:ApilistService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule]
    });
    service = TestBed.inject(CreaterequestService);
    http= TestBed.inject(HttpClient);
    apilist=TestBed.inject(ApilistService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
