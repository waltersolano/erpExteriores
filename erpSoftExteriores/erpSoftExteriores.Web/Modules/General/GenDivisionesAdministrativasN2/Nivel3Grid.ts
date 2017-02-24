/// <reference path="../GenDivisionesAdministrativasN3/GenDivisionesAdministrativasN3Grid.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    export class nivel3Grid extends GenDivisionesAdministrativasN3Grid {
        protected getDialogType() { return Nivel3Dialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns(): Slick.Column[] {
            let fld = GenDivisionesAdministrativasN3Row.Fields;
            return super.getColumns().filter(x => x.field !== fld.DivisionSuperiorN2);
        }

        protected initEntityDialog(itemType, dialog) {
            super.initEntityDialog(itemType, dialog);
            Serenity.SubDialogHelper.cascade(dialog, this.element.closest('.ui-dialog'));
        }

        protected addButtonClick() {
            this.editItem(<GenDivisionesAdministrativasN3Row>{
                DivisionSuperiorN2: this.divisionSuperiorN2
            });
        } 

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.divisionSuperiorN2;
        }

        private _divisionSuperiorN2: number;

        get divisionSuperiorN2() {
            return this._divisionSuperiorN2;
        }

        set divisionSuperiorN2(value: number) {
            if (this._divisionSuperiorN2 !== value) {
                this._divisionSuperiorN2 = value;
                this.setEquality('divisionSuperiorN2', value);
                this.refresh();
            }
    

        }
    }
}