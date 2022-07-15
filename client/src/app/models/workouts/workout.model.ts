import { BaseEntity } from '../base-entity.model';
import { User } from '../users/user.model';
import { WorkoutExerciceSet } from './workout-exercice-set.model';

export interface Workout extends BaseEntity {
  date: string;
  userId: number;
  user: User;
  planningExercicesSets: WorkoutExerciceSet[];
}
