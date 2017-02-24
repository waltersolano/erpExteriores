
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvProductosLegal")]
    [BasedOnRow(typeof(Entities.InvProductosLegalRow))]
    public class InvProductosLegalForm
    {
        [Category("Documentos")]
        public String DocumentoUno { get; set; }
        public String DocumentoDos { get; set; }
        public String DocumentoTres { get; set; }
        public String DocumentoCuatro { get; set; }
        public String DocumentoCinco { get; set; }

        [Category("Vencimiento")]
        public DateTime Vence { get; set; }

        [Category("Observaciones")]
        public String Observaciones { get; set; }

        [Category("Documentos Digitalizados")]
        public String DocumentosDigitalizados { get; set; }
    }
}