
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvArrendadoresContactos")]
    [BasedOnRow(typeof(Entities.InvArrendadoresContactosRow))]
    public class InvArrendadoresContactosForm
    {

        [Category("Información de Contacto")]
        public Int32 ArrendadorId { get; set; }
        public String Nombre { get; set; }

        [Common.IntPhoneEditor]
        public String Telefono1 { get; set; }
        public String Telefono2 { get; set; }
        public String Telefono3 { get; set; }
        public String Email { get; set; }
        public String Cargo { get; set; }

        /*
        [Category("Registro")]
        [CssClass("italic center"), DisplayName(Texts.Site.RegistroColumnas.CreadoPor), Width(120), ReadOnly(true)]
        public String UserUsername { get; set; }
        [DisplayName(Texts.Site.RegistroColumnas.CreadoEl), Width(140), Administration.DateTime2Editor, ReadOnly(true)]
        public DateTime FechaCreacion { get; set; }

        [CssClass("italic center"), DisplayName(Texts.Site.RegistroColumnas.ModificadoPor), Width(120), ReadOnly(true)]
        public String UserIdModificaUsername { get; set; }
        [DisplayName(Texts.Site.RegistroColumnas.ModificadoEl), Width(140), Administration.DateTime2Editor, ReadOnly(true)]
        public DateTime FechaModificacion { get; set; }
        */

    }
}