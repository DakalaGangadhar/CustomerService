import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TestBed } from '@angular/core/testing';
import { Router, RouterModule } from '@angular/router';
import { ApilistService } from '../apilist.service';

import { LoginService } from './login.service';

describe('LoginService', () => {
  let service: LoginService;
  let http:HttpClient;
  let router:Router;
  let apilist:ApilistService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule,RouterModule]
    });
    service = TestBed.inject(LoginService);
    http= TestBed.inject(HttpClient);
    apilist=TestBed.inject(ApilistService);
    router=TestBed.inject(Router);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
