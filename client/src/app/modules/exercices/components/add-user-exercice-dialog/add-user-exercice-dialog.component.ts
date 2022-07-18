import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { ExercicesService } from '../../services/exercices.service';
import { Exercice } from '../../../../models/exercices/exercice.model';

@Component({
  selector: 'app-add-user-exercice-dialog',
  templateUrl: './add-user-exercice-dialog.component.html',
})
export class AddUserExerciceDialogComponent implements OnInit {
  form: FormGroup = this.fb.group({ exercice: [] });

  exercices: Exercice[];

  constructor(
    private fb: FormBuilder,
    private exerciceService: ExercicesService
  ) {}

  ngOnInit(): void {
    this.exerciceService.getExercices().subscribe((resp) => {
      this.exercices = resp;
    });
  }

  onExerciceClicked(exercice: Exercice) {
    this.exerciceService.createUserExercice({
      exercice: exercice.id,
    });
  }
}
