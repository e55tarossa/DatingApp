import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',//Đây là tên thành phần để mình add vào trong appcoponent
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any  = {}

  constructor(public accountService: AccountService) { }

  ngOnInit(): void {
  }

  login(){
    this.accountService.login(this.model).subscribe(repspone =>{
      console.log(repspone);

    }, error => {
      console.log(error);
    })
  }

  logout(){
    this.accountService.logout();
  }
}
