namespace erpSoftExteriores.Inventario {
    export interface InvArrendadoresRow {
        Id?: number;
        Identificacion?: string;
        Nombre?: string;
        TipoId?: number;
        Notas?: string;
        Direccion?: string;
        Emails?: string;
        CodigoPostal?: string;
        TenantId?: number;
        NombreRepresentante?: string;
        IdentificacionRepresentante?: string;
        TipoIdRepresentante?: number;
        Website?: string;
        TipoNombre?: string;
        TipoIdRepresentanteNombre?: string;
    }

    export namespace InvArrendadoresRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Inventario.InvArrendadores';
        export const lookupKey = 'Inventario.Arrendadores';

        export function getLookup(): Q.Lookup<InvArrendadoresRow> {
            return Q.getLookup<InvArrendadoresRow>('Inventario.Arrendadores');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Identificacion: string;
            export declare const Nombre: string;
            export declare const TipoId: string;
            export declare const Notas: string;
            export declare const Direccion: string;
            export declare const Emails: string;
            export declare const CodigoPostal: string;
            export declare const TenantId: string;
            export declare const NombreRepresentante: string;
            export declare const IdentificacionRepresentante: string;
            export declare const TipoIdRepresentante: string;
            export declare const Website: string;
            export declare const TipoNombre: string;
            export declare const TipoIdRepresentanteNombre: string;
        }

        ['Id', 'Identificacion', 'Nombre', 'TipoId', 'Notas', 'Direccion', 'Emails', 'CodigoPostal', 'TenantId', 'NombreRepresentante', 'IdentificacionRepresentante', 'TipoIdRepresentante', 'Website', 'TipoNombre', 'TipoIdRepresentanteNombre'].forEach(x => (<any>Fields)[x] = x);
    }
}

