/// <reference path="../../common/helpers/basegrid.ts" />
namespace erpSoftExteriores.Inventario {
    @Serenity.Decorators.registerClass()
    export class InvTiposEstructuraGrid extends Common.BaseGrid<InvTiposEstructuraRow, any> {
        protected getColumnsKey() { return 'Inventario.InvTiposEstructura'; }
        protected getDialogType() { return InvTiposEstructuraDialog; }
        protected getIdProperty() { return InvTiposEstructuraRow.idProperty; }
        protected getLocalTextPrefix() { return InvTiposEstructuraRow.localTextPrefix; }
        protected getService() { return InvTiposEstructuraService.baseUrl; }

        protected getButtons() {
            var buttons = super.getButtons();
            buttons.push(
                {
                    title: 'Agrupar',
                    hint: 'Agrupar por Categoría',
                    cssClass: 'expand-all-button',
                    onClick: () => this.view.setGrouping(
                        [{
                            getter: 'CategoriasSoporteEstructuraNombre'
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