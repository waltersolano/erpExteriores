namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerFormatter()
    export class InvArrendadoresFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            var idList = ctx.value as string[];
            if (!idList || !idList.length)
                return "";

            var byId = InvArrendadoresRow.getLookup().itemById;
            let z: InvArrendadoresRow;
            return idList.map(x => ((z = byId[x]) ? z.Nombre : x)).join(", ");
        }
    }
}