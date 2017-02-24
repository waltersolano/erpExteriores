/// <reference path="../../common/helpers/basedialog.ts" />
namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvArrendadoresContactosDialog extends Common.BaseDialog<InvArrendadoresContactosRow, any> {
        protected getFormKey() { return InvArrendadoresContactosForm.formKey; }
        protected getIdProperty() { return InvArrendadoresContactosRow.idProperty; }
        protected getLocalTextPrefix() { return InvArrendadoresContactosRow.localTextPrefix; }
        protected getNameProperty() { return InvArrendadoresContactosRow.nameProperty; }
        protected getService() { return InvArrendadoresContactosService.baseUrl; }

        protected form = new InvArrendadoresContactosForm(this.idPrefix);


    }
}