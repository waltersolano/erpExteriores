
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvTiposEstructura")]
    [BasedOnRow(typeof(Entities.InvTiposEstructuraRow))]
    public class InvTiposEstructuraForm
    {
        public Int32 CategoriasSoporteEstructuraId { get; set; }
        public String Nombre { get; set; }

    }
}