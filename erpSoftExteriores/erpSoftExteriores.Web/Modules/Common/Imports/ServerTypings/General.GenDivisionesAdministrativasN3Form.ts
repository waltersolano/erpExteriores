namespace erpSoftExteriores.General {
    export class GenDivisionesAdministrativasN3Form extends Serenity.PrefixedContext {
        static formKey = 'General.GenDivisionesAdministrativasN3';

    }

    export interface GenDivisionesAdministrativasN3Form {
        DivisionSuperiorN2: Serenity.LookupEditor;
        Nombre: Serenity.StringEditor;
    }

    [['DivisionSuperiorN2', () => Serenity.LookupEditor], ['Nombre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenDivisionesAdministrativasN3Form.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

