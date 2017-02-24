/// <reference path="../GenDivisionesAdministrativasN5/GenDivisionesAdministrativasN5Grid.ts" />

namespace erpSoftExteriores.General {

    @Serenity.Decorators.registerClass()
    export class nivel5Grid extends GenDivisionesAdministrativasN5Grid {
        protected getDialogType() { return Nivel5Dialog; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns(): Slick.Column[] {
            let fld = GenDivisionesAdministrativasN5Row.Fields;
            //console.log("super.getColumns().filter(x => x.field !== fld.DivisionSuperiorN1)",super.getColumns().filter(x => x.field !== fld.DivisionSuperiorN1));
            return super.getColumns().filter(x => x.field !== fld.DivisionSuperiorN4);
        }

        protected initEntityDialog(itemType, dialog) {
            super.initEntityDialog(itemType, dialog);
            Serenity.SubDialogHelper.cascade(dialog, this.element.closest('.ui-dialog'));
        }

        protected addButtonClick() {
            this.editItem(<GenDivisionesAdministrativasN5Row>{
                DivisionSuperiorN4: this.divisionSuperiorN4
            });
        } 

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.divisionSuperiorN4;
        }

        private _divisionSuperiorN4: number;

        get divisionSuperiorN4() {
            return this._divisionSuperiorN4;
        }

        set divisionSuperiorN4(value: number) {
            //console.log("1this._divisionSuperiorN1", this._divisionSuperiorN1);
            //console.log("value", value);
            if (this._divisionSuperiorN4 !== value) {
                this._divisionSuperiorN4 = value;
                this.setEquality('divisionSuperiorN4', value);
                this.refresh();
            }
    

           // console.log("2this._divisionSuperiorN2", this._divisionSuperiorN2);
        }
    }
}