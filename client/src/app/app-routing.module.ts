import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeIndexPageComponent } from './modules/home/pages/home-index-page/home-index-page.component';
import { NotFoundComponent } from './shared/not-found/not-found.component';
import { SharedModule } from './shared/shared.module';
import { AuthGuard } from './modules/auth/guards/auth.guard';

const routes: Routes = [
  { path: '', component: HomeIndexPageComponent, pathMatch: 'full' },
  { path: 'home', pathMatch: 'full', redirectTo: '' },
  {
    path: 'auth',
    loadChildren: () =>
      import('./modules/auth/auth.module').then(module => module.AuthModule),
  },
  {
    path: 'workouts',
    canLoad: [AuthGuard],
    canActivate: [AuthGuard],
    loadChildren: () =>
      import('./modules/workouts/workouts.module').then(
        module => module.WorkoutsModule
      ),
  },
  {
    path: 'exercices',
    canLoad: [AuthGuard],
    canActivate: [AuthGuard],
    loadChildren: () =>
      import('./modules/exercices/exercices.module').then(
        module => module.ExercicesModule
      ),
  }, {
    path: "profile",
    canLoad: [AuthGuard],
    canActivate: [AuthGuard],
    loadChildren: () => import("./modules/profile/profile.module").then(module => module.ProfileModule)
  },
  { path: '**', pathMatch: 'full', component: NotFoundComponent },
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes), SharedModule],
  exports: [RouterModule],
})
export class AppRoutingModule { }
