/// <reference path="../../common/helpers/basegrid.ts" />

namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenTipoPagoGrid extends Common.BaseGrid<GenTipoPagoRow, any> {
        protected getColumnsKey() { return 'General.GenTipoPago'; }
        protected getDialogType() { return GenTipoPagoDialog; }
        protected getIdProperty() { return GenTipoPagoRow.idProperty; }
        protected getLocalTextPrefix() { return GenTipoPagoRow.localTextPrefix; }
        protected getService() { return GenTipoPagoService.baseUrl; }

    }
}