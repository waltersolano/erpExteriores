
namespace erpSoftExteriores.General.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("General.GenDivisionesAdministrativasN5")]
    [BasedOnRow(typeof(Entities.GenDivisionesAdministrativasN5Row))]
    public class GenDivisionesAdministrativasN5Columns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        //public String Codigo { get; set; }
        public String Nombre { get; set; }
        public Int32 DivisionSuperiorN4 { get; set; }
    }
}