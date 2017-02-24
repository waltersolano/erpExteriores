/// <reference path="../GenDivisionesAdministrativasN4/GenDivisionesAdministrativasN4Dialog.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    export class Nivel4Dialog extends GenDivisionesAdministrativasN4Dialog {

        constructor() {
            super();
        }

        updateInterface() {
            super.updateInterface();

            Serenity.EditorUtils.setReadOnly(this.form.DivisionSuperiorN3, true);
        }
    }
}