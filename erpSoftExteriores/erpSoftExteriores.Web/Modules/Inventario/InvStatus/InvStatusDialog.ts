/// <reference path="../../common/helpers/basedialog.ts" />
namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvStatusDialog extends Common.BaseDialog<InvStatusRow, any> {
        protected getFormKey() { return InvStatusForm.formKey; }
        protected getIdProperty() { return InvStatusRow.idProperty; }
        protected getLocalTextPrefix() { return InvStatusRow.localTextPrefix; }
        protected getNameProperty() { return InvStatusRow.nameProperty; }
        protected getService() { return InvStatusService.baseUrl; }

        protected form = new InvStatusForm(this.idPrefix);
    }
}