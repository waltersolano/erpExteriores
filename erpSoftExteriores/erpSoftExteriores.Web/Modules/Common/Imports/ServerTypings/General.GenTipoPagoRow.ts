namespace erpSoftExteriores.General {
    export interface GenTipoPagoRow {
        Id?: number;
        Nombre?: string;
        CantidadDias?: number;
        CantidadMeses?: number;
        Criterios?: string;
        TenantId?: number;
    }

    export namespace GenTipoPagoRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'General.GenTipoPago';
        export const lookupKey = 'General.TiposdePago';

        export function getLookup(): Q.Lookup<GenTipoPagoRow> {
            return Q.getLookup<GenTipoPagoRow>('General.TiposdePago');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Nombre: string;
            export declare const CantidadDias: string;
            export declare const CantidadMeses: string;
            export declare const Criterios: string;
            export declare const TenantId: string;
        }

        ['Id', 'Nombre', 'CantidadDias', 'CantidadMeses', 'Criterios', 'TenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

