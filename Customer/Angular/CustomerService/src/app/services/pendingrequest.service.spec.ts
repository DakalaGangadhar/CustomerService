import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TestBed } from '@angular/core/testing';
import { Router, RouterModule } from '@angular/router';
import { ApilistService } from '../apilist.service';

import { PendingrequestService } from './pendingrequest.service';

describe('PendingrequestService', () => {
  let service: PendingrequestService;
  let http:HttpClient;
  let router:Router;
  let apilist:ApilistService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule,RouterModule]
    });
    service = TestBed.inject(PendingrequestService);
    http= TestBed.inject(HttpClient);
    apilist=TestBed.inject(ApilistService);
    router=TestBed.inject(Router);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
