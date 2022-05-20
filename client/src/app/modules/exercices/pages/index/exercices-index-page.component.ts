import { Component, OnInit } from '@angular/core';
import { Exercice, ExerciceBodyPart, ExerciceCategory } from '../../../../models/exercices/exercice.model';
import { Observable } from 'rxjs';
import { ExercicesService } from '../../services/exercices.service';

@Component({
  selector: 'app-exercices-index-page',
  templateUrl: './exercices-index-page.component.html',
  styleUrls: ['./exercices-index-page.component.css']
})
export class ExercicesIndexPageComponent implements OnInit {
  exercices? : Exercice[];

  exercicesBodyParts: string[];
  exercicesCategories: ExerciceCategory[];

  constructor(
    private exercicesService : ExercicesService
  ) {
    this.exercicesBodyParts = Object.keys(ExerciceBodyPart).filter(x => isNaN(Number(x)));
  }

  ngOnInit(): void {
    this.exercicesService.getExercices().subscribe(data => {
      this.exercices = data;
    });
  }
}
