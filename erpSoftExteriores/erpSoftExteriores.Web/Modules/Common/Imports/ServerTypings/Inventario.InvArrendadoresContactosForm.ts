namespace erpSoftExteriores.Inventario {
    export class InvArrendadoresContactosForm extends Serenity.PrefixedContext {
        static formKey = 'Inventario.InvArrendadoresContactos';

    }

    export interface InvArrendadoresContactosForm {
        ArrendadorId: InvArrendadoresEditor;
        Nombre: Serenity.StringEditor;
        Telefono1: Common.IntPhoneEditor;
        Telefono2: Common.IntPhoneEditor;
        Telefono3: Common.IntPhoneEditor;
        Email: Serenity.EmailEditor;
        Cargo: Serenity.StringEditor;
    }

    [['ArrendadorId', () => InvArrendadoresEditor], ['Nombre', () => Serenity.StringEditor], ['Telefono1', () => Common.IntPhoneEditor], ['Telefono2', () => Common.IntPhoneEditor], ['Telefono3', () => Common.IntPhoneEditor], ['Email', () => Serenity.EmailEditor], ['Cargo', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(InvArrendadoresContactosForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

