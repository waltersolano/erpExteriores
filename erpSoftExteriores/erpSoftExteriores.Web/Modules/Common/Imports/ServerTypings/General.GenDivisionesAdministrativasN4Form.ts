namespace erpSoftExteriores.General {
    export class GenDivisionesAdministrativasN4Form extends Serenity.PrefixedContext {
        static formKey = 'General.GenDivisionesAdministrativasN4';

    }

    export interface GenDivisionesAdministrativasN4Form {
        DivisionSuperiorN3: Serenity.LookupEditor;
        Nombre: Serenity.StringEditor;
    }

    [['DivisionSuperiorN3', () => Serenity.LookupEditor], ['Nombre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenDivisionesAdministrativasN4Form.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

