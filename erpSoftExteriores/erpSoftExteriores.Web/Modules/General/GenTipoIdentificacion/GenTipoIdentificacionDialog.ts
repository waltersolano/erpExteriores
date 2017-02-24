
namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenTipoIdentificacionDialog extends Serenity.EntityDialog<GenTipoIdentificacionRow, any> {
        protected getFormKey() { return GenTipoIdentificacionForm.formKey; }
        protected getIdProperty() { return GenTipoIdentificacionRow.idProperty; }
        protected getLocalTextPrefix() { return GenTipoIdentificacionRow.localTextPrefix; }
        protected getNameProperty() { return GenTipoIdentificacionRow.nameProperty; }
        protected getService() { return GenTipoIdentificacionService.baseUrl; }

        protected form = new GenTipoIdentificacionForm(this.idPrefix);
    }
}