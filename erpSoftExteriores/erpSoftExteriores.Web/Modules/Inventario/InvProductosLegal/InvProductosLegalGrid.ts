/// <reference path="../../common/helpers/basegrid.ts" />
namespace erpSoftExteriores.Inventario {
    
    @Serenity.Decorators.registerClass()
    export class InvProductosLegalGrid extends Common.BaseGrid<InvProductosLegalRow, any> {
        protected getColumnsKey() { return 'Inventario.InvProductosLegal'; }
        protected getDialogType() { return InvProductosLegalDialog; }
        protected getIdProperty() { return InvProductosLegalRow.idProperty; }
        protected getLocalTextPrefix() { return InvProductosLegalRow.localTextPrefix; }
        protected getService() { return InvProductosLegalService.baseUrl; }

    }
}