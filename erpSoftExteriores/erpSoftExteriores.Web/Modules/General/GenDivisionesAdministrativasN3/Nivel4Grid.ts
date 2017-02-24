/// <reference path="../GenDivisionesAdministrativasN4/GenDivisionesAdministrativasN4Grid.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    export class nivel4Grid extends GenDivisionesAdministrativasN4Grid {
        protected getDialogType() { return Nivel4Dialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns(): Slick.Column[] {
            let fld = GenDivisionesAdministrativasN4Row.Fields;
            return super.getColumns().filter(x => x.field !== fld.DivisionSuperiorN3);
        }

        protected initEntityDialog(itemType, dialog) {
            super.initEntityDialog(itemType, dialog);
            Serenity.SubDialogHelper.cascade(dialog, this.element.closest('.ui-dialog'));
        }

        protected addButtonClick() {
            this.editItem(<GenDivisionesAdministrativasN4Row>{
                DivisionSuperiorN3: this.divisionSuperiorN3
            });
        } 

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.divisionSuperiorN3;
        }

        private _divisionSuperiorN3: number;

        get divisionSuperiorN3() {
            return this._divisionSuperiorN3;
        }

        set divisionSuperiorN3(value: number) {
            if (this._divisionSuperiorN3 !== value) {
                this._divisionSuperiorN3 = value;
                this.setEquality('divisionSuperiorN3', value);
                this.refresh();
            }
        }
    }
}