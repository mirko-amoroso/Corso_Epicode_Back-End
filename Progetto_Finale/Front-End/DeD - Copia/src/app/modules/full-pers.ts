import { IClassi } from "./classi";
import { IPersonaggio } from "./personaggio";
import { ITiriSalvezza } from "./tiri-salvezza";

export interface IFullPers {
  classi : IClassi,
  persoanggio :IPersonaggio,
  tiriSalvezza : ITiriSalvezza
}
