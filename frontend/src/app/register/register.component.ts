import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model:any={};
  register(){
    console.log(this.model)
  }

  constructor() { }

  ngOnInit(): void {
  }

}
