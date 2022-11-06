import { HttpClient, HttpClientModule } from '@angular/common/http';
import { async, TestBed } from '@angular/core/testing';
import { Router, RouterModule } from '@angular/router';
import { stream } from 'xlsx';
import { ApilistService } from '../apilist.service';

import { AdminService } from './admin.service';

describe('AdminService', () => {
  let service: AdminService;
  let http:HttpClient;
  let apilist:ApilistService;
  let router:Router;
  

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule, RouterModule]
    });
   
    service = TestBed.inject(AdminService);
    http= TestBed.inject(HttpClient);  
    apilist=TestBed.inject(ApilistService);
    router=TestBed.inject(Router); 
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
  it('should be admin data', () => {
    var test={
      Email:'test@simple.com',
      Status:1
    }
    let data=service.AdmionDataService(test);
    expect(service).toBeTruthy();
  });
});
