
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenDivisionesAdministrativasN4")]
    [BasedOnRow(typeof(Entities.GenDivisionesAdministrativasN4Row))]
    public class GenDivisionesAdministrativasN4Form
    {
        // public String Codigo { get; set; }
        public Int32 DivisionSuperiorN3 { get; set; }
        public String Nombre { get; set; }
        
    }
}