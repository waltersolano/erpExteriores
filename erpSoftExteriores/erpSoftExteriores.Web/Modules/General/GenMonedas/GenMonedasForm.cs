
namespace erpSoftExteriores.General.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("General.GenMonedas")]
    [BasedOnRow(typeof(Entities.GenMonedasRow))]
    public class GenMonedasForm
    {
        public String Nombre { get; set; }
        public String Simbolo { get; set; }
        public String Codigo { get; set; }
        public String Pais { get; set; }
        public String CodigoPais { get; set; }
    }
}