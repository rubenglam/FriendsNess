import { Component, OnInit } from '@angular/core';
import {
  Exercice,
  ExerciceBodyPart,
  ExerciceCategory,
} from '../../../../models/exercices/exercice.model';
import { Observable } from 'rxjs';
import { ExercicesService } from '../../services/exercices.service';
import { UserExercice } from 'src/app/models/exercices/user-exercice.model';

@Component({
  selector: 'app-exercices-index-page',
  templateUrl: './exercices-index-page.component.html',
  styleUrls: ['./exercices-index-page.component.css'],
})
export class ExercicesIndexPageComponent implements OnInit {
  myExercices: UserExercice[];

  exercicesBodyParts: string[];
  exercicesCategories: ExerciceCategory[];

  constructor(private exercicesService: ExercicesService) {
    this.exercicesBodyParts = Object.keys(ExerciceBodyPart).filter((x) =>
      isNaN(Number(x))
    );
  }

  ngOnInit(): void {
    this.getMyExercices();
  }

  getMyExercices() {
    this.exercicesService.getMyExercices().subscribe((data) => {
      console.log(data);
      this.myExercices = data;
    });
  }
}
