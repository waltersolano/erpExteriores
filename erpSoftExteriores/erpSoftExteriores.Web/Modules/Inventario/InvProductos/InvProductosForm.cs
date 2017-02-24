
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvProductos")]
    [BasedOnRow(typeof(Entities.InvProductosRow))]
    public class InvProductosForm
    {

        [Category("General")]
        [ReadOnly(true)]        
        public String CodigoProducto { get; set; }
        public Int32 SitioId { get; set; }

        public List<object> NoteList { get; set; }
        // public String Nombre { get; set; }

        [Category("Estructura")]
        public Int32 CategoriasSoporteEstructuraId { get; set; }
        public Int32 TiposEstructuraId { get; set; }
        public Int32 CircuitoId { get; set; }
        public Int32 EstatusId { get; set; }

        [Category("Precios")]
        public Int32 MonedaId { get; set; }
        public Decimal PrecioVenta { get; set; }
        public Decimal PrecioVentaMinimo { get; set; }
        public Decimal PrecioVentaCircuito { get; set; }



        [Category("Iluminación")]
        public Boolean TieneIluminacion { get; set; }
        public Boolean PrecioIncluyeIluminacion { get; set; }
        public Decimal PrecioIluminacion { get; set; }
        public Int32 MonedaIluminacionId { get; set; }


        //public String CantidadPorUnidad { get; set; }
        //public Int16 UnidadesEnStock { get; set; }
        [Category("Dimensiones")]
        public String DescriptionVista { get; set; }
        public Decimal Base { get; set; }
        public Decimal Altura { get; set; }
        public Decimal Area { get; set; }

        [Category("Ubicación")]
        public String GpsLatitud { get; set; }
        public String GpsLongitud { get; set; }
       // public String Ubicacion { get; set; }
       // public Int32 GpsRutaId { get; set; }

        [Category("Imagenes")]
        public String Imagenes { get; set; }

        [Category("Información Legal")]       
        public Int32 LegalInfoId { get; set; }

       /* public Int32 TenantId { get; set; }
        public Int32 UserId { get; set; }
        public DateTime UltimaModificacion { get; set; }
        public Int32 UserIdModifica { get; set; }
        public DateTime FechaCreacion { get; set; }*/








    }
}