/// <reference path="../../common/helpers/basegrid.ts" />
namespace erpSoftExteriores.Inventario {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.filterable()
    export class InvArrendadoresContactosGrid extends Common.BaseGrid<InvArrendadoresContactosRow, any> {
        protected getColumnsKey() { return 'Inventario.InvArrendadoresContactos'; }
        protected getDialogType() { return InvArrendadoresContactosDialog; }
        protected getIdProperty() { return InvArrendadoresContactosRow.idProperty; }
       // protected getReadOnlyDialogType() { return ReadOnlyInvArrendadoresContactosDialog; }
        protected getLocalTextPrefix() { return InvArrendadoresContactosRow.localTextPrefix; }
        protected getService() { return InvArrendadoresContactosService.baseUrl; }

        protected getButtons() {
            var buttons = super.getButtons();
            buttons.push(
                {
                    title: 'Agrupar',
                    hint:'Agrupar por Arrendador',
                    cssClass: 'expand-all-button',
                    onClick: () => this.view.setGrouping(
                        [{
                            getter: 'ArrendadorNombre'
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