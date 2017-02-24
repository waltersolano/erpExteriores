namespace erpSoftExteriores.Inventario {
    export interface InvCategoriasSoporteEstructuraRow {
        Id?: number;
        Nombre?: string;
        TenantId?: number;
    }

    export namespace InvCategoriasSoporteEstructuraRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Inventario.InvCategoriasSoporteEstructura';
        export const lookupKey = 'Inventario.CategoriasSoporteEstructura';

        export function getLookup(): Q.Lookup<InvCategoriasSoporteEstructuraRow> {
            return Q.getLookup<InvCategoriasSoporteEstructuraRow>('Inventario.CategoriasSoporteEstructura');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Nombre: string;
            export declare const TenantId: string;
        }

        ['Id', 'Nombre', 'TenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

