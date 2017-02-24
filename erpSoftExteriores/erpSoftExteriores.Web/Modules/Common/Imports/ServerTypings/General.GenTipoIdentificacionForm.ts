namespace erpSoftExteriores.General {
    export class GenTipoIdentificacionForm extends Serenity.PrefixedContext {
        static formKey = 'General.GenTipoIdentificacion';

    }

    export interface GenTipoIdentificacionForm {
        Nombre: Serenity.StringEditor;
    }

    [['Nombre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenTipoIdentificacionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

