
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvStatus")]
    [BasedOnRow(typeof(Entities.InvStatusRow))]
    public class InvStatusForm
    {
        public String Nombre { get; set; }
        public String Criterios { get; set; }
    }
}