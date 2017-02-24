namespace erpSoftExteriores.General {
    export class GenDivisionesAdministrativasN2Form extends Serenity.PrefixedContext {
        static formKey = 'General.GenDivisionesAdministrativasN2';

    }

    export interface GenDivisionesAdministrativasN2Form {
        DivisionSuperiorN1: Serenity.LookupEditor;
        Nombre: Serenity.StringEditor;
    }

    [['DivisionSuperiorN1', () => Serenity.LookupEditor], ['Nombre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenDivisionesAdministrativasN2Form.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

