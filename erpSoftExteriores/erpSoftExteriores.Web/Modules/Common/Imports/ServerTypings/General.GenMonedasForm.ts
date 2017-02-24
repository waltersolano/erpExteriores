namespace erpSoftExteriores.General {
    export class GenMonedasForm extends Serenity.PrefixedContext {
        static formKey = 'General.GenMonedas';

    }

    export interface GenMonedasForm {
        Nombre: Serenity.StringEditor;
        Simbolo: Serenity.StringEditor;
        Codigo: Serenity.StringEditor;
        Pais: Serenity.StringEditor;
        CodigoPais: Serenity.StringEditor;
    }

    [['Nombre', () => Serenity.StringEditor], ['Simbolo', () => Serenity.StringEditor], ['Codigo', () => Serenity.StringEditor], ['Pais', () => Serenity.StringEditor], ['CodigoPais', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenMonedasForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

