
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenDivisionesAdministrativasN2")]
    [BasedOnRow(typeof(Entities.GenDivisionesAdministrativasN2Row))]
    public class GenDivisionesAdministrativasN2Form
    {
        //public String Codigo { get; set; }
        public Int32 DivisionSuperiorN1 { get; set; }
        public String Nombre { get; set; }


        
    }
}