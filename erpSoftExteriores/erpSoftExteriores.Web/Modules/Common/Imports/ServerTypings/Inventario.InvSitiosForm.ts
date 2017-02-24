namespace erpSoftExteriores.Inventario {
    export class InvSitiosForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvSitios';

    }

    export interface InvSitiosForm {
        CodigoSitio: Serenity.StringEditor;
        ArrendadorId: InvArrendadoresEditor;
        RutaId: Serenity.LookupEditor;
        DivisionAdministrativaN1: Serenity.LookupEditor;
        DivisionAdministrativaN2: Serenity.LookupEditor;
        DivisionAdministrativaN3: Serenity.LookupEditor;
        DivisionAdministrativaN4: Serenity.LookupEditor;
        DivisionAdministrativaN5: Serenity.LookupEditor;
        Direccion: Serenity.TextAreaEditor;
        Notas: Serenity.TextAreaEditor;
    }

    [['CodigoSitio', () => Serenity.StringEditor], ['ArrendadorId', () => InvArrendadoresEditor], ['RutaId', () => Serenity.LookupEditor], ['DivisionAdministrativaN1', () => Serenity.LookupEditor], ['DivisionAdministrativaN2', () => Serenity.LookupEditor], ['DivisionAdministrativaN3', () => Serenity.LookupEditor], ['DivisionAdministrativaN4', () => Serenity.LookupEditor], ['DivisionAdministrativaN5', () => Serenity.LookupEditor], ['Direccion', () => Serenity.TextAreaEditor], ['Notas', () => Serenity.TextAreaEditor]].forEach(x => Object.defineProperty(InvSitiosForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

