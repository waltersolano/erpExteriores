/// <reference path="../../common/helpers/basedialog.ts" />
namespace erpSoftExteriores.Inventario {


    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvProductosLegalDialog extends Common.BaseDialog<InvProductosLegalRow, any> {
        protected getFormKey() { return InvProductosLegalForm.formKey; }
        protected getIdProperty() { return InvProductosLegalRow.idProperty; }
        protected getLocalTextPrefix() { return InvProductosLegalRow.localTextPrefix; }
        protected getNameProperty() { return InvProductosLegalRow.nameProperty; }
        protected getService() { return InvProductosLegalService.baseUrl; }
        protected form = new InvProductosLegalForm(this.idPrefix);
        private ProductosAsociadosGrid: ProductosAsociadosGrid;
        private loadedState: string;

        protected beforeLoadEntity(entity) {
            super.beforeLoadEntity(entity);
            this.ProductosAsociadosGrid = new ProductosAsociadosGrid(this.byId('ProductosAsociadosGrid'), this.isReadOnly);
            this.ProductosAsociadosGrid.getElement();
            this.ProductosAsociadosGrid.element.flexHeightOnly(1);

            DialogUtils.pendingChangesConfirmation(this.element, () => this.getSaveState() != this.loadedState);
            this.tabs.bind('tabsactivate', () => this.arrange());
        }

        getSaveState() {
            try {
                return $.toJSON(this.getSaveEntity());
            }
            catch (e) {
                return null;
            }
        }

        loadResponse(data) {
            super.loadResponse(data);
            this.loadedState = this.getSaveState();
        }

        loadEntity(entity: InvArrendadoresRow) {
            super.loadEntity(entity);
            Serenity.TabsExtensions.setDisabled(this.tabs, 'ProductosAsociados', this.isNewOrDeleted());
            this.ProductosAsociadosGrid.LegalInfoId = entity.Id;
            
        }

        onSaveSuccess(response) {
            super.onSaveSuccess(response);
            Q.reloadLookup('Inventario.InvProductosLegal');
        }

    }
}