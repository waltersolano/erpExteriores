namespace erpSoftExteriores.Inventario {
    export class InvArrendadoresForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvArrendadores';

    }

    export interface InvArrendadoresForm {
        TipoId: Serenity.LookupEditor;
        Nombre: Serenity.StringEditor;
        Identificacion: Serenity.StringEditor;
        Direccion: Serenity.StringEditor;
        Emails: Serenity.EmailEditor;
        Website: Serenity.URLEditor;
        CodigoPostal: Serenity.StringEditor;
        NombreRepresentante: Serenity.StringEditor;
        TipoIdRepresentante: Serenity.LookupEditor;
        IdentificacionRepresentante: Serenity.StringEditor;
    }

    [['TipoId', () => Serenity.LookupEditor], ['Nombre', () => Serenity.StringEditor], ['Identificacion', () => Serenity.StringEditor], ['Direccion', () => Serenity.StringEditor], ['Emails', () => Serenity.EmailEditor], ['Website', () => Serenity.URLEditor], ['CodigoPostal', () => Serenity.StringEditor], ['NombreRepresentante', () => Serenity.StringEditor], ['TipoIdRepresentante', () => Serenity.LookupEditor], ['IdentificacionRepresentante', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(InvArrendadoresForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

