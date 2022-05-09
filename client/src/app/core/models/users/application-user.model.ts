import { BaseEntity } from "../base-entity.model";
import { UserExercice } from '../exercices/user-exercice.model';

export interface ApplicationUser extends BaseEntity {
  userExercices: UserExercice[];
}
