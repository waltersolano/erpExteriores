/// <reference path="../../common/helpers/basedialog.ts" />

namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvSitiosContratosArrendamientoDialog extends Common.BaseDialog<InvSitiosContratosArrendamientoRow, any> {
        protected getFormKey() { return InvSitiosContratosArrendamientoForm.formKey; }
        protected getIdProperty() { return InvSitiosContratosArrendamientoRow.idProperty; }
        protected getLocalTextPrefix() { return InvSitiosContratosArrendamientoRow.localTextPrefix; }
        protected getNameProperty() { return InvSitiosContratosArrendamientoRow.nameProperty; }
        protected getService() { return InvSitiosContratosArrendamientoService.baseUrl; }
        protected form = new InvSitiosContratosArrendamientoForm(this.idPrefix);
        private loadedState: string;

        constructor(isReadOnly) {
            super(isReadOnly);
            this.byId('NoteList').closest('.field').hide().end().appendTo(this.byId('TabNotes'));
            //this.byId('LegalInfoId').closest('.field').appendTo(this.byId('TabLegal').find(".s-Form"));

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


        protected updateInterface() {
            super.updateInterface();
            this.cloneButton.toggle(this.isEditMode());
        }

        protected getCloningEntity() {
            var clone = super.getCloningEntity();
            var suffix = ' (Clone)';
            clone.NumeroContrato = null;
            return clone;
        }

  }
}