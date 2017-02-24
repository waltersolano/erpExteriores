
namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenDivisionesAdministrativasN1Grid extends Serenity.EntityGrid<GenDivisionesAdministrativasN1Row, any> {
        protected getColumnsKey() { return 'General.GenDivisionesAdministrativasN1'; }
        protected getDialogType() { return GenDivisionesAdministrativasN1Dialog; }
        protected getIdProperty() { return GenDivisionesAdministrativasN1Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN1Row.localTextPrefix; }
        protected getService() { return GenDivisionesAdministrativasN1Service.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}