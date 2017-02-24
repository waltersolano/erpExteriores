namespace erpSoftExteriores.Administration{

    @Serenity.Decorators.registerEditor()
    export class DateTime2Editor extends Serenity.StringEditor {
        constructor(input: JQuery) {
            super(input);
        }

        set_value(value: string) {
            value = Q.formatDate(Q.parseISODateTime(value), 'dd/MM/yyyy HH:mm tt');
            this.element.val(value);
        }      
    }
}