/// <reference path="../../common/helpers/basegrid.ts" />
namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    export class InvProductosGrid extends Common.BaseGrid<InvProductosRow, any> {
        protected getColumnsKey() { return 'Inventario.InvProductos'; }
        protected getDialogType() { return InvProductosDialog; }
        protected getIdProperty() { return InvProductosRow.idProperty; }
        protected getLocalTextPrefix() { return InvProductosRow.localTextPrefix; }
        protected getService() { return InvProductosService.baseUrl; }

        protected createQuickFilters(): void {
            super.createQuickFilters();

            let da = new erpSoftExteriores.Common.divisionesAdministrativas();
            let fields = erpSoftExteriores.Inventario.InvProductosRow.Fields;
            let filterFields = [
                fields.SitioDivisionAdministrativaN1,
                fields.SitioDivisionAdministrativaN2,
                fields.SitioDivisionAdministrativaN3,
                fields.SitioDivisionAdministrativaN4,
                fields.SitioDivisionAdministrativaN5
            ];
            da.addFilterEvents(this, filterFields);
        }

        /**
         * This method is called for all rows
         * @param item Data item for current row
         * @param index Index of the row in grid
         */
        protected getItemCssClass(item: Inventario.InvProductosRow, index: number): string {


            let klass: string = "";

            if (item.EstatusId == 1)
                klass += "estatus-uno";
            else if (item.EstatusId == 2)
                klass += "estatus-dos";
            else if (item.EstatusId == 3)
                klass += "estatus-tres";
            else if (item.EstatusId == 4)
                klass += "estatus-cuatro";
            else if (item.EstatusId == 5)
                klass += "estatus-cinco";

            return Q.trimToNull(klass);
        }

    }
}