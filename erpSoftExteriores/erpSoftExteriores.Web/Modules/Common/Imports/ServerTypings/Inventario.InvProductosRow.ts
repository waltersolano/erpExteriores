namespace erpSoftExteriores.Inventario {
    export interface InvProductosRow {
        Id?: number;
        SitioId?: number;
        Nombre?: string;
        CategoriasSoporteEstructuraId?: number;
        CategoriasSoporteEstructuraNombre?: string;
        CategoriasSoporteEstructuraTenantId?: number;
        TiposEstructuraId?: number;
        TiposEstructuraNombre?: string;
        TiposEstructuraTenantId?: number;
        CircuitoId?: number;
        EstatusId?: number;
        EstatusNombre?: string;
        MonedaId?: number;
        PrecioVenta?: number;
        PrecioVentaMinimo?: number;
        PrecioVentaCircuito?: number;
        CantidadPorUnidad?: string;
        UnidadesEnStock?: number;
        CodigoProducto?: string;
        Notas?: string;
        DescriptionVista?: string;
        Base?: number;
        Altura?: number;
        Area?: number;
        Imagenes?: string;
        GpsLatitud?: string;
        GpsLongitud?: string;
        Ubicacion?: string;
        GpsRutaId?: number;
        TenantId?: number;
        LegalInfoId?: number;
        LegalDocumentoUno?: string;
        TieneIluminacion?: boolean;
        PrecioIluminacion?: number;
        MonedaIluminacionId?: number;
        PrecioIncluyeIluminacion?: boolean;
        SitioArrendadorId?: number;
        SitioArrendadorNombre?: string;
        SitioDireccion?: string;
        SitioNotas?: string;
        SitioTenantId?: number;
        SitioDivisionAdministrativaN1?: number;
        SitioDivisionAdministrativaN1Nombre?: string;
        SitioDivisionAdministrativaN2?: number;
        SitioDivisionAdministrativaN2Nombre?: string;
        SitioDivisionAdministrativaN3?: number;
        SitioDivisionAdministrativaN3Nombre?: string;
        SitioDivisionAdministrativaN4?: number;
        SitioDivisionAdministrativaN4Nombre?: string;
        SitioDivisionAdministrativaN5?: number;
        SitioDivisionAdministrativaN5Nombre?: string;
        SitioRutaId?: number;
        SitioRutaNombre?: string;
        SitioCodigoSitio?: string;
        MonedaNombre?: string;
        MonedaSimbolo?: string;
        MonedaCodigo?: string;
        MonedaPais?: string;
        MonedaCodigoPais?: string;
        NoteList?: General.NoteRow[];
    }

    export namespace InvProductosRow {
        export const idProperty = 'Id';
        export const nameProperty = 'CodigoProducto';
        export const localTextPrefix = 'Inventario.InvProductos';
        export const lookupKey = 'Inventario.Productos';

        export function getLookup(): Q.Lookup<InvProductosRow> {
            return Q.getLookup<InvProductosRow>('Inventario.Productos');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const SitioId: string;
            export declare const Nombre: string;
            export declare const CategoriasSoporteEstructuraId: string;
            export declare const CategoriasSoporteEstructuraNombre: string;
            export declare const CategoriasSoporteEstructuraTenantId: string;
            export declare const TiposEstructuraId: string;
            export declare const TiposEstructuraNombre: string;
            export declare const TiposEstructuraTenantId: string;
            export declare const CircuitoId: string;
            export declare const EstatusId: string;
            export declare const EstatusNombre: string;
            export declare const MonedaId: string;
            export declare const PrecioVenta: string;
            export declare const PrecioVentaMinimo: string;
            export declare const PrecioVentaCircuito: string;
            export declare const CantidadPorUnidad: string;
            export declare const UnidadesEnStock: string;
            export declare const CodigoProducto: string;
            export declare const Notas: string;
            export declare const DescriptionVista: string;
            export declare const Base: string;
            export declare const Altura: string;
            export declare const Area: string;
            export declare const Imagenes: string;
            export declare const GpsLatitud: string;
            export declare const GpsLongitud: string;
            export declare const Ubicacion: string;
            export declare const GpsRutaId: string;
            export declare const TenantId: string;
            export declare const LegalInfoId: string;
            export declare const LegalDocumentoUno: string;
            export declare const TieneIluminacion: string;
            export declare const PrecioIluminacion: string;
            export declare const MonedaIluminacionId: string;
            export declare const PrecioIncluyeIluminacion: string;
            export declare const SitioArrendadorId: string;
            export declare const SitioArrendadorNombre: string;
            export declare const SitioDireccion: string;
            export declare const SitioNotas: string;
            export declare const SitioTenantId: string;
            export declare const SitioDivisionAdministrativaN1: string;
            export declare const SitioDivisionAdministrativaN1Nombre: string;
            export declare const SitioDivisionAdministrativaN2: string;
            export declare const SitioDivisionAdministrativaN2Nombre: string;
            export declare const SitioDivisionAdministrativaN3: string;
            export declare const SitioDivisionAdministrativaN3Nombre: string;
            export declare const SitioDivisionAdministrativaN4: string;
            export declare const SitioDivisionAdministrativaN4Nombre: string;
            export declare const SitioDivisionAdministrativaN5: string;
            export declare const SitioDivisionAdministrativaN5Nombre: string;
            export declare const SitioRutaId: string;
            export declare const SitioRutaNombre: string;
            export declare const SitioCodigoSitio: string;
            export declare const MonedaNombre: string;
            export declare const MonedaSimbolo: string;
            export declare const MonedaCodigo: string;
            export declare const MonedaPais: string;
            export declare const MonedaCodigoPais: string;
            export declare const NoteList: string;
        }

        ['Id', 'SitioId', 'Nombre', 'CategoriasSoporteEstructuraId', 'CategoriasSoporteEstructuraNombre', 'CategoriasSoporteEstructuraTenantId', 'TiposEstructuraId', 'TiposEstructuraNombre', 'TiposEstructuraTenantId', 'CircuitoId', 'EstatusId', 'EstatusNombre', 'MonedaId', 'PrecioVenta', 'PrecioVentaMinimo', 'PrecioVentaCircuito', 'CantidadPorUnidad', 'UnidadesEnStock', 'CodigoProducto', 'Notas', 'DescriptionVista', 'Base', 'Altura', 'Area', 'Imagenes', 'GpsLatitud', 'GpsLongitud', 'Ubicacion', 'GpsRutaId', 'TenantId', 'LegalInfoId', 'LegalDocumentoUno', 'TieneIluminacion', 'PrecioIluminacion', 'MonedaIluminacionId', 'PrecioIncluyeIluminacion', 'SitioArrendadorId', 'SitioArrendadorNombre', 'SitioDireccion', 'SitioNotas', 'SitioTenantId', 'SitioDivisionAdministrativaN1', 'SitioDivisionAdministrativaN1Nombre', 'SitioDivisionAdministrativaN2', 'SitioDivisionAdministrativaN2Nombre', 'SitioDivisionAdministrativaN3', 'SitioDivisionAdministrativaN3Nombre', 'SitioDivisionAdministrativaN4', 'SitioDivisionAdministrativaN4Nombre', 'SitioDivisionAdministrativaN5', 'SitioDivisionAdministrativaN5Nombre', 'SitioRutaId', 'SitioRutaNombre', 'SitioCodigoSitio', 'MonedaNombre', 'MonedaSimbolo', 'MonedaCodigo', 'MonedaPais', 'MonedaCodigoPais', 'NoteList'].forEach(x => (<any>Fields)[x] = x);
    }
}

