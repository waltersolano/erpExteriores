
namespace erpSoftExteriores.General.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("General.GenMonedas")]
    [BasedOnRow(typeof(Entities.GenMonedasRow))]
    public class GenMonedasColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Nombre { get; set; }
        public String Simbolo { get; set; }
        public String Codigo { get; set; }
        public String Pais { get; set; }
        public String CodigoPais { get; set; }
    }
}