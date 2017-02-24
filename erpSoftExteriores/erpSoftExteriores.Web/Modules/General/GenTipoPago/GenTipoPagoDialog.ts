/// <reference path="../../common/helpers/basedialog.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenTipoPagoDialog extends Common.BaseDialog<GenTipoPagoRow, any> {
        protected getFormKey() { return GenTipoPagoForm.formKey; }
        protected getIdProperty() { return GenTipoPagoRow.idProperty; }
        protected getLocalTextPrefix() { return GenTipoPagoRow.localTextPrefix; }
        protected getNameProperty() { return GenTipoPagoRow.nameProperty; }
        protected getService() { return GenTipoPagoService.baseUrl; }

        protected form = new GenTipoPagoForm(this.idPrefix);

    }
}