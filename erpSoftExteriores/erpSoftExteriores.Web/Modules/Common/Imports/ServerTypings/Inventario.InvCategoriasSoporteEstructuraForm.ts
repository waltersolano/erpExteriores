namespace erpSoftExteriores.Inventario {
    export class InvCategoriasSoporteEstructuraForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvCategoriasSoporteEstructura';

    }

    export interface InvCategoriasSoporteEstructuraForm {
        Nombre: Serenity.StringEditor;
    }

    [['Nombre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(InvCategoriasSoporteEstructuraForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

