import { NgModule } from '@angular/core';
import { ExercicesIndexPageComponent } from './pages/index/exercices-index-page.component';
import { CommonModule } from '@angular/common';
import { ExerciceCardItemComponent } from './components/card-item/exercice-card-item.component';
import { ExercicesSearchInputComponent } from './components/exercices-search-input/exercices-search-input.component';
import { FormsModule } from '@angular/forms';
import { ExercicesRoutingModule } from './exercices-routing.module';

@NgModule({
  declarations: [
    ExercicesIndexPageComponent,
    ExerciceCardItemComponent,
    ExercicesSearchInputComponent
  ],
  exports: [
    ExercicesIndexPageComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ExercicesRoutingModule
  ]
})
export class ExercicesModule {}
