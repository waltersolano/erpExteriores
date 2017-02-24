/// <reference path="../InvArrendadoresContactos/InvArrendadoresContactosDialog.ts" />

namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    export class ArrendadoresContactosDialog extends InvArrendadoresContactosDialog {

        updateInterface() {      
            super.updateInterface();
            Serenity.EditorUtils.setReadOnly(this.form.ArrendadorId, true);
        }
        protected getEntityType() { return "Inventario.InvArrendadoresContactos" }
    }
}