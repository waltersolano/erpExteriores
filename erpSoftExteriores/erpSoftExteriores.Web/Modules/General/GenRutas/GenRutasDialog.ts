
namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenRutasDialog extends Serenity.EntityDialog<GenRutasRow, any> {
        protected getFormKey() { return GenRutasForm.formKey; }
        protected getIdProperty() { return GenRutasRow.idProperty; }
        protected getLocalTextPrefix() { return GenRutasRow.localTextPrefix; }
        protected getNameProperty() { return GenRutasRow.nameProperty; }
        protected getService() { return GenRutasService.baseUrl; }

        protected form = new GenRutasForm(this.idPrefix);
    }
}