import { Component, OnInit } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {}
  loggedIn: boolean;

  constructor(private accountService: AccountService) { }

  ngOnInit(): void {
  }

  login() {
    this.accountService.login(this.model).subscribe(
      (response: any) => {
        console.log(response); // In ra dữ liệu trả về từ yêu cầu HTTP
        this.loggedIn = true;
      }, 
      (error: any) => {
        console.log(error); // In ra thông tin lỗi nếu có
      }
    );
  }
  

}
