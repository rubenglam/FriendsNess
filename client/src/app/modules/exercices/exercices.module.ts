import { NgModule } from '@angular/core';
import { ExercicesIndexPageComponent } from './pages/index/exercices-index-page.component';
import { CommonModule } from '@angular/common';
import { ExercicesSearchInputComponent } from './components/exercices-search-input/exercices-search-input.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ExercicesRoutingModule } from './exercices-routing.module';
import { SharedModule } from '../../shared/shared.module';
import { AddUserExerciceDialogComponent } from './components/add-user-exercice-dialog/add-user-exercice-dialog.component';
import { ExerciceDetailsComponent } from './pages/details/exercice-details.component';

@NgModule({
	declarations: [ExercicesIndexPageComponent, ExercicesSearchInputComponent, AddUserExerciceDialogComponent, ExerciceDetailsComponent],
	exports: [ExercicesIndexPageComponent],
	imports: [SharedModule, CommonModule, ReactiveFormsModule, FormsModule, ExercicesRoutingModule],
})
export class ExercicesModule {}
