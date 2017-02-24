namespace erpSoftExteriores.Inventario {
    export class InvSitiosContratosArrendamientoForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvSitiosContratosArrendamiento';

    }

    export interface InvSitiosContratosArrendamientoForm {
        NumeroContrato: Serenity.StringEditor;
        SitioId: SitiosArrendadorEditor;
        ProductosAsociados: Serenity.LookupEditor;
        NoteList: General.NotesEditor;
        FechaInicial: Serenity.DateEditor;
        FechaFinal: Serenity.DateEditor;
        TipoFechaDePagoContratoId: Serenity.LookupEditor;
        MonedaId: Serenity.LookupEditor;
        Monto: Serenity.DecimalEditor;
        PorcentajeIncrementoRenovacion: Serenity.DecimalEditor;
        DocumentosDigitalizados: Serenity.MultipleImageUploadEditor;
        UserRegistraId: Serenity.LookupEditor;
        UserApruedaId: Serenity.IntegerEditor;
        EstaAprobado: Serenity.BooleanEditor;
    }

    [['NumeroContrato', () => Serenity.StringEditor], ['SitioId', () => SitiosArrendadorEditor], ['ProductosAsociados', () => Serenity.LookupEditor], ['NoteList', () => General.NotesEditor], ['FechaInicial', () => Serenity.DateEditor], ['FechaFinal', () => Serenity.DateEditor], ['TipoFechaDePagoContratoId', () => Serenity.LookupEditor], ['MonedaId', () => Serenity.LookupEditor], ['Monto', () => Serenity.DecimalEditor], ['PorcentajeIncrementoRenovacion', () => Serenity.DecimalEditor], ['DocumentosDigitalizados', () => Serenity.MultipleImageUploadEditor], ['UserRegistraId', () => Serenity.LookupEditor], ['UserApruedaId', () => Serenity.IntegerEditor], ['EstaAprobado', () => Serenity.BooleanEditor]].forEach(x => Object.defineProperty(InvSitiosContratosArrendamientoForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

