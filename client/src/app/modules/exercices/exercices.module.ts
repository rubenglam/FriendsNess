import { NgModule } from '@angular/core';
import { ExercicesIndexPageComponent } from './pages/index/exercices-index-page.component';
import { CommonModule } from '@angular/common';
import { ExerciceCardItemComponent } from './components/card-item/exercice-card-item.component';

@NgModule({
  declarations: [
    ExercicesIndexPageComponent,
    ExerciceCardItemComponent
  ],
  exports: [
    ExercicesIndexPageComponent
  ],
  imports: [
    CommonModule
  ]
})
export class ExercicesModule {}
