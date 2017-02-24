
namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenMonedasDialog extends Serenity.EntityDialog<GenMonedasRow, any> {
        protected getFormKey() { return GenMonedasForm.formKey; }
        protected getIdProperty() { return GenMonedasRow.idProperty; }
        protected getLocalTextPrefix() { return GenMonedasRow.localTextPrefix; }
        protected getNameProperty() { return GenMonedasRow.nameProperty; }
        protected getService() { return GenMonedasService.baseUrl; }

        protected form = new GenMonedasForm(this.idPrefix);
    }
}