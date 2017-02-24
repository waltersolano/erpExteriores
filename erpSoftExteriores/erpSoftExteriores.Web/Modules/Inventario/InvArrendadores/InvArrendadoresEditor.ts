namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerEditor()
    export class InvArrendadoresEditor extends Serenity.LookupEditorBase<InvArrendadoresRow, any> {

        constructor(hidden: JQuery) {
            super(hidden);
        }

        protected getLookupKey() {
            return 'Inventario.Arrendadores';
        }

        protected getItemText(item, lookup) {
            return super.getItemText(item, lookup) + ' [' + item.Identificacion + ']';
        }
    }
}