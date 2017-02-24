namespace erpSoftExteriores.Inventario {
    export class InvTiposEstructuraForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvTiposEstructura';

    }

    export interface InvTiposEstructuraForm {
        CategoriasSoporteEstructuraId: Serenity.LookupEditor;
        Nombre: Serenity.StringEditor;
    }

    [['CategoriasSoporteEstructuraId', () => Serenity.LookupEditor], ['Nombre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(InvTiposEstructuraForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

