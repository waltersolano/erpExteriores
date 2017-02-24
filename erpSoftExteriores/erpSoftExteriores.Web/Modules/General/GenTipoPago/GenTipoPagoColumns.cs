
namespace erpSoftExteriores.General.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("General.GenTipoPago")]
    [BasedOnRow(typeof(Entities.GenTipoPagoRow))]
    public class GenTipoPagoColumns
    {
        [DisplayName("Db.Shared.RecordId"), Width(50)]
        public Int32 Id { get; set; }
        public String Nombre { get; set; }
        public Int32 CantidadDias { get; set; }
        public Double CantidadMeses { get; set; }
        //public String Criterios { get; set; }
        //public Int32 TenantId { get; set; }
    }
}