
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Serenity.Data.Mapping;

    [ColumnsScript("Inventario.InvSitios")]
    [BasedOnRow(typeof(Entities.InvSitiosRow))]
    public class InvSitiosColumns
    {
        public Int32 Id { get; set; }

        public String CodigoSitio { get; set; }

        [QuickFilter]
        public String ArrendadorNombre { get; set; }

        public String ArrendadorIdentificacion { get; set; }

        [QuickFilter]
        public String RutaNombre { get; set; }

        public String Direccion { get; set; }


        [QuickFilter]
        public String DivisionAdministrativaN1Nombre { get; set; }

        [QuickFilter]
        public String DivisionAdministrativaN2Nombre { get; set; }

        [QuickFilter]
        public String DivisionAdministrativaN3Nombre { get; set; }


        public String Notas { get; set; }

    }
}