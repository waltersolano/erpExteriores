
namespace erpSoftExteriores.Common {

    @Serenity.Decorators.registerFormatter()
    export class ViewFormatter implements Slick.Formatter {  
        format(ctx: Slick.FormatterContext) {
            return "<span class='slick-formatter-view-button' title= 'Ver' > </span>";
        }

    }
}