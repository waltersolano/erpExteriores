
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenTipoIdentificacion")]
    [BasedOnRow(typeof(Entities.GenTipoIdentificacionRow))]
    public class GenTipoIdentificacionForm
    {
        public String Nombre { get; set; }
    }
}