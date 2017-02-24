namespace erpSoftExteriores.Inventario {
    export class InvProductosLegalForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvProductosLegal';

    }

    export interface InvProductosLegalForm {
        DocumentoUno: Serenity.StringEditor;
        DocumentoDos: Serenity.StringEditor;
        DocumentoTres: Serenity.StringEditor;
        DocumentoCuatro: Serenity.StringEditor;
        DocumentoCinco: Serenity.StringEditor;
        Vence: Serenity.DateEditor;
        Observaciones: Serenity.TextAreaEditor;
        DocumentosDigitalizados: Serenity.MultipleImageUploadEditor;
    }

    [['DocumentoUno', () => Serenity.StringEditor], ['DocumentoDos', () => Serenity.StringEditor], ['DocumentoTres', () => Serenity.StringEditor], ['DocumentoCuatro', () => Serenity.StringEditor], ['DocumentoCinco', () => Serenity.StringEditor], ['Vence', () => Serenity.DateEditor], ['Observaciones', () => Serenity.TextAreaEditor], ['DocumentosDigitalizados', () => Serenity.MultipleImageUploadEditor]].forEach(x => Object.defineProperty(InvProductosLegalForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

