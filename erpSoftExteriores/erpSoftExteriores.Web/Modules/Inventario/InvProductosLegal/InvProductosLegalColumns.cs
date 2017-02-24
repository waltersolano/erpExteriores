
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Inventario.InvProductosLegal")]
    [BasedOnRow(typeof(Entities.InvProductosLegalRow))]
    public class InvProductosLegalColumns
    {
        [DisplayName("Db.Shared.RecordId"), Width(50)]
        public Int32 Id { get; set; }
        public String DocumentoUno { get; set; }
        public String DocumentoDos { get; set; }
        public String DocumentoTres { get; set; }
        public String DocumentoCuatro { get; set; }

        public String DocumentoCinco { get; set; }
        public DateTime Vence { get; set; }

       
        public String Observaciones { get; set; }

        
       // public String DocumentosDigitalizados { get; set; }
    }
}