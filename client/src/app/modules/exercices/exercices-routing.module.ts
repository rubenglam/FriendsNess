import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ExercicesIndexPageComponent } from './pages/index/exercices-index-page.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'index',
        component: ExercicesIndexPageComponent,
      },
      {
        path: '**',
        redirectTo: 'index',
      },
    ],
  },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ExercicesRoutingModule {}