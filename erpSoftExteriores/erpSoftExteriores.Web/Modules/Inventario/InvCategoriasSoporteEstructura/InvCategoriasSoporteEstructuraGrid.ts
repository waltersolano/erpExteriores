/// <reference path="../../common/helpers/basegrid.ts" />
namespace erpSoftExteriores.Inventario {
    
    @Serenity.Decorators.registerClass()
    export class InvCategoriasSoporteEstructuraGrid extends Common.BaseGrid<InvCategoriasSoporteEstructuraRow, any> {
        protected getColumnsKey() { return 'Inventario.InvCategoriasSoporteEstructura'; }
        protected getDialogType() { return InvCategoriasSoporteEstructuraDialog; }
        protected getIdProperty() { return InvCategoriasSoporteEstructuraRow.idProperty; }
        protected getLocalTextPrefix() { return InvCategoriasSoporteEstructuraRow.localTextPrefix; }
        protected getService() { return InvCategoriasSoporteEstructuraService.baseUrl; }

    /*    constructor(container: JQuery, isReadOnly: boolean) {
            super(container, isReadOnly);
        }*/
    }
}