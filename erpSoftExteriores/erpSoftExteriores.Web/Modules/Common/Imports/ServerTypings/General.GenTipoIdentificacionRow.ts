namespace erpSoftExteriores.General {
    export interface GenTipoIdentificacionRow {
        Id?: number;
        Nombre?: string;
    }

    export namespace GenTipoIdentificacionRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenTipoIdentificacion';
        export const lookupKey = 'General.TiposdeIdentificacion';

        export function getLookup(): Q.Lookup<GenTipoIdentificacionRow> {
            return Q.getLookup<GenTipoIdentificacionRow>('General.TiposdeIdentificacion');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Nombre: string;
        }

        ['Id', 'Nombre'].forEach(x => (<any>Fields)[x] = x);
    }
}

