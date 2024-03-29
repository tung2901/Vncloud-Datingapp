import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = ' The Dating app';
  users: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getUser();
  }

  getUser() {
    this.http.get('https://localhost:5001/API/users').subscribe(
      (response: any) => {
        this.users = response;
      }, 
      (error: any) => {
        console.log(error);
      }
    );
  }
  
}
