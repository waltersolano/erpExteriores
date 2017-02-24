/// <reference path="../../common/helpers/basegrid.ts" />
namespace erpSoftExteriores.Inventario {
    
    @Serenity.Decorators.registerClass()
    export class InvSitiosGrid extends Common.BaseGrid<InvSitiosRow, any> {
        protected getColumnsKey() { return 'Inventario.InvSitios'; }
        protected getDialogType() { return InvSitiosDialog; }
        protected getIdProperty() { return InvSitiosRow.idProperty; }
        protected getLocalTextPrefix() { return InvSitiosRow.localTextPrefix; }
        protected getService() { return InvSitiosService.baseUrl; }


        protected createQuickFilters(): void {
            super.createQuickFilters();

            let da = new erpSoftExteriores.Common.divisionesAdministrativas();
            let fields = erpSoftExteriores.Inventario.InvSitiosRow.Fields;
            let filterFields = [
                fields.DivisionAdministrativaN1,
                fields.DivisionAdministrativaN2,
                fields.DivisionAdministrativaN3,
                fields.DivisionAdministrativaN4,
                fields.DivisionAdministrativaN5
            ];
            da.addFilterEvents(this, filterFields);
        }


        protected getButtons() {
            var buttons = super.getButtons();
            buttons.push(
                {
                    title: 'Arrendador',
                    hint: 'Agrupar por Arrendador',
                    cssClass: 'expand-all-button',
                    onClick: () => this.view.setGrouping(
                        [{
                            getter: 'ArrendadorNombre'
                        }])
                }
            );

            buttons.push(
                {
                    title: 'Provincia',
                    hint: 'Agrupar por Provincia',
                    cssClass: 'expand-all-button',
                    onClick: () => this.view.setGrouping(
                        [{
                            getter: 'DivisionAdministrativaN1Nombre'
                        }])
                }
            );

            buttons.push(
                {
                    title: 'Quitar',
                    cssClass: 'collapse-all-button',
                    onClick: () => this.view.setGrouping([])
                }
            );
            return buttons;
        }

    }
}