/// <reference path="../../common/helpers/basedialog.ts" />
namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvCategoriasSoporteEstructuraDialog extends Common.BaseDialog<InvCategoriasSoporteEstructuraRow, any> {
        protected getFormKey() { return InvCategoriasSoporteEstructuraForm.formKey; }
        protected getIdProperty() { return InvCategoriasSoporteEstructuraRow.idProperty; }
        protected getLocalTextPrefix() { return InvCategoriasSoporteEstructuraRow.localTextPrefix; }
        protected getNameProperty() { return InvCategoriasSoporteEstructuraRow.nameProperty; }
        protected getService() { return InvCategoriasSoporteEstructuraService.baseUrl; }

        protected form = new InvCategoriasSoporteEstructuraForm(this.idPrefix);
    }
}