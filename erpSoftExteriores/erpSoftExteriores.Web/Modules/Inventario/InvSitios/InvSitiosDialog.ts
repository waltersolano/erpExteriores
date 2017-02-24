/// <reference path="../../common/helpers/basedialog.ts" />
namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvSitiosDialog extends Common.BaseDialog<InvSitiosRow, any> {
        protected getFormKey() { return InvSitiosForm.formKey; }
        protected getIdProperty() { return InvSitiosRow.idProperty; }
        protected getLocalTextPrefix() { return InvSitiosRow.localTextPrefix; }
        protected getNameProperty() { return InvSitiosRow.nameProperty; }
        protected getService() { return InvSitiosService.baseUrl; }
             
        protected form = new InvSitiosForm(this.idPrefix);

        protected updateInterface() {
            super.updateInterface();
            this.cloneButton.toggle(this.isEditMode());
        }

        /**
         * Overriding this method is optional to customize cloned entity
         */
        protected getCloningEntity() {
            var clone = super.getCloningEntity();
            var suffix = ' (Clone)';
            clone.CodigoSitio = null;
            clone.Notas = null;
            return clone;
        }

    }
}