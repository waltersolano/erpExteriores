namespace erpSoftExteriores.Inventario {
    export interface InvSitiosContratosArrendamientoRow {
        Id?: number;
        SitioId?: number;
        ProductosAsociados?: number[];
        ArrendadorId?: number;
        NumeroContrato?: string;
        TipoContratoId?: number;
        TipoFechaDePagoContratoId?: number;
        TipoFechaPagoNombre?: string;
        MonedaId?: number;
        MonedaNombre?: string;
        MonedaSimbolo?: string;
        MonedaCodigo?: string;
        Monto?: number;
        DocumentosDigitalizados?: string;
        FechaInicial?: string;
        FechaFinal?: string;
        PorcentajeIncrementoRenovacion?: number;
        TenantId?: number;
        UserRegistraId?: number;
        UsuarioRegistraUsername?: string;
        UserApruedaId?: number;
        UsuarioApruebaUsername?: string;
        UserId?: number;
        EstaAprobado?: boolean;
        Estatus?: boolean;
        AdendumId?: number;
        SitioArrendadorId?: number;
        SitioDireccion?: string;
        SitioDivisionAdministrativaN1?: number;
        SitioDivisionAdministrativaN2?: number;
        SitioDivisionAdministrativaN3?: number;
        SitioDivisionAdministrativaN4?: number;
        SitioDivisionAdministrativaN5?: number;
        SitioRutaId?: number;
        SitioCodigoSitio?: string;
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
        NoteList?: General.NoteRow[];
    }

    export namespace InvSitiosContratosArrendamientoRow {
        export const idProperty = 'Id';
        export const nameProperty = 'NumeroContrato';
        export const localTextPrefix = 'Inventario.InvSitiosContratosArrendamiento';
        export const lookupKey = 'Inventario.ContratosArrendamiento';

        export function getLookup(): Q.Lookup<InvSitiosContratosArrendamientoRow> {
            return Q.getLookup<InvSitiosContratosArrendamientoRow>('Inventario.ContratosArrendamiento');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const SitioId: string;
            export declare const ProductosAsociados: string;
            export declare const ArrendadorId: string;
            export declare const NumeroContrato: string;
            export declare const TipoContratoId: string;
            export declare const TipoFechaDePagoContratoId: string;
            export declare const TipoFechaPagoNombre: string;
            export declare const MonedaId: string;
            export declare const MonedaNombre: string;
            export declare const MonedaSimbolo: string;
            export declare const MonedaCodigo: string;
            export declare const Monto: string;
            export declare const DocumentosDigitalizados: string;
            export declare const FechaInicial: string;
            export declare const FechaFinal: string;
            export declare const PorcentajeIncrementoRenovacion: string;
            export declare const TenantId: string;
            export declare const UserRegistraId: string;
            export declare const UsuarioRegistraUsername: string;
            export declare const UserApruedaId: string;
            export declare const UsuarioApruebaUsername: string;
            export declare const UserId: string;
            export declare const EstaAprobado: string;
            export declare const Estatus: string;
            export declare const AdendumId: string;
            export declare const SitioArrendadorId: string;
            export declare const SitioDireccion: string;
            export declare const SitioDivisionAdministrativaN1: string;
            export declare const SitioDivisionAdministrativaN2: string;
            export declare const SitioDivisionAdministrativaN3: string;
            export declare const SitioDivisionAdministrativaN4: string;
            export declare const SitioDivisionAdministrativaN5: string;
            export declare const SitioRutaId: string;
            export declare const SitioCodigoSitio: string;
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
            export declare const NoteList: string;
        }

        ['Id', 'SitioId', 'ProductosAsociados', 'ArrendadorId', 'NumeroContrato', 'TipoContratoId', 'TipoFechaDePagoContratoId', 'TipoFechaPagoNombre', 'MonedaId', 'MonedaNombre', 'MonedaSimbolo', 'MonedaCodigo', 'Monto', 'DocumentosDigitalizados', 'FechaInicial', 'FechaFinal', 'PorcentajeIncrementoRenovacion', 'TenantId', 'UserRegistraId', 'UsuarioRegistraUsername', 'UserApruedaId', 'UsuarioApruebaUsername', 'UserId', 'EstaAprobado', 'Estatus', 'AdendumId', 'SitioArrendadorId', 'SitioDireccion', 'SitioDivisionAdministrativaN1', 'SitioDivisionAdministrativaN2', 'SitioDivisionAdministrativaN3', 'SitioDivisionAdministrativaN4', 'SitioDivisionAdministrativaN5', 'SitioRutaId', 'SitioCodigoSitio', 'ArrendadorIdentificacion', 'ArrendadorNombre', 'ArrendadorTipoId', 'ArrendadorNotas', 'ArrendadorDireccion', 'ArrendadorEmails', 'ArrendadorCodigoPostal', 'ArrendadorTenantId', 'ArrendadorNombreRepresentante', 'ArrendadorIdentificacionRepresentante', 'ArrendadorTipoIdRepresentante', 'ArrendadorWebsite', 'NoteList'].forEach(x => (<any>Fields)[x] = x);
    }
}

