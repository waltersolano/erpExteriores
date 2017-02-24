
namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class GenDivisionesAdministrativasN2Dialog extends Serenity.EntityDialog<GenDivisionesAdministrativasN2Row, any> {
        protected getFormKey() { return GenDivisionesAdministrativasN2Form.formKey; }
        protected getIdProperty() { return GenDivisionesAdministrativasN2Row.idProperty; }
        protected getLocalTextPrefix() { return GenDivisionesAdministrativasN2Row.localTextPrefix; }
        protected getNameProperty() { return GenDivisionesAdministrativasN2Row.nameProperty; }
        protected getService() { return GenDivisionesAdministrativasN2Service.baseUrl; }

        protected form = new GenDivisionesAdministrativasN2Form(this.idPrefix);
        private nivel3Grid: nivel3Grid;
        private loadedState: string;



        constructor() {
            super();
            //alert("dialog2");
            this.nivel3Grid = new nivel3Grid(this.byId('nivel3Grid'));
            this.nivel3Grid.element.flexHeightOnly(1);

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

        loadEntity(entity: GenDivisionesAdministrativasN2Row) {
            super.loadEntity(entity);
         //   console.log("entity", entity);
            Serenity.TabsExtensions.setDisabled(this.tabs, 'Orders', this.isNewOrDeleted());

            this.nivel3Grid.divisionSuperiorN2 = entity.Id;
         //   console.log("this.nivel3Grid", this.nivel3Grid);

        }

        onSaveSuccess(response) {
            super.onSaveSuccess(response);

            Q.reloadLookup('General.DivisionesAdministrativasN2');
        }




    }
}