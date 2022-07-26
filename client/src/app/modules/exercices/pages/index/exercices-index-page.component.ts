import { Component, OnInit } from '@angular/core';
import { Exercice, ExerciceBodyPart, ExerciceCategory } from '../../../../models/exercices/exercice.model';
import { tap, map, Observable, switchMap } from 'rxjs';
import { ExercicesService } from '../../services/exercices.service';
import { UserExercice } from 'src/app/models/exercices/user-exercice.model';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
	selector: 'app-exercices-index-page',
	templateUrl: './exercices-index-page.component.html',
	styleUrls: ['./exercices-index-page.component.css'],
})
export class ExercicesIndexPageComponent implements OnInit {
	searchForm: FormGroup = this.fb.group({
		searchControl: [],
	});

	exercices: Exercice[];

	exercicesBodyParts: string[];
	exercicesCategories: ExerciceCategory[];

	constructor(private exercicesService: ExercicesService, private fb: FormBuilder, private router: Router) {
		this.exercicesBodyParts = Object.keys(ExerciceBodyPart).filter(x => isNaN(Number(x)));
	}

	ngOnInit(): void {
		this.searchForm
			.get('searchControl')
			?.valueChanges.pipe(
				tap(resp => console.log(resp)),
				switchMap(searchString => this.getExercicesByName(searchString))
			)
			.subscribe(exercices => {
				this.exercices = exercices;
			});
		this.getExercices();
	}

	onCardExerciceClicked(exerciceId: number) {
		this.router.navigate(['/exercices', exerciceId]);
	}

	getExercices() {
		this.exercicesService.getExercices().subscribe(data => {
			this.exercices = data;
		});
	}

	getExercicesByName(exerciceName: string) {
		return this.exercicesService
			.getExercices()
			.pipe(map(exercices => exercices.filter(exercice => exercice.name.toLowerCase().includes(exerciceName.toLowerCase()))));
	}
}
