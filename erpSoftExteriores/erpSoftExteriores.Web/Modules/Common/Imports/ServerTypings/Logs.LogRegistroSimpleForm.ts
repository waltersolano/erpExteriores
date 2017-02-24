namespace erpSoftExteriores.Logs {
    export class LogRegistroSimpleForm extends Serenity.PrefixedContext {
        static formKey = 'Logs.LogRegistroSimple';

    }

    export interface LogRegistroSimpleForm {
        EntityType: Serenity.StringEditor;
        EntityId: Serenity.StringEditor;
        UsuarioRegistraId: Serenity.IntegerEditor;
        FechaRegistro: Serenity.DateEditor;
        UsuarioModifica: Serenity.IntegerEditor;
        FechaModifica: Serenity.DateEditor;
        Texto1: Serenity.StringEditor;
        Texto2: Serenity.StringEditor;
        Ip1: Serenity.StringEditor;
        Ip2: Serenity.StringEditor;
    }

    [['EntityType', () => Serenity.StringEditor], ['EntityId', () => Serenity.StringEditor], ['UsuarioRegistraId', () => Serenity.IntegerEditor], ['FechaRegistro', () => Serenity.DateEditor], ['UsuarioModifica', () => Serenity.IntegerEditor], ['FechaModifica', () => Serenity.DateEditor], ['Texto1', () => Serenity.StringEditor], ['Texto2', () => Serenity.StringEditor], ['Ip1', () => Serenity.StringEditor], ['Ip2', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(LogRegistroSimpleForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

