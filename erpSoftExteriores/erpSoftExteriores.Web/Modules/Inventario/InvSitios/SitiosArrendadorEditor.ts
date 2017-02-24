namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerEditor()
    export class SitiosArrendadorEditor extends Serenity.LookupEditorBase<InvSitiosRow, any> {

        constructor(hidden: JQuery) {
            super(hidden);
        }

        protected getLookupKey() {
            return 'Inventario.Sitios';
        }

        protected getItemText(item, lookup) {
            return super.getItemText(item, lookup) + '  |  Arrendador: ' + item.ArrendadorNombre + '';
        }
    }
}