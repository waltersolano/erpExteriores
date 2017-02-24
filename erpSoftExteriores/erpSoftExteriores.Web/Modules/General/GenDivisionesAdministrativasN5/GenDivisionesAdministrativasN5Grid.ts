
namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenDivisionesAdministrativasN5Grid extends Serenity.EntityGrid<GenDivisionesAdministrativasN5Row, any> {
        protected getColumnsKey() { return 'General.GenDivisionesAdministrativasN5'; }
        protected getDialogType() { return GenDivisionesAdministrativasN5Dialog; }
        protected getIdProperty() { return GenDivisionesAdministrativasN5Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN5Row.localTextPrefix; }
        protected getService() { return GenDivisionesAdministrativasN5Service.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}