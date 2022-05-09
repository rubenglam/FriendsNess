import { Component, OnInit } from '@angular/core';
import { ExercicesService } from '../../../../core/http/exercices.service';
import { Exercice } from '../../../../core/models/exercices/exercice.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-exercices-index-page',
  templateUrl: './exercices-index-page.component.html',
  styleUrls: ['./exercices-index-page.component.css']
})
export class ExercicesIndexPageComponent implements OnInit {
  exercices? : Exercice[];

  constructor(
    private exercicesService : ExercicesService
  ) { }

  ngOnInit(): void {
    this.exercicesService.getExercices().subscribe(data => {
      this.exercices = data;
    });
  }
}