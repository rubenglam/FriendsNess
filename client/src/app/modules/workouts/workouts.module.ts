import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WorkoutsRoutingModule } from './workouts-routing.module';
import { WorkoutsCreatePageComponent } from './pages/create/workouts-create-page.component';
import { WorkoutsDetailsPageComponent } from './pages/details/workouts-details-page.component';
import { WorkoutsIndexPageComponent } from './pages/index/workouts-index-page.component';
import { WorkoutsUpdatePageComponent } from './pages/update/workouts-update-page.component';

@NgModule({
  declarations: [
    WorkoutsCreatePageComponent,
    WorkoutsDetailsPageComponent,
    WorkoutsUpdatePageComponent,
    WorkoutsIndexPageComponent,
  ],
  imports: [CommonModule, WorkoutsRoutingModule],
})
export class WorkoutsModule {}
