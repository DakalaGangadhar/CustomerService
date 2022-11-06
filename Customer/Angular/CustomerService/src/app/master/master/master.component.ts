import { Component, OnInit } from '@angular/core';
import { LoginService } from 'src/app/services/login.service';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
  styleUrls: ['./master.component.css']
})
export class MasterComponent implements OnInit {

  constructor(private _service:LoginService) { }

  ngOnInit(): void {
  }
  
  LoggedIn(Input:boolean):boolean{    
    if(Input){
      return this._service.logginIn();
    }
    else{
      return !this._service.logginIn();
    }
  }
  Logout(){
    debugger;
    this._service.logoutUser();
    
  }
  customerRoute(){
    localStorage.removeItem('token');
    localStorage.removeItem('email');
    localStorage.removeItem('adminemail') 
  }
  adminRoute(){
    localStorage.removeItem('token');
    localStorage.removeItem('email');
    localStorage.removeItem('adminemail') 
  }

}
