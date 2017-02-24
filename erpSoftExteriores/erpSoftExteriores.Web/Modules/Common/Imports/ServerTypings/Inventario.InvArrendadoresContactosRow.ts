namespace erpSoftExteriores.Inventario {
    export interface InvArrendadoresContactosRow {
        Id?: number;
        Nombre?: string;
        Telefono1?: string;
        Email?: string;
        Cargo?: string;
        ArrendadorId?: number;
        TenantId?: number;
        Telefono2?: string;
        Telefono3?: string;
        ArrendadorIdentificacion?: string;
        ArrendadorNombre?: string;
        ArrendadorTipoId?: number;
        ArrendadorNotas?: string;
        ArrendadorDireccion?: string;
        ArrendadorEmails?: string;
        ArrendadorCodigoPostal?: string;
        ArrendadorTenantId?: number;
        ArrendadorNombreRepresentante?: string;
        ArrendadorIdentificacionRepresentante?: string;
        ArrendadorTipoIdRepresentante?: number;
        ArrendadorWebsite?: string;
    }

    export namespace InvArrendadoresContactosRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nombre';
        export const localTextPrefix = 'Inventario.InvArrendadoresContactos';
        export const lookupKey = 'Inventario.ArrendadoresContactos';

        export function getLookup(): Q.Lookup<InvArrendadoresContactosRow> {
            return Q.getLookup<InvArrendadoresContactosRow>('Inventario.ArrendadoresContactos');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Nombre: string;
            export declare const Telefono1: string;
            export declare const Email: string;
            export declare const Cargo: string;
            export declare const ArrendadorId: string;
            export declare const TenantId: string;
            export declare const Telefono2: string;
            export declare const Telefono3: string;
            export declare const ArrendadorIdentificacion: string;
            export declare const ArrendadorNombre: string;
            export declare const ArrendadorTipoId: string;
            export declare const ArrendadorNotas: string;
            export declare const ArrendadorDireccion: string;
            export declare const ArrendadorEmails: string;
            export declare const ArrendadorCodigoPostal: string;
            export declare const ArrendadorTenantId: string;
            export declare const ArrendadorNombreRepresentante: string;
            export declare const ArrendadorIdentificacionRepresentante: string;
            export declare const ArrendadorTipoIdRepresentante: string;
            export declare const ArrendadorWebsite: string;
        }

        ['Id', 'Nombre', 'Telefono1', 'Email', 'Cargo', 'ArrendadorId', 'TenantId', 'Telefono2', 'Telefono3', 'ArrendadorIdentificacion', 'ArrendadorNombre', 'ArrendadorTipoId', 'ArrendadorNotas', 'ArrendadorDireccion', 'ArrendadorEmails', 'ArrendadorCodigoPostal', 'ArrendadorTenantId', 'ArrendadorNombreRepresentante', 'ArrendadorIdentificacionRepresentante', 'ArrendadorTipoIdRepresentante', 'ArrendadorWebsite'].forEach(x => (<any>Fields)[x] = x);
    }
}

