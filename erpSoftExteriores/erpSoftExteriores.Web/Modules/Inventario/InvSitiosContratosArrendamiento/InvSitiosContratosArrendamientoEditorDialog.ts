
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace erpSoftExteriores.Inventario {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class InvSitiosContratosArrendamientoEditorDialog extends Common.GridEditorDialog<InvSitiosContratosArrendamientoRow> {
        protected getFormKey() { return InvSitiosContratosArrendamientoForm.formKey; }
                protected getLocalTextPrefix() { return InvSitiosContratosArrendamientoRow.localTextPrefix; }
        protected getNameProperty() { return InvSitiosContratosArrendamientoRow.nameProperty; }
        protected form = new InvSitiosContratosArrendamientoForm(this.idPrefix);
    }
}