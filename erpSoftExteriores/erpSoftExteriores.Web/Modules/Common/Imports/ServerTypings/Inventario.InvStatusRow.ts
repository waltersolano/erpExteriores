namespace erpSoftExteriores.Inventario {
    export interface InvStatusRow {
        Id?: number;
        Nombre?: string;
        TenantId?: number;
        Criterios?: string;
    }

    export namespace InvStatusRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Inventario.InvStatus';
        export const lookupKey = 'Inventario.Status';

        export function getLookup(): Q.Lookup<InvStatusRow> {
            return Q.getLookup<InvStatusRow>('Inventario.Status');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Nombre: string;
            export declare const TenantId: string;
            export declare const Criterios: string;
        }

        ['Id', 'Nombre', 'TenantId', 'Criterios'].forEach(x => (<any>Fields)[x] = x);
    }
}

