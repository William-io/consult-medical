import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllComponent } from './pages/all/all.component';
import { ConsultTodayComponent } from './pages/consult-today/consult-today.component';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';
import { NewConsultComponent } from './pages/new-consult/new-consult.component';
import { SheduledConsultComponent } from './pages/sheduled-consult/sheduled-consult.component';

const routes: Routes = [
  { path: "login", component: LoginComponent },
  {
    path: '', component: HomeComponent, children: [
      { path: '', component: ConsultTodayComponent },
      { path: 'scheduled-consult', component: SheduledConsultComponent },
      { path: 'all', component: AllComponent },
      { path: 'new-consult', component: NewConsultComponent }
    ],
  },
  //
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
