
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvCategoriasSoporteEstructura")]
    [BasedOnRow(typeof(Entities.InvCategoriasSoporteEstructuraRow))]
    public class InvCategoriasSoporteEstructuraForm
    {
        public String Nombre { get; set; }
    }
}