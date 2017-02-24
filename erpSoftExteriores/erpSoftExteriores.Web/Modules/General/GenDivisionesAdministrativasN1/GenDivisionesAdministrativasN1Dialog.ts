
namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenDivisionesAdministrativasN1Dialog extends Serenity.EntityDialog<GenDivisionesAdministrativasN1Row, any> {
        protected getFormKey() { return GenDivisionesAdministrativasN1Form.formKey; }
        protected getIdProperty() { return GenDivisionesAdministrativasN1Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN1Row.localTextPrefix; }
        protected getNameProperty() { return GenDivisionesAdministrativasN1Row.nameProperty; }
        protected getService() { return GenDivisionesAdministrativasN1Service.baseUrl; }
        protected form = new GenDivisionesAdministrativasN1Form(this.idPrefix);
        private nivel2Grid: nivel2Grid;
        private loadedState: string;

        constructor() {
            super();

            this.nivel2Grid = new nivel2Grid(this.byId('nivel2Grid'));
            this.nivel2Grid.element.flexHeightOnly(1);
            this.byId('NoteList').closest('.field').hide().end().appendTo(this.byId('TabNotes'));
            DialogUtils.pendingChangesConfirmation(this.element, () => this.getSaveState() != this.loadedState);
            this.tabs.bind('tabsactivate', () => this.arrange());
        }

        getSaveState() {
            try {
                return $.toJSON(this.getSaveEntity());
            }
            catch (e) {
                return null;
            }
        }

        loadResponse(data) {
            super.loadResponse(data);
            this.loadedState = this.getSaveState();
        }

        loadEntity(entity: GenDivisionesAdministrativasN1Row) {
            super.loadEntity(entity);
            Serenity.TabsExtensions.setDisabled(this.tabs, 'Orders', this.isNewOrDeleted());
            this.nivel2Grid.divisionSuperiorN1 = entity.Id;
        }

        onSaveSuccess(response) {
            super.onSaveSuccess(response);
            Q.reloadLookup('General.DivisionesAdministrativasN1');
        }
    }
}