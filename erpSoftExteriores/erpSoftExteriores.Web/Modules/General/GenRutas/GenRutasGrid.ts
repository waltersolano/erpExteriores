
namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenRutasGrid extends Serenity.EntityGrid<GenRutasRow, any> {
        protected getColumnsKey() { return 'General.GenRutas'; }
        protected getDialogType() { return GenRutasDialog; }
        protected getIdProperty() { return GenRutasRow.idProperty; }
        protected getLocalTextPrefix() { return GenRutasRow.localTextPrefix; }
        protected getService() { return GenRutasService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}