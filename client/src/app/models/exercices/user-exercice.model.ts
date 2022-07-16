import { ExerciceSet } from './exercice-set.model';
import { User } from '../users/user.model';
import { BaseEntity } from '../base-entity.model';
import { Exercice } from './exercice.model';

export interface UserExercice {
  user: User;
  exercice: Exercice;
  exerciceSets: ExerciceSet[];
}
