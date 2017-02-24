
namespace erpSoftExteriores.General.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("General.GenDivisionesAdministrativasN4")]
    [BasedOnRow(typeof(Entities.GenDivisionesAdministrativasN4Row))]
    public class GenDivisionesAdministrativasN4Columns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
       // public String Codigo { get; set; }
        public String Nombre { get; set; }
        public Int32 DivisionSuperiorN3 { get; set; }
    }
}