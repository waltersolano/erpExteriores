
namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenDivisionesAdministrativasN4Dialog extends Serenity.EntityDialog<GenDivisionesAdministrativasN4Row, any> {
        protected getFormKey() { return GenDivisionesAdministrativasN4Form.formKey; }
        protected getIdProperty() { return GenDivisionesAdministrativasN4Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN4Row.localTextPrefix; }
        protected getNameProperty() { return GenDivisionesAdministrativasN4Row.nameProperty; }
        protected getService() { return GenDivisionesAdministrativasN4Service.baseUrl; }

        protected form = new GenDivisionesAdministrativasN4Form(this.idPrefix);

        private nivel5Grid: nivel5Grid;
        private loadedState: string;



        constructor() {
            super();
            //alert("dialog2");
            this.nivel5Grid = new nivel5Grid(this.byId('nivel5Grid'));
            this.nivel5Grid.element.flexHeightOnly(1);

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
            //   console.log("data", data);
            super.loadResponse(data);
            this.loadedState = this.getSaveState();
        }

        loadEntity(entity: GenDivisionesAdministrativasN4Row) {
            super.loadEntity(entity);
            //   console.log("entity", entity);
            Serenity.TabsExtensions.setDisabled(this.tabs, 'Orders', this.isNewOrDeleted());

            this.nivel5Grid.divisionSuperiorN4 = entity.Id;
            //   console.log("this.nivel4Grid", this.nivel4Grid);
        }
        onSaveSuccess(response) {
            super.onSaveSuccess(response);

            Q.reloadLookup('General.DivisionesAdministrativasN4');
        }
    }
}