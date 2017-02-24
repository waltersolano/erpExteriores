
namespace erpSoftExteriores.General.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("General.GenDivisionesAdministrativasN1")]
    [BasedOnRow(typeof(Entities.GenDivisionesAdministrativasN1Row))]
    public class GenDivisionesAdministrativasN1Columns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
       // public String Codigo { get; set; }
        public String Nombre { get; set; }
       // public Int32 DivisionSuperior { get; set; }
    }
}