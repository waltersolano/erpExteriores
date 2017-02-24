
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Inventario.InvCategoriasSoporteEstructura")]
    [BasedOnRow(typeof(Entities.InvCategoriasSoporteEstructuraRow))]
    public class InvCategoriasSoporteEstructuraColumns
    {
        [DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String Nombre { get; set; }

    }
}