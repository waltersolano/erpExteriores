namespace erpSoftExteriores.Common {

    @Serenity.Decorators.registerFormatter()
    export class NameFieldFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            let lookupkey = ctx.column.sourceItem.filteringParams.lookupKey;
            let lookup = Q.getLookup(lookupkey).items.filter(x => x['Id'] == ctx.value);
            let textField = Q.getLookup(lookupkey).textField;
           // console.log("lookupkey", lookupkey, "------>", lookup);
           //console.log("ctx", ctx);
            return ctx.value + " "  +  lookup[0][textField];
        }

    }
}