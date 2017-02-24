namespace erpSoftExteriores.Inventario {
    export class InvProductosForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvProductos';

    }

    export interface InvProductosForm {
        CodigoProducto: Serenity.StringEditor;
        SitioId: Serenity.LookupEditor;
        NoteList: General.NotesEditor;
        CategoriasSoporteEstructuraId: Serenity.LookupEditor;
        TiposEstructuraId: Serenity.LookupEditor;
        CircuitoId: Serenity.IntegerEditor;
        EstatusId: Serenity.LookupEditor;
        MonedaId: Serenity.LookupEditor;
        PrecioVenta: Serenity.DecimalEditor;
        PrecioVentaMinimo: Serenity.DecimalEditor;
        PrecioVentaCircuito: Serenity.DecimalEditor;
        TieneIluminacion: Serenity.BooleanEditor;
        PrecioIncluyeIluminacion: Serenity.BooleanEditor;
        PrecioIluminacion: Serenity.DecimalEditor;
        MonedaIluminacionId: Serenity.LookupEditor;
        DescriptionVista: Serenity.StringEditor;
        Base: Serenity.DecimalEditor;
        Altura: Serenity.DecimalEditor;
        Area: Serenity.DecimalEditor;
        GpsLatitud: Serenity.StringEditor;
        GpsLongitud: Serenity.StringEditor;
        Imagenes: Serenity.MultipleImageUploadEditor;
        LegalInfoId: InvProductosLegalEditor;
    }

    [['CodigoProducto', () => Serenity.StringEditor], ['SitioId', () => Serenity.LookupEditor], ['NoteList', () => General.NotesEditor], ['CategoriasSoporteEstructuraId', () => Serenity.LookupEditor], ['TiposEstructuraId', () => Serenity.LookupEditor], ['CircuitoId', () => Serenity.IntegerEditor], ['EstatusId', () => Serenity.LookupEditor], ['MonedaId', () => Serenity.LookupEditor], ['PrecioVenta', () => Serenity.DecimalEditor], ['PrecioVentaMinimo', () => Serenity.DecimalEditor], ['PrecioVentaCircuito', () => Serenity.DecimalEditor], ['TieneIluminacion', () => Serenity.BooleanEditor], ['PrecioIncluyeIluminacion', () => Serenity.BooleanEditor], ['PrecioIluminacion', () => Serenity.DecimalEditor], ['MonedaIluminacionId', () => Serenity.LookupEditor], ['DescriptionVista', () => Serenity.StringEditor], ['Base', () => Serenity.DecimalEditor], ['Altura', () => Serenity.DecimalEditor], ['Area', () => Serenity.DecimalEditor], ['GpsLatitud', () => Serenity.StringEditor], ['GpsLongitud', () => Serenity.StringEditor], ['Imagenes', () => Serenity.MultipleImageUploadEditor], ['LegalInfoId', () => InvProductosLegalEditor]].forEach(x => Object.defineProperty(InvProductosForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

