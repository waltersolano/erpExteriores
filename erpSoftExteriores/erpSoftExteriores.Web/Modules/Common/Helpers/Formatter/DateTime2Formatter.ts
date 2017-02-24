namespace erpSoftExteriores.Administration {

    @Serenity.Decorators.registerFormatter()
    export class DateTime2Formatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            alert("DateTime2Formatter w");
            return "<span class='freight-symbol'>" + Q.htmlEncode(ctx.value) + '</span>'
        }
    }
}