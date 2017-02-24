
namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenDivisionesAdministrativasN5Dialog extends Serenity.EntityDialog<GenDivisionesAdministrativasN5Row, any> {
        protected getFormKey() { return GenDivisionesAdministrativasN5Form.formKey; }
        protected getIdProperty() { return GenDivisionesAdministrativasN5Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN5Row.localTextPrefix; }
        protected getNameProperty() { return GenDivisionesAdministrativasN5Row.nameProperty; }
        protected getService() { return GenDivisionesAdministrativasN5Service.baseUrl; }

        protected form = new GenDivisionesAdministrativasN5Form(this.idPrefix);
    }
}