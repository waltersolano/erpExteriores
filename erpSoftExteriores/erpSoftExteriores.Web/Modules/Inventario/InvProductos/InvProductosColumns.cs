
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Common;
    using Entities;

    [ColumnsScript("Inventario.InvProductos")]
    [BasedOnRow(typeof(Entities.InvProductosRow))]
    public class InvProductosColumns
    {
        [DisplayName("Db.Shared.RecordId"), Width(50)]
        public Int32 Id { get; set; }

        [Width(100), AlignCenter, DisplayName("Código")]
        public String CodigoProducto { get; set; }

        [QuickFilter, Width(120), CssClass("estatus")]
        public String EstatusNombre { get; set; }

        [Width(100), AlignCenter]
        public String SitioCodigoSitio { get; set; }

        [QuickFilter, FilterOnly]
        public Int32 SitioArrendadorId { get; set; }

        [Width(200)]
        public String SitioArrendadorNombre{ get; set; }

        [Width(70), AlignCenter]
        public String MonedaNombre { get; set; }
        public Decimal PrecioVenta { get; set; }
        public Decimal PrecioVentaMinimo { get; set; }
        //public Decimal PrecioVentaCircuito { get; set; }

        public Boolean TieneIluminacion { get; set; }

        [QuickFilter]
        [Width(120)]
        public String CategoriasSoporteEstructuraNombre { get; set; }

        [Width(160)]
        public String TiposEstructuraNombre { get; set; }
        public Decimal Base { get; set; }
        public Decimal Altura { get; set; }
        public Decimal Area { get; set; }

        public String SitioRutaNombre { get; set; }
        public String GpsLatitud { get; set; }
        public String GpsLongitud { get; set; }
        //public String Ubicacion { get; set; }
        public Int32 GpsRutaId { get; set; }
        public String DescriptionVista { get; set; }

        /*public String Imagenes { get; set; }*/

        [QuickFilter]
        [Width(110)]
        public String SitioDivisionAdministrativaN1Nombre { get; set; }

        [QuickFilter]
        [Width(110)]
        public String SitioDivisionAdministrativaN2Nombre { get; set; }

        [QuickFilter]
        [Width(110)]
        public String SitioDivisionAdministrativaN3Nombre { get; set; }

        //public List<object> NoteList { get; set; }

        public Int32 CircuitoId { get; set; }

        public Int32 LegalInfoId { get; set; }
        public String LegalDocumentoUno{ get; set; }

    }
}