/// <reference path="../../common/helpers/basegrid.ts" />

namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    export class ProductosAsociadosGrid extends Common.BaseGrid<InvProductosRow, any> {
        protected getColumnsKey() { return 'Inventario.InvProductos'; }
        protected getDialogType() { return InvProductosDialog; }
        protected getIdProperty() { return InvProductosRow.idProperty; }
        protected getLocalTextPrefix() { return InvProductosRow.localTextPrefix; }
        protected getService() { return InvProductosService.baseUrl; }

        protected getColumns(): Slick.Column[] {
            let fld = InvProductosRow.Fields;
            let columns = super.getColumns();
            columns = columns.filter(x => x.field !== fld.LegalInfoId);
            columns = columns.filter(x => x.field !== "Edit");
            //columns = columns.filter(x => x.field !== "View");
            return columns;
        }


        protected createQuickFilters(): void { }

        protected getButtons() {
            return [];
        };

        protected initEntityDialog(itemType, dialog) {
            super.initEntityDialog(itemType, dialog);
            Serenity.SubDialogHelper.cascade(dialog, this.element.closest('.ui-dialog'));
        }

        protected addButtonClick() {
            this.editItem(<InvProductosRow>{
                LegalInfoId: this.LegalInfoId
            });
        }

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.LegalInfoId;
        }

        private _LegalInfoId: number;

        get LegalInfoId() {
            return this._LegalInfoId;
        }

        set LegalInfoId(value: number) {
            if (this._LegalInfoId !== value) {
                this._LegalInfoId = value;
                this.setEquality('LegalInfoId', value);
                this.refresh();
            }

        }

       

    }
}