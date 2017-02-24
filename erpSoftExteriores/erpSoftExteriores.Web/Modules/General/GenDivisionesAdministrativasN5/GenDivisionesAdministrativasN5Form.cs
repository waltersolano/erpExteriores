
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenDivisionesAdministrativasN5")]
    [BasedOnRow(typeof(Entities.GenDivisionesAdministrativasN5Row))]
    public class GenDivisionesAdministrativasN5Form
    {
        public Int32 DivisionSuperiorN4 { get; set; }
        public String Nombre { get; set; }
       // public String Codigo { get; set; }
        
    }
}