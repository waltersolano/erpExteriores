
namespace erpSoftExteriores.Common {
    export class BaseDialog<TItem, TOptions> extends Serenity.EntityDialog<TItem, any> {
        protected isReadOnly: boolean;

        constructor(isReadOnly: boolean) {
            super();
            this.isReadOnly = isReadOnly === true ? true : false;
            if (this.isReadOnly === true) {

            }           
        }

        dialogOpen() {
            super.dialogOpen();
        }

        /*
        protected onSaveSuccess(response: Serenity.SaveResponse): void {
            if (this.isNew) {
                Q.notifySuccess("Guardado con éxito");
            }
        }*/

        protected afterLoadEntity() {
            super.afterLoadEntity();
            //Logs Widget
            try {
                if (!this.isNew()) {
                    new Logs.LogRegistroSimple(this.byId("userLog"), this);
                }
            }
            catch (e) { /*console.log("UserLog", e) */}

            //Notes Tab
            try {
                if (this.isNew()) {
                    this.tabs.find(".notasTab").addClass("ui-state-disabled");
                }
                else {
                    this.tabs.find(".notasTab").removeClass("ui-state-disabled");
                }
            }
            catch (e) { }
        }

        getToolbarButtons() {
            var buttons = super.getToolbarButtons();
            let columns = "";
            for (let num of Q.getColumns(this.getLocalTextPrefix()))
            {
                if (num.filterOnly != true) {
                    columns = columns + num.name + ",";
                }
            }
            buttons.push(erpSoftExteriores.Common.ReportHelper.createToolButton({
                title: '',
                cssClass: 'print-preview-button',
                reportKey: 'Common.StandardReportDetail',
                extension: 'html',
                print: 1,
                getParams: () => ({ ID: this.entityId, includeColumns: columns, localTextPrefix: this.getLocalTextPrefix() })
            }));
            return buttons;
        }

        protected onDialogClose(): void {
            super.onDialogClose();
            jQuery(".s-DataGrid").find(".refresh-button").click();
        }

        protected updateInterface(): void {
            super.updateInterface();   

            if (this.isReadOnly === true) {


                this.element.parent().addClass("isReadOnlyDialog");
                Serenity.EditorUtils.setReadonly(this.element.find('.editor'), true);

                this.element.find('sup').hide();

                //notes editor
                this.element.find('.s-NotesEditor .s-Toolbar').remove();
                this.element.find('.s-NotesEditor .note-delete').remove();
                this.element.find('.s-NotesEditor a.note-date').remove();
                this.element.find('.s-NotesEditor span.note-date').removeClass('hidden');

                this.deleteButton.remove();
                this.applyChangesButton.remove();
                this.saveAndCloseButton.remove();
                this.cloneButton.remove();

                this.element.find(".s-MultipleImageUploadEditor").find(".tool-buttons").remove();
                this.element.find(".inplace-create").addClass("isReadOnly");
                this.element.find(".inplace-create").attr("title", "Ver");

            }
            else {
                this.toolbar.findButton('.print-preview-button').hide();
            }
        }

        protected getEntityTitle(): string {
            var title = super.getEntityTitle();
            if (this.isReadOnly === true) {
                if (!this.isEditMode()) {
                    return "Error->?";
                }
                else {
                    var entityType = super.getEntitySingular();
                    let name = this.getEntityNameFieldValue() || "";
                    return 'Ver ' + entityType + " (" + name + ")";
                }
            }
            return title;
        }

        protected updateTitle(): void {
            super.updateTitle();
            // this.dialogTitle = 'View Supplier (' + this.getEntityNameFieldValue() + ')';
        }

  
    }
}