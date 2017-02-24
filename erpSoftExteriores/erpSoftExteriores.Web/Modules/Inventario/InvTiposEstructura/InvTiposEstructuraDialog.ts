/// <reference path="../../common/helpers/basedialog.ts" />
namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvTiposEstructuraDialog extends Common.BaseDialog<InvTiposEstructuraRow, any> {
        protected getFormKey() { return InvTiposEstructuraForm.formKey; }
        protected getIdProperty() { return InvTiposEstructuraRow.idProperty; }
        protected getLocalTextPrefix() { return InvTiposEstructuraRow.localTextPrefix; }
        protected getNameProperty() { return InvTiposEstructuraRow.nameProperty; }
        protected getService() { return InvTiposEstructuraService.baseUrl; }

        protected form = new InvTiposEstructuraForm(this.idPrefix);
    }
}