import { Component, OnInit } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-all',
  templateUrl: './all.component.html',
  styleUrls: ['./all.component.css']
})
export class AllComponent implements OnInit {
  public consults: any[] = null;

  constructor(
    private service: DataService,
    private afAuth: AngularFireAuth,
  ) { }

  ngOnInit(): void {
    this.afAuth.idToken.subscribe(token => {
      this.service.getAllConsults(token).subscribe((data: any) => this.consults = data);
    });
  }
}
