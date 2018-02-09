import { ISkill } from './iskill.type';

export interface IProfile {
  id: string,
  firstName: string,
  lastName: string,
  title: string,
  level: string,
  skills: ISkill[]
}
