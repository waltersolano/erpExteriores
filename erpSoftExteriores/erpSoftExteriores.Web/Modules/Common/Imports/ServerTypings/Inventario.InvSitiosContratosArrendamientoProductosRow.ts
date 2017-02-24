namespace erpSoftExteriores.Inventario {
    export interface InvSitiosContratosArrendamientoProductosRow {
        Id?: number;
        SitiosContratoId?: number;
        ProductoId?: number;
        SitiosContratoSitioId?: number;
        SitiosContratoArrendadorId?: number;
        SitiosContratoNumeroContrato?: string;
        SitiosContratoTipoContratoId?: number;
        SitiosContratoTipoFechaDePagoContratoId?: number;
        SitiosContratoMonedaId?: number;
        SitiosContratoMonto?: number;
        SitiosContratoDocumentosDigitalizados?: string;
        SitiosContratoFechaInicial?: string;
        SitiosContratoFechaFinal?: string;
        SitiosContratoPorcentajeIncrementoRenovacion?: number;
        SitiosContratoTenantId?: number;
        SitiosContratoUserRegistraId?: number;
        SitiosContratoUserApruedaId?: number;
        SitiosContratoUserId?: number;
        SitiosContratoEstaAprobado?: boolean;
        SitiosContratoEstatus?: string;
        SitiosContratoAdendumId?: number;
        ProductoSitioId?: number;
        ProductoNombre?: string;
        ProductoCategoriasSoporteEstructuraId?: number;
        ProductoTiposEstructuraId?: number;
        ProductoCircuitoId?: number;
        ProductoEstatusId?: number;
        ProductoMonedaId?: number;
        ProductoPrecioVenta?: number;
        ProductoPrecioVentaMinimo?: number;
        ProductoPrecioVentaCircuito?: number;
        ProductoCantidadPorUnidad?: string;
        ProductoUnidadesEnStock?: number;
        ProductoCodigoProducto?: string;
        ProductoNotas?: string;
        ProductoDescriptionVista?: string;
        ProductoBase?: number;
        ProductoAltura?: number;
        ProductoImagenes?: string;
        ProductoGpsLatitud?: string;
        ProductoGpsLongitud?: string;
        ProductoUbicacion?: string;
        ProductoGpsRutaId?: number;
        ProductoTenantId?: number;
        ProductoUserId?: number;
        ProductoUltimaModificacion?: string;
        ProductoUserIdModifica?: number;
        ProductoFechaCreacion?: string;
        ProductoLegalInfoId?: number;
        ProductoTieneIluminacion?: boolean;
        ProductoPrecioIluminacion?: number;
        ProductoMonedaIluminacionId?: number;
        ProductoPrecioIncluyeIluminacion?: boolean;
    }

    export namespace InvSitiosContratosArrendamientoProductosRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'Inventario.InvSitiosContratosArrendamientoProductos';
        export const lookupKey = 'Inventario.ContratosArrendamientoProducto';

        export function getLookup(): Q.Lookup<InvSitiosContratosArrendamientoProductosRow> {
            return Q.getLookup<InvSitiosContratosArrendamientoProductosRow>('Inventario.ContratosArrendamientoProducto');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const SitiosContratoId: string;
            export declare const ProductoId: string;
            export declare const SitiosContratoSitioId: string;
            export declare const SitiosContratoArrendadorId: string;
            export declare const SitiosContratoNumeroContrato: string;
            export declare const SitiosContratoTipoContratoId: string;
            export declare const SitiosContratoTipoFechaDePagoContratoId: string;
            export declare const SitiosContratoMonedaId: string;
            export declare const SitiosContratoMonto: string;
            export declare const SitiosContratoDocumentosDigitalizados: string;
            export declare const SitiosContratoFechaInicial: string;
            export declare const SitiosContratoFechaFinal: string;
            export declare const SitiosContratoPorcentajeIncrementoRenovacion: string;
            export declare const SitiosContratoTenantId: string;
            export declare const SitiosContratoUserRegistraId: string;
            export declare const SitiosContratoUserApruedaId: string;
            export declare const SitiosContratoUserId: string;
            export declare const SitiosContratoEstaAprobado: string;
            export declare const SitiosContratoEstatus: string;
            export declare const SitiosContratoAdendumId: string;
            export declare const ProductoSitioId: string;
            export declare const ProductoNombre: string;
            export declare const ProductoCategoriasSoporteEstructuraId: string;
            export declare const ProductoTiposEstructuraId: string;
            export declare const ProductoCircuitoId: string;
            export declare const ProductoEstatusId: string;
            export declare const ProductoMonedaId: string;
            export declare const ProductoPrecioVenta: string;
            export declare const ProductoPrecioVentaMinimo: string;
            export declare const ProductoPrecioVentaCircuito: string;
            export declare const ProductoCantidadPorUnidad: string;
            export declare const ProductoUnidadesEnStock: string;
            export declare const ProductoCodigoProducto: string;
            export declare const ProductoNotas: string;
            export declare const ProductoDescriptionVista: string;
            export declare const ProductoBase: string;
            export declare const ProductoAltura: string;
            export declare const ProductoImagenes: string;
            export declare const ProductoGpsLatitud: string;
            export declare const ProductoGpsLongitud: string;
            export declare const ProductoUbicacion: string;
            export declare const ProductoGpsRutaId: string;
            export declare const ProductoTenantId: string;
            export declare const ProductoUserId: string;
            export declare const ProductoUltimaModificacion: string;
            export declare const ProductoUserIdModifica: string;
            export declare const ProductoFechaCreacion: string;
            export declare const ProductoLegalInfoId: string;
            export declare const ProductoTieneIluminacion: string;
            export declare const ProductoPrecioIluminacion: string;
            export declare const ProductoMonedaIluminacionId: string;
            export declare const ProductoPrecioIncluyeIluminacion: string;
        }

        ['Id', 'SitiosContratoId', 'ProductoId', 'SitiosContratoSitioId', 'SitiosContratoArrendadorId', 'SitiosContratoNumeroContrato', 'SitiosContratoTipoContratoId', 'SitiosContratoTipoFechaDePagoContratoId', 'SitiosContratoMonedaId', 'SitiosContratoMonto', 'SitiosContratoDocumentosDigitalizados', 'SitiosContratoFechaInicial', 'SitiosContratoFechaFinal', 'SitiosContratoPorcentajeIncrementoRenovacion', 'SitiosContratoTenantId', 'SitiosContratoUserRegistraId', 'SitiosContratoUserApruedaId', 'SitiosContratoUserId', 'SitiosContratoEstaAprobado', 'SitiosContratoEstatus', 'SitiosContratoAdendumId', 'ProductoSitioId', 'ProductoNombre', 'ProductoCategoriasSoporteEstructuraId', 'ProductoTiposEstructuraId', 'ProductoCircuitoId', 'ProductoEstatusId', 'ProductoMonedaId', 'ProductoPrecioVenta', 'ProductoPrecioVentaMinimo', 'ProductoPrecioVentaCircuito', 'ProductoCantidadPorUnidad', 'ProductoUnidadesEnStock', 'ProductoCodigoProducto', 'ProductoNotas', 'ProductoDescriptionVista', 'ProductoBase', 'ProductoAltura', 'ProductoImagenes', 'ProductoGpsLatitud', 'ProductoGpsLongitud', 'ProductoUbicacion', 'ProductoGpsRutaId', 'ProductoTenantId', 'ProductoUserId', 'ProductoUltimaModificacion', 'ProductoUserIdModifica', 'ProductoFechaCreacion', 'ProductoLegalInfoId', 'ProductoTieneIluminacion', 'ProductoPrecioIluminacion', 'ProductoMonedaIluminacionId', 'ProductoPrecioIncluyeIluminacion'].forEach(x => (<any>Fields)[x] = x);
    }
}

