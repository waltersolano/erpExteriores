
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenDivisionesAdministrativasN1")]
    [BasedOnRow(typeof(Entities.GenDivisionesAdministrativasN1Row))]
    public class GenDivisionesAdministrativasN1Form
    {
        public String Nombre { get; set; }
        //public String Codigo { get; set; }
        
       // public Int32 DivisionSuperior { get; set; }
    }
}