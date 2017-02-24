namespace erpSoftExteriores.General {
    export class GenTipoPagoForm extends Serenity.PrefixedContext {
        static formKey = 'General.GenTipoPago';

    }

    export interface GenTipoPagoForm {
        Nombre: Serenity.StringEditor;
        CantidadDias: Serenity.IntegerEditor;
        CantidadMeses: Serenity.DecimalEditor;
        Criterios: Serenity.StringEditor;
    }

    [['Nombre', () => Serenity.StringEditor], ['CantidadDias', () => Serenity.IntegerEditor], ['CantidadMeses', () => Serenity.DecimalEditor], ['Criterios', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenTipoPagoForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

