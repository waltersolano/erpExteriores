namespace erpSoftExteriores.Inventario {
    export class InvStatusForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvStatus';

    }

    export interface InvStatusForm {
        Nombre: Serenity.StringEditor;
        Criterios: Serenity.StringEditor;
    }

    [['Nombre', () => Serenity.StringEditor], ['Criterios', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(InvStatusForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

