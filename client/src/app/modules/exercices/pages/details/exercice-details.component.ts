import { Component, OnInit } from '@angular/core';
import { ExercicesService } from '../../services/exercices.service';
import { Exercice } from '../../../../models/exercices/exercice.model';
import { ActivatedRoute } from '@angular/router';
import { switchMap } from 'rxjs';

@Component({
	selector: 'app-exercice-details',
	templateUrl: './exercice-details.component.html',
	styleUrls: ['./exercice-details.component.css'],
})
export class ExerciceDetailsComponent implements OnInit {
	exerciceId: number;

	exercice: Exercice;

	constructor(private exercicesService: ExercicesService, private activatedRoute: ActivatedRoute) {}

	ngOnInit(): void {
		this.activatedRoute.params.pipe(switchMap(({ id }) => this.exercicesService.getExercice(id))).subscribe(exercice => {
			this.exercice = exercice;
		});
	}
}
