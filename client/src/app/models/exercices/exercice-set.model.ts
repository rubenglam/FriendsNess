import { UserExercice } from './user-exercice.model';
import { BaseEntity } from '../base-entity.model';

export interface ExerciceSet extends BaseEntity {
  weight: number;
  repetitions: number;
  sets: number;
  date: string;
  userExerciceId: number;
  userExercice: UserExercice;
}
