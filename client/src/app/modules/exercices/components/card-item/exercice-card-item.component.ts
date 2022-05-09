import { Component, Input, OnInit } from '@angular/core';
import { Exercice } from '../../../../core/models/exercices/exercice.model';

@Component({
  selector: 'app-exercice-card-item',
  templateUrl: './exercice-card-item.component.html',
  styleUrls: ['./exercice-card-item.component.css']
})
export class ExerciceCardItemComponent implements OnInit {

  @Input()
  exercice: Exercice | undefined;

  constructor() { }

  ngOnInit() {
  }

}
