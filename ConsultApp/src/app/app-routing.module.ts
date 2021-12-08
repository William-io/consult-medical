import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllComponent } from './pages/all/all.component';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';
import { NewComponent } from './pages/new/new.component';
import { TodayComponent } from './pages/today/today.component';
import { TomorrowComponent } from './pages/tomorrow/tomorrow.component';

const routes: Routes = [
  // { path: "", component: HomeComponent, },
  // { path: "login", component: LoginComponent },
  { path: 'login', component: LoginComponent },
  {
    path: '', component: HomeComponent, children: [
      { path: '', component: TodayComponent },
      { path: 'tomorrow', component: TomorrowComponent },
      { path: 'all', component: AllComponent },
      { path: 'new', component: NewComponent },
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
