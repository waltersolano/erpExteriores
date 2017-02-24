/// <reference path="../InvArrendadoresContactos/InvArrendadoresContactosGrid.ts" />

namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    export class ArrendadoresContactosGrid extends InvArrendadoresContactosGrid {
        protected getDialogType() { return ArrendadoresContactosDialog; }






        protected getColumns(): Slick.Column[] {
            let fld = Inventario.InvArrendadoresContactosRow.Fields;
            return super.getColumns().filter(x => x.field !== fld.ArrendadorId);
        }

        protected initEntityDialog(itemType, dialog) {
            super.initEntityDialog(itemType, dialog);
            Serenity.SubDialogHelper.cascade(dialog, this.element.closest('.ui-dialog'));
        }

        protected addButtonClick() {
            this.editItem(<InvArrendadoresContactosRow>{
                ArrendadorId: this._ArrendadorId
            });
        }

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.ArrendadorId;
        }

        private _ArrendadorId: number;

        get ArrendadorId() {
            return this._ArrendadorId;
        }

        set ArrendadorId(value: number) {
            if (this._ArrendadorId !== value) {
                this._ArrendadorId = value;
                this.setEquality('ArrendadorId', value);
                this.refresh();
            }
  
        }
    }
}