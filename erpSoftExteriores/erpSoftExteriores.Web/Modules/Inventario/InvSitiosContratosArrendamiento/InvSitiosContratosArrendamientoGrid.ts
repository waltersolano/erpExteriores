/// <reference path="../../common/helpers/basegrid.ts" />

namespace erpSoftExteriores.Inventario {
    
    @Serenity.Decorators.registerClass()
    export class InvSitiosContratosArrendamientoGrid extends Common.BaseGrid<InvSitiosContratosArrendamientoRow, any> {
        protected getColumnsKey() { return 'Inventario.InvSitiosContratosArrendamiento'; }
        protected getDialogType() { return InvSitiosContratosArrendamientoDialog; }
        protected getIdProperty() { return InvSitiosContratosArrendamientoRow.idProperty; }
        protected getLocalTextPrefix() { return InvSitiosContratosArrendamientoRow.localTextPrefix; }
        protected getService() { return InvSitiosContratosArrendamientoService.baseUrl; }


    }
}