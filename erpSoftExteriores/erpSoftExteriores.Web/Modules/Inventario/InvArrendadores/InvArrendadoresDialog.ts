/// <reference path="../../common/helpers/basedialog.ts" />
namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvArrendadoresDialog extends Common.BaseDialog<InvArrendadoresRow, any> {
        protected getFormKey() { return InvArrendadoresForm.formKey; }
        protected getIdProperty() { return InvArrendadoresRow.idProperty; }
        protected getLocalTextPrefix() { return InvArrendadoresRow.localTextPrefix; }
        protected getNameProperty() { return InvArrendadoresRow.nameProperty; }
        protected getService() { return InvArrendadoresService.baseUrl; }
        protected form = new InvArrendadoresForm(this.idPrefix);
        private ArrendadoresContactosGrid: ArrendadoresContactosGrid;
        private loadedState: string;

        protected beforeLoadEntity(entity) {
            super.beforeLoadEntity(entity);
            this.ArrendadoresContactosGrid = new ArrendadoresContactosGrid(this.byId('ArrendadoresContactosGrid'), this.isReadOnly);
            this.ArrendadoresContactosGrid.getElement()
            this.ArrendadoresContactosGrid.element.flexHeightOnly(1);

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

        loadEntity(entity: InvArrendadoresRow) {
            super.loadEntity(entity);
            Serenity.TabsExtensions.setDisabled(this.tabs, 'Orders', this.isNewOrDeleted());
            this.ArrendadoresContactosGrid.ArrendadorId = entity.Id;
        }

        onSaveSuccess(response) {
            super.onSaveSuccess(response);
            Q.reloadLookup('Inventario.Arrendadores');
        }

        protected updateInterface(): void {
            super.updateInterface();

            if (this.isReadOnly === false) {


                if (this.form.TipoId.value != "4") {
                    Serenity.EditorUtils.setReadonly(this.element.find('.NombreRepresentante').find(".editor"), true);
                    Serenity.EditorUtils.setReadonly(this.element.find('.TipoIdRepresentante').find(".editor"), true);
                    Serenity.EditorUtils.setReadonly(this.element.find('.IdentificacionRepresentante').find(".editor"), true);
                }
                else {
                    Serenity.EditorUtils.setReadonly(this.element.find('.NombreRepresentante').find(".editor"), false);
                    Serenity.EditorUtils.setReadonly(this.element.find('.TipoIdRepresentante').find(".editor"), false);
                    Serenity.EditorUtils.setReadonly(this.element.find('.IdentificacionRepresentante').find(".editor"), false);
                }

                this.form.TipoId.changeSelect2(e => {
                    if (this.form.TipoId.value != "4") {
                        Serenity.EditorUtils.setReadonly(this.element.find('.NombreRepresentante').find(".editor"), true);
                        Serenity.EditorUtils.setReadonly(this.element.find('.TipoIdRepresentante').find(".editor"), true);
                        Serenity.EditorUtils.setReadonly(this.element.find('.IdentificacionRepresentante').find(".editor"), true);
                    }
                    else {
                        Serenity.EditorUtils.setReadonly(this.element.find('.NombreRepresentante').find(".editor"), false);
                        Serenity.EditorUtils.setReadonly(this.element.find('.TipoIdRepresentante').find(".editor"), false);
                        Serenity.EditorUtils.setReadonly(this.element.find('.IdentificacionRepresentante').find(".editor"), false);
                    }
                });

                this.form.Identificacion.change(e => {
                    if (this.form.TipoId.value != "4") {
                        this.form.IdentificacionRepresentante.value = this.form.Identificacion.value;
                    }
                });
                this.form.Nombre.change(e => {
                    if (this.form.TipoId.value != "4") {
                        this.form.NombreRepresentante.value = this.form.Nombre.value;
                    }
                });
                this.form.TipoId.change(e => {
                    if (this.form.TipoId.value != "4") {
                        this.form.TipoIdRepresentante.value = this.form.TipoId.value;
                    }
                });
            }
        }




    }
}