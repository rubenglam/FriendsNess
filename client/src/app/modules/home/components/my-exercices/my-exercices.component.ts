import { Component, OnInit } from '@angular/core';
import { UserExercice } from '../../../../models/exercices/user-exercice.model';
import { ExercicesService } from '../../../exercices/services/exercices.service';

@Component({
  selector: 'app-my-exercices',
  templateUrl: './my-exercices.component.html',
  styles: [],
})
export class MyExercicesComponent implements OnInit {
  userExercices: UserExercice[];

  constructor(private exercicesService: ExercicesService) {}

  ngOnInit(): void {
    this.exercicesService.getMyExercices().subscribe((userExercices) => {
      this.userExercices = userExercices;
    });
  }
}
