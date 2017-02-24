
namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenMonedasGrid extends Serenity.EntityGrid<GenMonedasRow, any> {
        protected getColumnsKey() { return 'General.GenMonedas'; }
        protected getDialogType() { return GenMonedasDialog; }
        protected getIdProperty() { return GenMonedasRow.idProperty; }
        protected getLocalTextPrefix() { return GenMonedasRow.localTextPrefix; }
        protected getService() { return GenMonedasService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}