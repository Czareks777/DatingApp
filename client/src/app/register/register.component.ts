import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AccountService } from '../_services/account.service';
import { ToastrService } from 'ngx-toastr';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  registerForm: FormGroup = new FormGroup({});
  model: any = {}
  constructor(private accountService: AccountService, private toastr: ToastrService) { }
  ngOnInit(): void {
  }
  register() {
    console.log(this.registerForm?.value);
    // this.accountService.register(this.model).subscribe({
    //   next: () => {
    //     this.cancel();
    //   },
    //   error: error => {
    //     this.toastr.error(error.error),
    //       console.log(error)
    //   }
    // })
  }

  initalizeForm() {
    this.registerForm = new FormGroup({
      username: new FormControl(),
      password: new FormControl(),
      confirmPassword: new FormControl(),

    });
  }


  cancel() {
    this.cancelRegister.emit(false);
  }
}
