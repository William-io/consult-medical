import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  loading = false;

  constructor() { }

  ngOnInit(): void {
  }

  submit() {
    this.loading = true;
  }
}
