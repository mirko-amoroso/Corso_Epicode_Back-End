import { IAbilita } from "./abilita";
import { IArmatura } from "./armatura";
import { IArmi } from "./armi";
import { IAttributi } from "./attributi";
import { IBackground } from "./background";
import { IClassi } from "./classi";
import { ITiriSalvezza } from "./tiri-salvezza";

export interface IPersonaggio {
    personaggioID: number;
    idUtente: number;
    nome: string;
    utente: any;
    razza: string;
    moneteOro : number;
    armi: IArmi | null;
    armatura: IArmatura[] | null;
    inventario: any;
    abilita: IAbilita | null;
    attributi: IAttributi | null;
    backgound: IBackground | null;
    classi: IClassi[] | null,
    tiri_Salvezza: ITiriSalvezza | null;
}
