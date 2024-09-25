import { IAbilita } from "./abilita";
import { IArmatura } from "./armatura";
import { IArmi } from "./armi";
import { IAttributiModifica } from "./attributiModifica";
import { IBackground } from "./background";
import { IBackgroundModifica } from "./backgroundMdifica";
import { IClassi } from "./classi";
import { ITiriSalvezza } from "./tiri-salvezza";

export interface IPersonaggioModifica {
  personaggioID: number | null;
  idUtente: number;
  nome: string;
  utente: any | null;
  razza: string;
  moneteOro : number | null;
  armi: IArmi | null;
  armatura: IArmatura[] | null;
  inventario: any | null;
  abilita: IAbilita | null;
  attributi: IAttributiModifica | null;
  backgound: IBackgroundModifica | null;
  classi: IClassi[] | null,
  tiri_Salvezza: ITiriSalvezza | null;
}
