import { ExerciceSet } from '../exercices/exercice-set.model';
import { BaseEntity } from '../base-entity.model';

export interface WorkoutExerciceSet extends BaseEntity {
  completed: boolean;
  exerciceSetId: number;
  exerciceSet: ExerciceSet;
}
