import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ExercicesModule } from './modules/exercices/exercices.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { FlexLayoutModule } from '@angular/flex-layout';
import { HomeModule } from './modules/home/home.module';
import { CookieService } from 'ngx-cookie-service';
import { SharedModule } from './shared/shared.module';
import { FormsModule } from '@angular/forms';
import { AuthModule } from './modules/auth/auth.module';
import { WorkoutsModule } from './modules/workouts/workouts.module';
import { ProfileModule } from './modules/profile/profile.module';

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ExercicesModule,
    WorkoutsModule,
    HomeModule,
    SharedModule,
    BrowserAnimationsModule,
    FlexLayoutModule,
    FormsModule,
    AuthModule,
    ProfileModule
  ],
  exports: [],
  providers: [CookieService],
  bootstrap: [AppComponent],
})
export class AppModule { }
