
namespace erpSoftExteriores.Logs {
    
    @Serenity.Decorators.registerClass()
    export class LogRegistroSimpleGrid extends Serenity.EntityGrid<LogRegistroSimpleRow, any> {
        protected getColumnsKey() { return 'Logs.LogRegistroSimple'; }
        protected getDialogType() { return LogRegistroSimpleDialog; }
        protected getIdProperty() { return LogRegistroSimpleRow.idProperty; }
        protected getLocalTextPrefix() { return LogRegistroSimpleRow.localTextPrefix; }
        protected getService() { return LogRegistroSimpleService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}