namespace erpSoftExteriores.Common {


    @Serenity.Decorators.filterable()
    export class BaseGrid<TItem, TOptions> extends Serenity.EntityGrid<TItem, any>{
        protected getDialogType() { return Serenity.EntityDialog }; 
        protected isReadOnly: boolean;

        constructor(container: JQuery, isReadOnly: boolean) {
            super(container);
            this.isReadOnly = isReadOnly === true ? true : false;
            if (this.isReadOnly === true) {
                this.getElement().find(".add-button").remove();
            }
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number): void {
            // let base grid handle clicks for its edit links
            super.onClick(e, row, cell);

            // if base grid already handled, we shouldn"t handle it again
            if (e.isDefaultPrevented()) {
                return;
            }

            // get reference to current item
            var item = this.itemAt(row);

            // get reference to clicked element
            var target = $(e.target);
            
            if (target.hasClass("slick-formatter-view-button")) {
                //e.preventDefault();
                
                var ID = item[this.getIdProperty()];
                var readOnlyDialog = this.getDialogType();
                new readOnlyDialog(true).loadByIdAndOpenDialog(ID);                
            }
            else if (target.hasClass("slick-formatter-edit-button")) {
                //e.preventDefault();

                var ID = item[this.getIdProperty()];
                var editDialog = this.getDialogType();
                new editDialog(false).loadByIdAndOpenDialog(ID); 
            }
        }

        protected getButtons() {
            var buttons = super.getButtons();
            buttons.push(Common.ExcelExportHelper.createToolButton({
                grid: this,
                service: this.getService() + '/ListExcel',
                onViewSubmit: () => this.onViewSubmit(),
                separator: true
            }));
            buttons.push(Common.PdfExportHelper.createToolButton(
                this.getPdfExportOptions()
            )
            );
            return buttons;
        }


        protected getPdfExportOptions() {
            let options;
            options = {
                grid: this,
                onViewSubmit: () => this.onViewSubmit(),
                reportTitle: this.getDisplayName() + "_" + Q.formatDate(new Date(), "ddMMyyyy_HHmm"),
                columnTitles: {
                    /*'Id': 'Dggggggis.',*/
                },
                tableOptions: {
                    columnStyles: {
                      /*  Id: {
                            columnWidth: 250,
                            halign: 'right'
                        },
                        Website: {
                            columnWidth: 250
                        }*/
                    }
                }
            };
            return options;
        }

        protected getSlickOptions(): Slick.GridOptions {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selectedws";
            opt.enableCellNavigation = true;
            return opt;
        }

        protected createSlickGrid(): Slick.Grid {
            var grid = super.createSlickGrid();
            grid.registerPlugin(new Slick.Data.GroupItemMetadataProvider());
            grid.setSelectionModel(new Slick.RowSelectionModel());
            // need to register this plugin for grouping or you'll have errors

            return grid;
        }

        protected getColumns(): Slick.Column[] {

            var columns = super.getColumns();
            var optionsFields = [];

            if (Authorization.hasPermission("Inventario:Productos:Modificar")) { }

            optionsFields.push({
                    field: 'Edit',
                    name: 'Editar',
                    cssClass: 'grid-edit-button',
                    headerCssClass:'grid-edit-header',
                    width: 45,
                    sortable: false,
                    format: ctx => Q.outerHtml($("<span title= 'Editar' > </span>")
                        .addClass('slick-formatter-edit-button')
                        .text(''))
                });
            


            optionsFields.push({
                field: 'View',
                name: 'Ver',
                cssClass: 'grid-view-button',
                headerCssClass: 'grid-view-header',
                width: 45,
                sortable: false,
                format: ctx => Q.outerHtml($("<span title= 'Ver' > </span>")
                    .addClass('slick-formatter-view-button')
                    .text(''))
            });



            return optionsFields.concat(columns);
        }



    }
}