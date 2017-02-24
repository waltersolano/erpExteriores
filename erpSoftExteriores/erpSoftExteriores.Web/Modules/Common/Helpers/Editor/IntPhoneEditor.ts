/// <reference path="../../../../Scripts/typings/intl-tel-input/intl-tel-input.ts" />

namespace erpSoftExteriores.Common {

    @Serenity.Decorators.registerEditor()
    export class IntPhoneEditor extends Serenity.StringEditor {
        constructor(input: JQuery) {
            super(input);
        }

        set_value(value: string) {            
            this.element.val(value);
            this.element.intlTelInput({
                initialCountry: "cr",
                nationalMode:  false,
                utilsScript: "../../../Scripts/intl-tel-input/js/utils.js" 

            });
        }
    }
}