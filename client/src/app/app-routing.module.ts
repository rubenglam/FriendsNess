import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExercicesIndexPageComponent } from './modules/exercices/pages/index/exercices-index-page.component';
import { HomeIndexPageComponent } from './modules/home/pages/home-index-page/home-index-page.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: 'home' },
  { path: 'home', component: HomeIndexPageComponent },
  { path: 'exercices', component: ExercicesIndexPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
