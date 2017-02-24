
namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenDivisionesAdministrativasN3Dialog extends Serenity.EntityDialog<GenDivisionesAdministrativasN3Row, any> {
        protected getFormKey() { return GenDivisionesAdministrativasN3Form.formKey; }
        protected getIdProperty() { return GenDivisionesAdministrativasN3Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN3Row.localTextPrefix; }
        protected getNameProperty() { return GenDivisionesAdministrativasN3Row.nameProperty; }
        protected getService() { return GenDivisionesAdministrativasN3Service.baseUrl; }

        protected form = new GenDivisionesAdministrativasN3Form(this.idPrefix);
        private nivel4Grid: nivel4Grid;
        private loadedState: string;



        constructor() {
            super();
            //alert("dialog2");
            this.nivel4Grid = new nivel4Grid(this.byId('nivel4Grid'));
            this.nivel4Grid.element.flexHeightOnly(1);

            //this.byId('NoteList').closest('.field').hide().end().appendTo(this.byId('TabNotes'));
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

        loadEntity(entity: GenDivisionesAdministrativasN3Row) {
            super.loadEntity(entity);
            Serenity.TabsExtensions.setDisabled(this.tabs, 'Orders', this.isNewOrDeleted());

            this.nivel4Grid.divisionSuperiorN3 = entity.Id;
        }
        onSaveSuccess(response) {
            super.onSaveSuccess(response);

            Q.reloadLookup('General.DivisionesAdministrativasN3');
        }
    }
}