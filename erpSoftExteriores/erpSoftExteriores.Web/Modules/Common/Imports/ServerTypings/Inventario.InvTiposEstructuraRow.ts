namespace erpSoftExteriores.Inventario {
    export interface InvTiposEstructuraRow {
        Id?: number;
        CategoriasSoporteEstructuraId?: number;
        TenantId?: number;
        Nombre?: string;
        CategoriasSoporteEstructuraNombre?: string;
        CategoriasSoporteEstructuraTenantId?: number;
    }

    export namespace InvTiposEstructuraRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Inventario.InvTiposEstructura';
        export const lookupKey = 'Inventario.TiposEstructura';

        export function getLookup(): Q.Lookup<InvTiposEstructuraRow> {
            return Q.getLookup<InvTiposEstructuraRow>('Inventario.TiposEstructura');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const CategoriasSoporteEstructuraId: string;
            export declare const TenantId: string;
            export declare const Nombre: string;
            export declare const CategoriasSoporteEstructuraNombre: string;
            export declare const CategoriasSoporteEstructuraTenantId: string;
        }

        ['Id', 'CategoriasSoporteEstructuraId', 'TenantId', 'Nombre', 'CategoriasSoporteEstructuraNombre', 'CategoriasSoporteEstructuraTenantId'].forEach(x => (<any>Fields)[x] = x);
    }
}

