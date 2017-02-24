
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenDivisionesAdministrativasN3")]
    [BasedOnRow(typeof(Entities.GenDivisionesAdministrativasN3Row))]
    public class GenDivisionesAdministrativasN3Form
    {
        // public String Codigo { get; set; }
        public Int32 DivisionSuperiorN2 { get; set; }
        public String Nombre { get; set; }
        
    }
}