import { BaseEntity } from "../base-entity.model";
import { UserExercice } from '../exercices/user-exercice.model';

export interface User extends BaseEntity {
  email: string;
  name: string;
  role: string;
  google: boolean;
  username: string;

  userExercices: UserExercice[];
}
