import { BaseEntity } from '../base-entity.model';
import { ApplicationUser } from '../users/application-user.model';
import { PlanningExerciceSet } from './planning-exercice-set.model';

export interface Planning extends BaseEntity {
  date: string;
  userId: number;
  user: ApplicationUser;
  planningExercicesSets: PlanningExerciceSet[];
}
