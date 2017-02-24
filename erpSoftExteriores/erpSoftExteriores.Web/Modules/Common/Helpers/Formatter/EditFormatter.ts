namespace erpSoftExteriores.Common {

    @Serenity.Decorators.registerFormatter()
    export class EditFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            return "<span class='slick-formatter-edit-button' title= 'Editar' > </span>";
        }
    }
}