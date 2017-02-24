namespace erpSoftExteriores.General {
    export class GenDivisionesAdministrativasN5Form extends Serenity.PrefixedContext {
        static formKey = 'General.GenDivisionesAdministrativasN5';

    }

    export interface GenDivisionesAdministrativasN5Form {
        DivisionSuperiorN4: Serenity.LookupEditor;
        Nombre: Serenity.StringEditor;
    }

    [['DivisionSuperiorN4', () => Serenity.LookupEditor], ['Nombre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenDivisionesAdministrativasN5Form.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

