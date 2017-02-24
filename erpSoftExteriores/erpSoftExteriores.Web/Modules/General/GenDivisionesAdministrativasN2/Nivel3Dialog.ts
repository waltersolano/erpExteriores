/// <reference path="../GenDivisionesAdministrativasN3/GenDivisionesAdministrativasN3Dialog.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    export class Nivel3Dialog extends GenDivisionesAdministrativasN3Dialog {

        constructor() {
            super();
        }

        updateInterface() {
            super.updateInterface();

            Serenity.EditorUtils.setReadOnly(this.form.DivisionSuperiorN2, true);
        }
    }
}