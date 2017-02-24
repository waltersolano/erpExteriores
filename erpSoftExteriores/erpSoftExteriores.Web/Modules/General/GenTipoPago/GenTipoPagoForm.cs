
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenTipoPago")]
    [BasedOnRow(typeof(Entities.GenTipoPagoRow))]
    public class GenTipoPagoForm
    {
        [Category("General")]
        public String Nombre { get; set; }
        public Int32 CantidadDias { get; set; }
        public Double CantidadMeses { get; set; }
        public String Criterios { get; set; }
        //public Int32 TenantId { get; set; }
    }
}