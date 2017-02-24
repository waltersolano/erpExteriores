/// <reference path="../GenDivisionesAdministrativasN5/GenDivisionesAdministrativasN5Dialog.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    export class Nivel5Dialog extends GenDivisionesAdministrativasN5Dialog {

        constructor() {
            super();
        }

        updateInterface() {
            super.updateInterface();

            Serenity.EditorUtils.setReadOnly(this.form.DivisionSuperiorN4, true);
        }
    }
}