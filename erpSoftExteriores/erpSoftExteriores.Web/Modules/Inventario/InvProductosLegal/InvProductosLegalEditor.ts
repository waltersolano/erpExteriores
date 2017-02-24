namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerEditor()
    export class InvProductosLegalEditor extends Serenity.LookupEditorBase<InvProductosLegalRow, any> {

        constructor(hidden: JQuery) {
            super(hidden);
           this.addInplaceCreate();
        }

        inplaceCreateClick(e) {
            let className = e.currentTarget.className;
           this.getDialogTypeKey
           if (className.indexOf("isReadOnly") !== -1) {
               let value = jQuery(e.currentTarget).prev(".s-InvProductosLegalEditor").val();
               let dialog = new erpSoftExteriores.Inventario.InvProductosLegalDialog(true);
               dialog.dialogOpen();
               dialog.loadById(value)
           }
           else {
               super.inplaceCreateClick(e);
           }
        }

        protected getItemText(item, lookup) {
            let d1 = item.DocumentoUno ? "Número Oficio:" + item.DocumentoUno : '';
            let d2 = item.DocumentoDos ? " |Número Permiso: " + item.DocumentoDos : '';
            let d3 = item.DocumentoTres ? " |Plano Catastral: " + item.DocumentoTres : '';
            let string = item.Id + "  [" + d1 + d2 + d3 + " ]";
            return string;
        }
    }
}