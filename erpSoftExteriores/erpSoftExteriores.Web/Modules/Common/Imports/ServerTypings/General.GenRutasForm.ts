namespace erpSoftExteriores.General {
    export class GenRutasForm extends Serenity.PrefixedContext {
        static formKey = 'General.GenRutas';

    }

    export interface GenRutasForm {
        Nombre: Serenity.StringEditor;
        Descripcion: Serenity.TextAreaEditor;
        Carreteras: Serenity.TextAreaEditor;
    }

    [['Nombre', () => Serenity.StringEditor], ['Descripcion', () => Serenity.TextAreaEditor], ['Carreteras', () => Serenity.TextAreaEditor]].forEach(x => Object.defineProperty(GenRutasForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

