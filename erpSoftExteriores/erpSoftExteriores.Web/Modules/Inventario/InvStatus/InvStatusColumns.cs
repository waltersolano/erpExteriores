
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Inventario.InvStatus")]
    [BasedOnRow(typeof(Entities.InvStatusRow))]
    public class InvStatusColumns
    {
        [DisplayName("Db.Shared.RecordId"), SortOrder(1)]
        public Int64 Id { get; set; }
        public String Nombre { get; set; }
        //public Int32 TenantId { get; set; }
        public String Criterios { get; set; }
    }
}