/// <reference path="../../common/helpers/basegrid.ts" />

namespace erpSoftExteriores.Inventario {
    
    @Serenity.Decorators.registerClass()
    export class InvArrendadoresGrid extends Common.BaseGrid<InvArrendadoresRow, any> {
        protected getColumnsKey() { return 'Inventario.InvArrendadores'; }
        protected getDialogType() { return InvArrendadoresDialog; }
        protected getIdProperty() { return InvArrendadoresRow.idProperty; }
        protected getLocalTextPrefix() { return InvArrendadoresRow.localTextPrefix; }
        protected getService() { return InvArrendadoresService.baseUrl; }
    }
}