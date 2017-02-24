namespace erpSoftExteriores.General {
    export class GenDivisionesAdministrativasN1Form extends Serenity.PrefixedContext {
        static formKey = 'General.GenDivisionesAdministrativasN1';

    }

    export interface GenDivisionesAdministrativasN1Form {
        Nombre: Serenity.StringEditor;
    }

    [['Nombre', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(GenDivisionesAdministrativasN1Form.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

