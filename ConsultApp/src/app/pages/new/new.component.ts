import { Component, OnInit } from '@angular/core';
import { AngularFireAuth } from '@angular/fire/compat/auth';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { DataService } from 'src/app/data.service';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.css']
})
export class NewComponent implements OnInit {
  public form: FormGroup;

  constructor(
    private fb: FormBuilder,
    private service: DataService,
    private router: Router,
    private afAuth: AngularFireAuth
  ) {
    this.form = this.fb.group({
      description: ['', Validators.compose([
        Validators.minLength(3),
        Validators.maxLength(60),
        Validators.required,
      ])],
      date: [new Date().toJSON().substring(0, 10), Validators.required]
    });
  }

  ngOnInit(): void {
  }

  submit() {
    this.afAuth.idToken.subscribe(token => {
      return this.service.postConsult(this.form.value, token).subscribe(res => {
        this.router.navigateByUrl("/");
      });
    });
  }
}

// If you do not care about strict class initialization, 
// you can disable the feature completely in your [tsconfig.json] by adding a flag to your compiler options
// {
//   "compilerOptions": {
//      "strictPropertyInitialization": false
//    }
//  }