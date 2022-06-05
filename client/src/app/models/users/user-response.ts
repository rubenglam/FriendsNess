import { BaseEntity } from '../base-entity.model';

export interface UserResponse extends BaseEntity {
  email: string;
  userName: string;
}
