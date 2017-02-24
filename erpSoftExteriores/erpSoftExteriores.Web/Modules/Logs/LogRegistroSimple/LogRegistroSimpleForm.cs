
namespace erpSoftExteriores.Logs.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Logs.LogRegistroSimple")]
    [BasedOnRow(typeof(Entities.LogRegistroSimpleRow))]
    public class LogRegistroSimpleForm
    {
        public String EntityType { get; set; }
        public Int64 EntityId { get; set; }
        public Int32 UsuarioRegistraId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Int32 UsuarioModifica { get; set; }
        public DateTime FechaModifica { get; set; }
        public String Texto1 { get; set; }
        public String Texto2 { get; set; }
        public String Ip1 { get; set; }
        public String Ip2 { get; set; }
    }
}