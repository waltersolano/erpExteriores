namespace erpSoftExteriores.Northwind {

    @Serenity.Decorators.registerClass()
    export class OrderDialog extends Serenity.EntityDialog<OrderRow, any> {
        protected getFormKey() { return OrderForm.formKey; }
        protected getIdProperty() { return OrderRow.idProperty; }
        protected getLocalTextPrefix() { return OrderRow.localTextPrefix; }
        protected getNameProperty() { return OrderRow.nameProperty; }
        protected getService() { return OrderService.baseUrl; }

        protected form = new OrderForm(this.idPrefix);

        constructor() {
            super();
        }

        getToolbarButtons() {
            var buttons = super.getToolbarButtons();

            buttons.push(erpSoftExteriores.Common.ReportHelper.createToolButton({
                title: 'Invoice',
                cssClass: 'export-pdf-button',
                reportKey: 'Northwind.OrderDetail',
                extension: "pdf",
                print: 1,
                target: "_blank",
                getParams: () => ({ OrderID: this.get_entityId() })
            }));

            return buttons;
        }
    }
}