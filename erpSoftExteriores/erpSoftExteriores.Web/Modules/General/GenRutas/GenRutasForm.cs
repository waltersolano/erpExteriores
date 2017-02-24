
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenRutas")]
    [BasedOnRow(typeof(Entities.GenRutasRow))]
    public class GenRutasForm
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Carreteras { get; set; }
    }
}