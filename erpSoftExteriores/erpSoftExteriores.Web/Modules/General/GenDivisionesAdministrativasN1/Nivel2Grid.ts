/// <reference path="../GenDivisionesAdministrativasN2/GenDivisionesAdministrativasN2Grid.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    export class nivel2Grid extends GenDivisionesAdministrativasN2Grid {
        protected getDialogType() { return Nivel2Dialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns(): Slick.Column[] {
            let fld = GenDivisionesAdministrativasN2Row.Fields;
            return super.getColumns().filter(x => x.field !== fld.DivisionSuperiorN1);
        }

        protected initEntityDialog(itemType, dialog) {
            super.initEntityDialog(itemType, dialog);
            Serenity.SubDialogHelper.cascade(dialog, this.element.closest('.ui-dialog'));
        }

    /*    protected addButtonClick() {
            this.editItem({ divisionSuperiorN1: this.divisionSuperiorN1 });
        }*/

        protected addButtonClick() {
            this.editItem(<GenDivisionesAdministrativasN2Row>{
                DivisionSuperiorN1: this.divisionSuperiorN1
            });
        }

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.divisionSuperiorN1;
        }

        private _divisionSuperiorN1: number;

        get divisionSuperiorN1() {
            return this._divisionSuperiorN1;
        }

        set divisionSuperiorN1(value: number) {
            if (this._divisionSuperiorN1 !== value) {
                this._divisionSuperiorN1 = value;
                this.setEquality('divisionSuperiorN1', value);
                this.refresh();
            }
  
        }
    }
}