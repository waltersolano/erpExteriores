
namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenDivisionesAdministrativasN4Grid extends Serenity.EntityGrid<GenDivisionesAdministrativasN4Row, any> {
        protected getColumnsKey() { return 'General.GenDivisionesAdministrativasN4'; }
        protected getDialogType() { return GenDivisionesAdministrativasN4Dialog; }
        protected getIdProperty() { return GenDivisionesAdministrativasN4Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN4Row.localTextPrefix; }
        protected getService() { return GenDivisionesAdministrativasN4Service.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}