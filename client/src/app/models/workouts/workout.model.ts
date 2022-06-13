import { BaseEntity } from '../base-entity.model';
import { ApplicationUser } from '../users/application-user.model';
import { WorkoutExerciceSet } from './workout-exercice-set.model';

export interface Workout extends BaseEntity {
  date: string;
  userId: number;
  user: ApplicationUser;
  planningExercicesSets: WorkoutExerciceSet[];
}
