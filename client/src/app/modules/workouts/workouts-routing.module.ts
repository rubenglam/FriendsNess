import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WorkoutsIndexPageComponent } from './pages/index/workouts-index-page.component';
import { WorkoutsCreatePageComponent } from './pages/create/workouts-create-page.component';
import { WorkoutsUpdatePageComponent } from './pages/update/workouts-update-page.component';
import { WorkoutsDetailsPageComponent } from './pages/details/workouts-details-page.component';

const routes: Routes = [
  {
    path: '',
    children: [
      {
        path: 'index',
        component: WorkoutsIndexPageComponent,
      },
      {
        path: 'create',
        component: WorkoutsCreatePageComponent,
      },
      {
        path: 'update/:id',
        component: WorkoutsUpdatePageComponent,
      },
      {
        path: ':id',
        component: WorkoutsDetailsPageComponent,
      },
      {
        path: '**',
        redirectTo: 'index',
      },
    ],
  },
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class WorkoutsRoutingModule {}
