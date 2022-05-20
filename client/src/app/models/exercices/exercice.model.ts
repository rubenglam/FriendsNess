import { BaseEntity } from '../base-entity.model';
import { ExerciceSet } from './exercice-set.model';

export enum ExerciceBodyPart {
  Back,
  Biceps,
  Chest,
  Core,
  Forearms,
  Legs,
  Shoulders,
  Triceps,
  WholeBody,
}

export enum ExerciceCategory {
  Barbell,
  Bodyweight,
  Cable,
  Dumbbell,
  Machine,
  Olympic,
}

export interface Exercice extends BaseEntity {
  name: string;
  image: string;
  category: ExerciceCategory;
  bodyPart: ExerciceBodyPart;
  exerciceUsers: ExerciceSet[];
}
