import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './pages/home/home.component';
import { CardComponent } from './components/card/card.component';
import { ButtonComponent } from './components/button/button.component';
import { LoginComponent } from './pages/login/login.component';
import { UserCardComponent } from './components/user-card/user-card.component';
import { TabsComponent } from './components/tabs/tabs.component';
import { ConsultListComponent } from './components/consult-list/consult-list.component';
import { AllComponent } from './pages/all/all.component';
import { ConsultTodayComponent } from './pages/consult-today/consult-today.component';
import { SheduledConsultComponent } from './pages/sheduled-consult/sheduled-consult.component';
import { NewConsultComponent } from './pages/new-consult/new-consult.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    CardComponent,
    ButtonComponent,
    LoginComponent,
    UserCardComponent,
    TabsComponent,
    ConsultListComponent,
    AllComponent,
    ConsultTodayComponent,
    SheduledConsultComponent,
    NewConsultComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
