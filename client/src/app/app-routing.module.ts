import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExercicesIndexPageComponent } from './modules/exercices/pages/index/exercices-index-page.component';
import { HomeIndexPageComponent } from './modules/home/pages/home-index-page/home-index-page.component';
import { LoginComponent } from './modules/auth/pages/login/login.component';
import { RegisterComponent } from './modules/auth/pages/register/register.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'home' },
  { path: 'home', component: HomeIndexPageComponent, pathMatch: 'full' },
  {
    path: 'exercices',
    component: ExercicesIndexPageComponent,
    pathMatch: 'full',
  },
  { path: 'login', component: LoginComponent, pathMatch: 'full' },
  { path: 'register', component: RegisterComponent, pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
