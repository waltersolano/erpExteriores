
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Inventario.InvTiposEstructura")]
    [BasedOnRow(typeof(Entities.InvTiposEstructuraRow))]
    public class InvTiposEstructuraColumns
    {
        [DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String CategoriasSoporteEstructuraNombre { get; set; }
        public String Nombre { get; set; }

    }
}