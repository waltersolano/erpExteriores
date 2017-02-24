
namespace erpSoftExteriores.Logs {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class LogRegistroSimpleDialog extends Serenity.EntityDialog<LogRegistroSimpleRow, any> {
        protected getFormKey() { return LogRegistroSimpleForm.formKey; }
        protected getIdProperty() { return LogRegistroSimpleRow.idProperty; }
        protected getLocalTextPrefix() { return LogRegistroSimpleRow.localTextPrefix; }
        protected getNameProperty() { return LogRegistroSimpleRow.nameProperty; }
        protected getService() { return LogRegistroSimpleService.baseUrl; }

        protected form = new LogRegistroSimpleForm(this.idPrefix);
    }
}