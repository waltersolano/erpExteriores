namespace erpSoftExteriores.Inventario {
    export interface InvSitiosRow {
        Id?: number;
        ArrendadorId?: number;
        Direccion?: string;
        Notas?: string;
        TenantId?: number;
        DivisionAdministrativaN1?: number;
        DivisionAdministrativaN2?: number;
        DivisionAdministrativaN3?: number;
        DivisionAdministrativaN4?: number;
        DivisionAdministrativaN5?: number;
        RutaId?: number;
        CodigoSitio?: string;
        ContratoId?: number;
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
        DivisionAdministrativaN1Codigo?: string;
        DivisionAdministrativaN1Nombre?: string;
        DivisionAdministrativaN1DivisionSuperior?: number;
        DivisionAdministrativaN2Codigo?: string;
        DivisionAdministrativaN2Nombre?: string;
        DivisionAdministrativaN2DivisionSuperiorN1?: number;
        DivisionAdministrativaN3Codigo?: string;
        DivisionAdministrativaN3Nombre?: string;
        DivisionAdministrativaN3DivisionSuperiorN2?: number;
        DivisionAdministrativaN4Codigo?: string;
        DivisionAdministrativaN4Nombre?: string;
        DivisionAdministrativaN4DivisionSuperiorN3?: number;
        DivisionAdministrativaN5Codigo?: string;
        DivisionAdministrativaN5Nombre?: string;
        DivisionAdministrativaN5DivisionSuperiorN4?: number;
        RutaNombre?: string;
        RutaDescripcion?: string;
        RutaCarreteras?: string;
        ContratoArrendadorId?: number;
        ContratoNumeroContrato?: string;
        ContratoTipoContratoId?: number;
        ContratoTipoFechaDePagoContratoId?: number;
        ContratoMonedaId?: number;
        ContratoMonto?: number;
        ContratoDocumentosDigitalizados?: string;
        ContratoFechaInicial?: string;
        ContratoFechaFinal?: string;
        ContratoPorcentajeIncrementoRenovacion?: number;
        ContratoTenantId?: number;
        ContratoUserRegistraId?: number;
        ContratoUserApruedaId?: number;
        ContratoUserId?: number;
        ContratoEstaAprobado?: boolean;
        ContratoAdendumId?: number;
    }

    export namespace InvSitiosRow {
        export const idProperty = 'Id';
        export const nameProperty = 'CodigoSitio';
        export const localTextPrefix = 'Inventario.InvSitios';
        export const lookupKey = 'Inventario.Sitios';

        export function getLookup(): Q.Lookup<InvSitiosRow> {
            return Q.getLookup<InvSitiosRow>('Inventario.Sitios');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const ArrendadorId: string;
            export declare const Direccion: string;
            export declare const Notas: string;
            export declare const TenantId: string;
            export declare const DivisionAdministrativaN1: string;
            export declare const DivisionAdministrativaN2: string;
            export declare const DivisionAdministrativaN3: string;
            export declare const DivisionAdministrativaN4: string;
            export declare const DivisionAdministrativaN5: string;
            export declare const RutaId: string;
            export declare const CodigoSitio: string;
            export declare const ContratoId: string;
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
            export declare const DivisionAdministrativaN1Codigo: string;
            export declare const DivisionAdministrativaN1Nombre: string;
            export declare const DivisionAdministrativaN1DivisionSuperior: string;
            export declare const DivisionAdministrativaN2Codigo: string;
            export declare const DivisionAdministrativaN2Nombre: string;
            export declare const DivisionAdministrativaN2DivisionSuperiorN1: string;
            export declare const DivisionAdministrativaN3Codigo: string;
            export declare const DivisionAdministrativaN3Nombre: string;
            export declare const DivisionAdministrativaN3DivisionSuperiorN2: string;
            export declare const DivisionAdministrativaN4Codigo: string;
            export declare const DivisionAdministrativaN4Nombre: string;
            export declare const DivisionAdministrativaN4DivisionSuperiorN3: string;
            export declare const DivisionAdministrativaN5Codigo: string;
            export declare const DivisionAdministrativaN5Nombre: string;
            export declare const DivisionAdministrativaN5DivisionSuperiorN4: string;
            export declare const RutaNombre: string;
            export declare const RutaDescripcion: string;
            export declare const RutaCarreteras: string;
            export declare const ContratoArrendadorId: string;
            export declare const ContratoNumeroContrato: string;
            export declare const ContratoTipoContratoId: string;
            export declare const ContratoTipoFechaDePagoContratoId: string;
            export declare const ContratoMonedaId: string;
            export declare const ContratoMonto: string;
            export declare const ContratoDocumentosDigitalizados: string;
            export declare const ContratoFechaInicial: string;
            export declare const ContratoFechaFinal: string;
            export declare const ContratoPorcentajeIncrementoRenovacion: string;
            export declare const ContratoTenantId: string;
            export declare const ContratoUserRegistraId: string;
            export declare const ContratoUserApruedaId: string;
            export declare const ContratoUserId: string;
            export declare const ContratoEstaAprobado: string;
            export declare const ContratoAdendumId: string;
        }

        ['Id', 'ArrendadorId', 'Direccion', 'Notas', 'TenantId', 'DivisionAdministrativaN1', 'DivisionAdministrativaN2', 'DivisionAdministrativaN3', 'DivisionAdministrativaN4', 'DivisionAdministrativaN5', 'RutaId', 'CodigoSitio', 'ContratoId', 'ArrendadorIdentificacion', 'ArrendadorNombre', 'ArrendadorTipoId', 'ArrendadorNotas', 'ArrendadorDireccion', 'ArrendadorEmails', 'ArrendadorCodigoPostal', 'ArrendadorTenantId', 'ArrendadorNombreRepresentante', 'ArrendadorIdentificacionRepresentante', 'ArrendadorTipoIdRepresentante', 'ArrendadorWebsite', 'DivisionAdministrativaN1Codigo', 'DivisionAdministrativaN1Nombre', 'DivisionAdministrativaN1DivisionSuperior', 'DivisionAdministrativaN2Codigo', 'DivisionAdministrativaN2Nombre', 'DivisionAdministrativaN2DivisionSuperiorN1', 'DivisionAdministrativaN3Codigo', 'DivisionAdministrativaN3Nombre', 'DivisionAdministrativaN3DivisionSuperiorN2', 'DivisionAdministrativaN4Codigo', 'DivisionAdministrativaN4Nombre', 'DivisionAdministrativaN4DivisionSuperiorN3', 'DivisionAdministrativaN5Codigo', 'DivisionAdministrativaN5Nombre', 'DivisionAdministrativaN5DivisionSuperiorN4', 'RutaNombre', 'RutaDescripcion', 'RutaCarreteras', 'ContratoArrendadorId', 'ContratoNumeroContrato', 'ContratoTipoContratoId', 'ContratoTipoFechaDePagoContratoId', 'ContratoMonedaId', 'ContratoMonto', 'ContratoDocumentosDigitalizados', 'ContratoFechaInicial', 'ContratoFechaFinal', 'ContratoPorcentajeIncrementoRenovacion', 'ContratoTenantId', 'ContratoUserRegistraId', 'ContratoUserApruedaId', 'ContratoUserId', 'ContratoEstaAprobado', 'ContratoAdendumId'].forEach(x => (<any>Fields)[x] = x);
    }
}

