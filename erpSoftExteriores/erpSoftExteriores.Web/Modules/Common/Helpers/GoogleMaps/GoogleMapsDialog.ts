declare var Morris: any;

namespace erpSoftExteriores.Common {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.resizable()
    @Serenity.Decorators.maximizable()
    export class GoogleMapsDialog extends Serenity.TemplatedDialog<any> {

        private areaChart: any;
        public parentD: any;
        public coords: any;
        public codigoProducto: any;
        public dialogType: string;
        public map: any;
        //public trafficLayer = new google.maps.TrafficLayer(); 
        public trafficLayer : any; 

        static initializePage() {
            $(function () {
                $('#LaunchDialogButton').click(function (e) {
                    alert("ss");
                    (new GoogleMapsDialog()).dialogOpen();
                });
            });
        }

        protected onDialogOpen() {
            super.onDialogOpen();

            let art = jQuery("#addRemoveTrafic");
            let self = this;
            art.click(function (e) {
                if (art.is(':checked')) {
                    self.addTrafficLayerOverlay(self.map)
                } else {
                    self.removeTrafficLayerOverlay();
                }  
            });
            try {
                switch (this.dialogType) {
                    case "coordsPicker":
                        this.coordsPickerDialog();
                        break;
                    case "showLocation":
                        this.readOnlyDialog();
                        break;
                }
            }
            catch (e) { Q.warning("Error cargando librerías del API de google maps"); this.dialogClose();}
            this.element.closest(".ui-dialog").find(".ui-dialog-titlebar-maximize").remove();
        }

        protected coordsPickerDialog() {
            let lat = parseFloat(this.parentD.GpsLatitud.value);
            let lng = parseFloat(this.parentD.GpsLongitud.value);
            let codigoProducto = this.parentD.CodigoProducto.value;
            let zoom = 10;
            this.codigoProducto = "Nuevo";
            this.dialogTitle = "Producto[" + this.codigoProducto + "]";
            if (!isNaN(lat) && !isNaN(lng) && codigoProducto) {
                this.coords = { lat: lat, lng: lng };
                zoom = 16;
                this.codigoProducto = codigoProducto;
                this.dialogTitle = "Producto[" + this.codigoProducto + "]          Latitud:" + this.coords.lat + ",  Longitud:" + this.coords.lng;
            }
            else {
                this.coords = { lat: 9.9264, lng: -84.0694 };
            }

            let self = this;
            let mapContainer = this.element.find(".gmap");
            let options =
                {
                    scrollwheel: true,
                    center: this.coords,
                    zoom: zoom,
                    mapTypeId: google.maps.MapTypeId.ROADMAP,
                    mapTypeControl: true,
                    panControl: false,
                    rotateControl: false,
                    streetViewControl: false
                };

            let map = new google.maps.Map(mapContainer[0], options);
           
            let marker;

            if (!isNaN(lat) && !isNaN(lng)) {
                marker = new google.maps.Marker({
                    position: self.coords,
                    map: map,
                    optimized: true,
                    title: self.codigoProducto,
                });
            }


            google.maps.event.addListener(map, 'click', function (e) {
                self.coords = { lat: e.latLng.lat(), lng: e.latLng.lng() };
                if (marker) {
                    marker.setPosition(self.coords);
                } else {
                    marker = new google.maps.Marker({
                        position: self.coords,
                        map: map,
                        optimized: true,
                        title: self.codigoProducto

                    });
                }

                self.parentD.GpsLatitud.value = e.latLng.lat();
                self.parentD.GpsLongitud.value = e.latLng.lng();

                self.set_dialogTitle("Producto[" + self.codigoProducto + "]          Latitud:" + self.coords.lat + ",  Longitud:" + self.coords.lng);
            });
            map.setOptions({ draggableCursor: '' });
            this.map = map;
        }


        protected readOnlyDialog() {
            let mapContainer = this.element.find(".gmap");
            let options =
                {
                    scrollwheel: true,
                    center: this.coords,
                    zoom: 16,
                    mapTypeId: google.maps.MapTypeId.ROADMAP,
                    mapTypeControl: true,
                    panControl: false,
                    rotateControl: false,
                    streetViewControl: false,

                };

            let map = new google.maps.Map(mapContainer[0], options);

            let image = {
                url: 'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png',
                // url: 'https://maps.google.com/mapfiles/kml/shapes/post_office_jp.png',
                // This marker is 20 pixels wide by 32 pixels high.
                size: new google.maps.Size(20, 32),
                // The origin for this image is (0, 0).
                origin: new google.maps.Point(0, 0),
                // The anchor for this image is the base of the flagpole at (0, 32).
                anchor: new google.maps.Point(0, 32)
            };


            let beachMarker = new google.maps.Marker({
                position: this.coords,
                map: map,
                optimized: true,
                title: this.codigoProducto,
                icon: image
            });

            /*
            let trafficLayer = new google.maps.TrafficLayer();
            trafficLayer.setMap(map);
            
            let coordInfoWindow = new google.maps.InfoWindow();
            coordInfoWindow.setContent("un string comun y<br> corriente");
            coordInfoWindow.setPosition(this.coords);
            coordInfoWindow.open(map);
            */

            this.dialogTitle = "Producto[" + this.codigoProducto + "]          Latitud:" + this.coords.lat + ",  Longitud:" + this.coords.lng;
            this.map = map;

        }

        protected addTrafficLayerOverlay(map) {
            this.trafficLayer = new google.maps.TrafficLayer(); 
            this.trafficLayer.setMap(map);
        }

        protected removeTrafficLayerOverlay() {
            this.trafficLayer.setMap(null);
        }

/*
        protected getTemplate() {
            // you could also put this in a GoogleMapsDialog.Template.html file. it's here for simplicity.
            return "<div class='gmap' style='min-height: 400px; display: block'></div>";
        }*/
    }
}