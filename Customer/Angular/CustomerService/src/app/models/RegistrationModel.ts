
import { NgForm,FormGroup,Validators,FormBuilder,FormControl } from "@angular/forms";

export class RegistrationModel{
    registrationId:number=0;
    CustomerName:string='';
    CustomerEmail:string='';
    CustomerPassword:string='';
    ConfirmCustomerPassword:string='';
    CustomerPhoneNumber:string='';
    CustomerPanCard:string='';
    CustomerDOB:any='28-10-2022';
    CustomerCountry:string='';
    CustomerState:any='';
    CustomerDistrict:any='';
    CustomerAddress:string='';

    public formCustomerGroup:FormGroup;
    constructor(){
    var _builder=new FormBuilder();
    this.formCustomerGroup=_builder.group({
        CustomerName:new FormControl('',Validators.compose([Validators.required,Validators.pattern("^[a-zA-Z ]+$")])),
        CustomerEmail:new FormControl('',Validators.compose([Validators.required,Validators.email])),        
        CustomerPhoneNumber:new FormControl('',Validators.compose([Validators.required,Validators.pattern("[0-9]+")])),
        CustomerPanCard:new FormControl('',Validators.compose([Validators.required,Validators.pattern("[A-Z]{5}[0-9]{4}[A-Z]{1}")])),
        CustomerDOB:new FormControl('',Validators.compose([Validators.required])),
        CustomerCountry:new FormControl('',Validators.compose([Validators.required])),
        CustomerState:new FormControl('',Validators.compose([Validators.required])),
        CustomerDistrict:new FormControl('',Validators.compose([Validators.required])),
        CustomerAddress:new FormControl('',Validators.compose([Validators.required])),
        CustomerPassword:new FormControl('',Validators.compose([Validators.required,Validators.pattern("[0-9]+")])),
        ConfirmCustomerPassword:['', [Validators.required,,Validators.minLength(3)]],
   
 
}, { validator: this.passwordMatchValidator });
    }
    passwordMatchValidator=(g: FormGroup | any)=> {
        g.controls['ConfirmCustomerPassword'].setErrors(g.get('CustomerPassword').value === g.get('ConfirmCustomerPassword').value
           ? g.controls['ConfirmCustomerPassword'].errors : {'notSame': true});
        return g;
      }
}