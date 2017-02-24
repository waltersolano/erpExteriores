namespace erpSoftExteriores.Common {

    export interface ExcelExportOptions {
        grid: Serenity.DataGrid<any, any>;
        service: string;
        onViewSubmit: () => boolean;
        title?: string;
        hint?: string;
        separator?: boolean;
    }

    export namespace ExcelExportHelper {

        export function createToolButton(options: ExcelExportOptions): Serenity.ToolButton {

            return {
                hint: Q.coalesce(options.title, 'Excel'),
                title: Q.coalesce(options.hint, ''),
                cssClass: 'export-xlsx-button',
                onClick: function () {
                    if (!options.onViewSubmit()) {
                        return;
                    }

                    let grid = options.grid;

                    var request = Q.deepClone(grid.getView().params) as Serenity.ListRequest;
                    console.log("gris",grid);

                    request.Take = 0;
                    request.Skip = 0;
                    var sortBy = grid.getView().sortBy;
                    if (sortBy) {
                        request.Sort = sortBy;
                    }

                    request.IncludeColumns = [];
                    let columns = grid.getGrid().getColumns();
                    
                   // columns.splice(Q.indexOf(columns, x => x.cssClass == "grid-view-button"), 1);
                   // columns.splice(Q.indexOf(columns, x => x.cssClass == "grid-edit-button"), 1);
                   // console.log(columns);

                    for (let column of columns) {
                        //console.log(column.field);
                        if (column.field !== "View" && column.field !== "Edit") {
                            request.IncludeColumns.push(column.id || column.field);
                        }                  
                    }
                    Q.postToService({ service: options.service, request: request, target: '_blank' });
                },
                separator: options.separator
            };
        }
    }
}