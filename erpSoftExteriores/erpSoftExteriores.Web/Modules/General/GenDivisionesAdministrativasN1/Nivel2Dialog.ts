/// <reference path="../GenDivisionesAdministrativasN2/GenDivisionesAdministrativasN2Dialog.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    export class Nivel2Dialog extends GenDivisionesAdministrativasN2Dialog {

        constructor() {
            super();
        }

        updateInterface() {
            super.updateInterface();
            Serenity.EditorUtils.setReadOnly(this.form.DivisionSuperiorN1, true);
        }
    }
}