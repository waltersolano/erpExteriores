/// <reference path="../../common/helpers/basegrid.ts" />
namespace erpSoftExteriores.Inventario {
    
    @Serenity.Decorators.registerClass()
    export class InvStatusGrid extends Common.BaseGrid<InvStatusRow, any> {
        protected getColumnsKey() { return 'Inventario.InvStatus'; }
        protected getDialogType() { return InvStatusDialog; }
        protected getIdProperty() { return InvStatusRow.idProperty; }
        protected getLocalTextPrefix() { return InvStatusRow.localTextPrefix; }
        protected getService() { return InvStatusService.baseUrl; }

    }
}