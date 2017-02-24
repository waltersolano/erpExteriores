
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvSitios")]
    [BasedOnRow(typeof(Entities.InvSitiosRow))]
    public class InvSitiosForm
    {
        [Category("General")]
        [ReadOnly(true)]
        public String CodigoSitio { get; set; }
        public Int32 ArrendadorId { get; set; }       
        
        [Category("Dirección")]
        public Int32 RutaId { get; set; }
        public Int32 DivisionAdministrativaN1 { get; set; }        
        public Int32 DivisionAdministrativaN2 { get; set; }
        public Int32 DivisionAdministrativaN3 { get; set; }
        public Int32 DivisionAdministrativaN4 { get; set; }
        public Int32 DivisionAdministrativaN5 { get; set; }
        public String Direccion { get; set; }

        [Category("Notas")]
        public String Notas { get; set; }
    }
}