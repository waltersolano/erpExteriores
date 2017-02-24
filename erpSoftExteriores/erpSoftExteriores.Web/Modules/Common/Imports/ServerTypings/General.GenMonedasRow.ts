namespace erpSoftExteriores.General {
    export interface GenMonedasRow {
        Id?: number;
        Nombre?: string;
        Simbolo?: string;
        Codigo?: string;
        Pais?: string;
        CodigoPais?: string;
    }

    export namespace GenMonedasRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenMonedas';
        export const lookupKey = 'General.Monedas';

        export function getLookup(): Q.Lookup<GenMonedasRow> {
            return Q.getLookup<GenMonedasRow>('General.Monedas');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Nombre: string;
            export declare const Simbolo: string;
            export declare const Codigo: string;
            export declare const Pais: string;
            export declare const CodigoPais: string;
        }

        ['Id', 'Nombre', 'Simbolo', 'Codigo', 'Pais', 'CodigoPais'].forEach(x => (<any>Fields)[x] = x);
    }
}

