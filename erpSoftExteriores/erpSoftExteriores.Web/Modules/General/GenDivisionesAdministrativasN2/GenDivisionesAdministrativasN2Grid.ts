
namespace erpSoftExteriores.General {
    
    @Serenity.Decorators.registerClass()
    export class GenDivisionesAdministrativasN2Grid extends Serenity.EntityGrid<GenDivisionesAdministrativasN2Row, any> {
        protected getColumnsKey() { return 'General.GenDivisionesAdministrativasN2'; }
        protected getDialogType() { return GenDivisionesAdministrativasN2Dialog; }
        protected getIdProperty() { return GenDivisionesAdministrativasN2Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN2Row.localTextPrefix; }
        protected getService() { return GenDivisionesAdministrativasN2Service.baseUrl; }

        constructor(container: JQuery) {
            super(container);
           
        }
    }
}