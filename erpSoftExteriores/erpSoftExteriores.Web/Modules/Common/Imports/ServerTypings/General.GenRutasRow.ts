namespace erpSoftExteriores.General {
    export interface GenRutasRow {
        Id?: number;
        Nombre?: string;
        Descripcion?: string;
        Carreteras?: string;
    }

    export namespace GenRutasRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenRutas';
        export const lookupKey = 'General.Rutas';

        export function getLookup(): Q.Lookup<GenRutasRow> {
            return Q.getLookup<GenRutasRow>('General.Rutas');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Nombre: string;
            export declare const Descripcion: string;
            export declare const Carreteras: string;
        }

        ['Id', 'Nombre', 'Descripcion', 'Carreteras'].forEach(x => (<any>Fields)[x] = x);
    }
}

