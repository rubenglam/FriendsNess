import { Component, Input, OnInit } from '@angular/core';
import { ExerciceCategory } from '../../../../core/models/exercices/exercice.model';
import {
  Exercice,
  ExerciceBodyPart,
} from '../../../../core/models/exercices/exercice.model';

@Component({
  selector: 'app-exercice-card-item',
  templateUrl: './exercice-card-item.component.html',
  styleUrls: ['./exercice-card-item.component.css'],
})
export class ExerciceCardItemComponent implements OnInit {
  @Input()
  exercice: Exercice;
  exerciceBodyPart: string;
  exerciceCategory: string;

  constructor() {}

  ngOnInit() {
    this.exerciceBodyPart = ExerciceBodyPart[this.exercice.bodyPart];
    this.exerciceCategory = ExerciceCategory[this.exercice.category];
  }
}
