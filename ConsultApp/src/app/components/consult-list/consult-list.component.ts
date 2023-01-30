import { Component, Input, OnInit } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-consult-list',
  templateUrl: './consult-list.component.html',
  styleUrls: ['./consult-list.component.css']
})
export class ConsultListComponent implements OnInit {
  @Input() consults: any = null;

  constructor(
    private service: DataService,
    private afAuth: AngularFireAuth,
  ) { }

  ngOnInit(): void {
  }

  markAsDone(consult) {
    this.afAuth.idToken.subscribe(token => {
      const data = { id: consult.id };
      this.service.markAsDone(data, token).subscribe(res => { consult.done = true });
    });
  }

}
