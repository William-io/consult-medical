import { Component, OnInit } from '@angular/core';

import { AngularFireAuth } from '@angular/fire/compat/auth';
// import * as firebase from 'firebase/app';
import firebase from 'firebase/compat/app';
import 'firebase/auth'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(
    private afAuth: AngularFireAuth,

  ) { }

  ngOnInit(): void {

  }

  login() {
    this.afAuth.signInWithPopup(new firebase.auth.GoogleAuthProvider());
  }

}
