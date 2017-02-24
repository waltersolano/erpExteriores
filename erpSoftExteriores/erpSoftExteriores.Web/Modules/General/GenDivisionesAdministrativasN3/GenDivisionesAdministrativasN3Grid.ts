
namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenDivisionesAdministrativasN3Grid extends Serenity.EntityGrid<GenDivisionesAdministrativasN3Row, any> {
        protected getColumnsKey() { return 'General.GenDivisionesAdministrativasN3'; }
        protected getDialogType() { return GenDivisionesAdministrativasN3Dialog; }
        protected getIdProperty() { return GenDivisionesAdministrativasN3Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN3Row.localTextPrefix; }
        protected getService() { return GenDivisionesAdministrativasN3Service.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}