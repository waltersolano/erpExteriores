namespace erpSoftExteriores.Logs {

    export class LogRegistroSimple extends Serenity.Widget<any>{

        public container: JQuery;

        constructor(div: JQuery, item:Object) {
            super(div);
            this.setContainer(div);
            this.getLogData(item);
            
        }

        public setContainer(container) {
            this.container = container;
        }

        public getLogData(item) {

            var request: Serenity.ListRequest = {};
            request.Criteria = Serenity.Criteria.and(request.Criteria,
                [['EntityType'], '=', item.getEntityType()],
                [['EntityID'], '=', item.entityId]);

            Logs.LogRegistroSimpleService.SList(
                request,
                response => {
                    this.responseToTemplate(response)
                }
            );
        }


        public responseToTemplate(response: Serenity.ListResponse<any>) {
                if (response.TotalCount > 0) {

                var UsuarioModifica = response.Entities[0].UsuarioModificaUsername;
                var FechaModifica = response.Entities[0].FechaModifica;
                var UsuarioRegistra = response.Entities[0].UsuarioRegistraUsername;
                var FechaRegistro = response.Entities[0].FechaRegistro;

                FechaModifica = Q.formatDate(Q.parseISODateTime(FechaModifica), 'dd/MM/yyyy HH:mm tt');
                FechaRegistro = Q.formatDate(Q.parseISODateTime(FechaRegistro), 'dd/MM/yyyy HH:mm tt');

                var html = "<div><span>Creado el: <i>" + FechaRegistro + "</i></span><span>   por: <i><b>" + UsuarioRegistra +"</b></i></span>";
                if (FechaModifica) {
                    html = html + "  ||  <span>Modificado el: <i>" + FechaModifica + "</i></span><span>   por: <i><b>" + UsuarioModifica + "</b></i></span></div>";
                }
                else {
                    html = html + " </div>";
                }

                this.container.append(html);
            }




        }


    }
}