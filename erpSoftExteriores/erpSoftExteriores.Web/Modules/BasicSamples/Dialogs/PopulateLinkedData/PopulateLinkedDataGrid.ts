/// <reference path="../../../Northwind/Order/OrderGrid.ts" />

namespace erpSoftExteriores.BasicSamples {

    /**
     * A subclass of OrderGrid that launches PopulateLinkedDataDialog
     */
    @Serenity.Decorators.registerClass()
    export class PopulateLinkedDataGrid extends Northwind.OrderGrid {

        protected getDialogType() { return PopulateLinkedDataDialog; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}