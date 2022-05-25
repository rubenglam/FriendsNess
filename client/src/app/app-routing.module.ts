import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExercicesIndexPageComponent } from './modules/exercices/pages/index/exercices-index-page.component';
import { HomeIndexPageComponent } from './modules/home/pages/home-index-page/home-index-page.component';
import { LoginComponent } from './modules/auth/pages/login/login.component';
import { RegisterComponent } from './modules/auth/pages/register/register.component';

const routes: Routes = [
  { path: '', component: HomeIndexPageComponent, pathMatch: 'full' },
  { path: 'home', pathMatch: 'full', redirectTo: '' },
  {
    path: 'auth',
    loadChildren: () =>
      import('./modules/auth/auth.module').then((module) => module.AuthModule),
  },
  {
    path: 'exercices',
    loadChildren: () =>
      import('./modules/exercices/exercices.module').then(
        (module) => module.ExercicesModule
      ),
  },
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
