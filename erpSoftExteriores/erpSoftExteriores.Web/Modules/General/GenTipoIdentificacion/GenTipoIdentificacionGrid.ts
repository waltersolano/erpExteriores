
namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenTipoIdentificacionGrid extends Serenity.EntityGrid<GenTipoIdentificacionRow, any> {
        protected getColumnsKey() { return 'General.GenTipoIdentificacion'; }
        protected getDialogType() { return GenTipoIdentificacionDialog; }
        protected getIdProperty() { return GenTipoIdentificacionRow.idProperty; }
        protected getLocalTextPrefix() { return GenTipoIdentificacionRow.localTextPrefix; }
        protected getService() { return GenTipoIdentificacionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}