import { ExerciceSet } from './exercice-set.model';
import { ApplicationUser } from '../users/application-user.model';
import { BaseEntity } from '../base-entity.model';
import { Exercice } from './exercice.model';

export interface UserExercice {
  userId: number;
  user: ApplicationUser;
  exerciceId: number;
  exercice: Exercice;
  exerciceSets: ExerciceSet[];
}
