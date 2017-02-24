/// <reference path="../../common/helpers/basedialog.ts" />
namespace erpSoftExteriores.Inventario {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class InvProductosDialog extends Common.BaseDialog<InvProductosRow, any> {
        protected getFormKey() { return InvProductosForm.formKey; }
        protected getIdProperty() { return InvProductosRow.idProperty; }
        protected getLocalTextPrefix() { return InvProductosRow.localTextPrefix; }
        protected getNameProperty() { return InvProductosRow.nameProperty; }
        protected getService() { return InvProductosService.baseUrl; }
        protected form = new InvProductosForm(this.idPrefix);
        private loadedState: string;

        constructor(isReadOnly) {
            super(isReadOnly);
            this.byId('NoteList').closest('.field').hide().end().appendTo(this.byId('TabNotes'));
            //this.byId('LegalInfoId').closest('.field').appendTo(this.byId('TabLegal').find(".s-Form"));

            DialogUtils.pendingChangesConfirmation(this.element, () => this.getSaveState() != this.loadedState);
            this.tabs.bind('tabsactivate', () => this.arrange());
            
        }

        getSaveState() {
            try {
                return $.toJSON(this.getSaveEntity());
            }
            catch (e) {
                return null;
            }
        }

        loadResponse(data) {
            super.loadResponse(data);
            this.loadedState = this.getSaveState();
        }

        protected validateBeforeSave() {
            let fValidation = super.validateBeforeSave();
            let sValidation = true;
            if (this.form.TieneIluminacion.value){
                if (this.form.PrecioIncluyeIluminacion.value || this.form.PrecioIluminacion.value > 0 && this.form.MonedaIluminacionId.value != "") {
                    sValidation = true;
                }
                else {
                    sValidation = false;
                    Q.warning("El producto tiene iluminación, por favor indíque si los precios de venta incluyen este rubro, o bien digíte el precio y la moneda respectivos");
                }
            }      

            if (fValidation && sValidation) { return true;}
            else { return false; }
        }
        
        protected afterLoadEntity() {
            super.afterLoadEntity();
            try { jQuery("#LaunchMapDialogButton").remove() } catch (e) { }
            let self = this;
            if (this.isNew() || !this.isReadOnly) {                
                this.googleMapsPickLocationBtn();
                this.form.Altura.change(function () { self.updateArea() });
                this.form.Base.change(function () { self.updateArea() });
            }
            else {
                this.googleMapsShowLocationBtn();
            }

            if (this.isReadOnly) {
                if (!this.form.LegalInfoId.value) {
                    this.form.LegalInfoId.element.next(".inplace-create").remove();
                }
/*                else {
                    this.form.LegalInfoId.element.next(".inplace-create").attr("")
                }   */         
            }

            this.updateIluminacionFields();
            this.iluminacionEvents();
        }

        protected updateInterface() {
            super.updateInterface();
            this.cloneButton.toggle(this.isEditMode());
        }

        protected getCloningEntity() {
            var clone = super.getCloningEntity();
            var suffix = ' (Clone)';
            clone.CodigoProducto = null;
            clone.Notas = null;
            return clone;
        }

        protected iluminacionEvents() {
            let tieneIluminacion = this.form.TieneIluminacion;
            let precioIncluyeIluminacion = this.form.PrecioIncluyeIluminacion;
            let precioIluminacion = this.form.PrecioIluminacion;
            let monedaIluminacionId = this.form.MonedaIluminacionId;
            
            

            tieneIluminacion.change(function (e) {
                if (tieneIluminacion.value) {
                    precioIncluyeIluminacion.getGridField().show();
                    precioIluminacion.getGridField().show();
                    monedaIluminacionId.getGridField().show();
                }
                else {
                    precioIncluyeIluminacion.getGridField().hide();
                    precioIluminacion.getGridField().hide();
                    monedaIluminacionId.getGridField().hide();
                }
            });

            precioIncluyeIluminacion.change(function (e) {
                if (precioIncluyeIluminacion.value) {
                    //tieneIluminacion.element.attr({ disabled: true });
                    precioIluminacion.getGridField().hide();
                    monedaIluminacionId.getGridField().hide();
                    precioIluminacion.value = null;
                    monedaIluminacionId.value = "";
                }
                else {
                   // tieneIluminacion.element.attr({ disabled: false });
                    precioIluminacion.getGridField().show();
                    monedaIluminacionId.getGridField().show();
                }
            });

            
            precioIluminacion.change(function (e) {
                if (precioIluminacion.value) {
                    precioIncluyeIluminacion.getGridField().hide();
                    precioIncluyeIluminacion.value = false;
                }
                else {
                    precioIncluyeIluminacion.getGridField().show();
                }
            });

        }


        protected updateIluminacionFields() {
            if (this.isNew()) {
                this.form.PrecioIncluyeIluminacion.getGridField().hide();
                this.form.PrecioIluminacion.getGridField().hide();
                this.form.MonedaIluminacionId.getGridField().hide();
            }
            else {
                if (this.form.TieneIluminacion.value) {                  
                    if (this.form.PrecioIncluyeIluminacion.value) {
                        this.form.PrecioIncluyeIluminacion.getGridField().show();
                        this.form.PrecioIluminacion.getGridField().hide();
                        this.form.MonedaIluminacionId.getGridField().hide();
                    }
                    else {
                        this.form.PrecioIncluyeIluminacion.getGridField().hide();
                        this.form.PrecioIluminacion.getGridField().show();
                        this.form.MonedaIluminacionId.getGridField().show();
                    }
                }
                else {
                    this.form.PrecioIluminacion.getGridField().hide();
                    this.form.MonedaIluminacionId.getGridField().hide();
                    this.form.PrecioIncluyeIluminacion.getGridField().hide();
                }
            }
        }

        protected updateArea() {
            if (!isNaN((this.form.Base.value)) && !isNaN((this.form.Altura.value))) {
                this.form.Area.value = (this.form.Base.value) * (this.form.Altura.value);
            }
        }

        protected googleMapsShowLocationBtn() {

            let lat = parseFloat(this.entity.GpsLatitud);
            let lng = parseFloat(this.entity.GpsLongitud);

            if (!isNaN(lat) && !isNaN(lng)) {
                let coords = { lat: lat, lng: lng }
                let codigoProducto = this.entity.CodigoProducto
                let button = jQuery('<button/>', {
                    id: 'LaunchMapDialogButton',
                    title: 'Ver en Mapa',
                    class: 'btn btn-block btn-primary',
                    text: 'Ver en Mapa'
                }).click(function (e) {
                    e.preventDefault();
                    let mapDialog = new erpSoftExteriores.Common.GoogleMapsDialog();
                    mapDialog.dialogType = "showLocation";
                    mapDialog.coords = coords;
                    mapDialog.codigoProducto = codigoProducto;
                    mapDialog.dialogOpen();
                });
                jQuery(".GpsLatitud").before(button);
            }

        }

        protected googleMapsPickLocationBtn() {
            let form = this.form;

            let button = jQuery('<button/>', {
                id: 'LaunchMapDialogButton',
                title: 'Ver en Mapa',
                class: 'btn btn-block btn-primary',
                text: 'Ver en Mapa'
            }).click(function (e, x = this) {
                e.preventDefault();
                let mapDialog = new erpSoftExteriores.Common.GoogleMapsDialog();
                mapDialog.parentD = form;
                mapDialog.dialogType = "coordsPicker";
                mapDialog.dialogOpen();
            });
            jQuery(".GpsLatitud").before(button);
        }

    }
}