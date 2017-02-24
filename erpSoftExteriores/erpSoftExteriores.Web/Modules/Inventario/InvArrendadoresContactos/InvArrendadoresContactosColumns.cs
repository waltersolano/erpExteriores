
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Inventario.InvArrendadoresContactos")]
    [BasedOnRow(typeof(Entities.InvArrendadoresContactosRow))]
    public class InvArrendadoresContactosColumns
    {
        /*[EditLink, Common.EditFormatter, DisplayName("Editar"), CssClass("grid-edit-button"), Width(45)]
        public String Edit { get; set; }

        [Common.ViewFormatter, DisplayName("Ver"), CssClass("grid-view-button"), Width(45)]
        public String View { get; set; }*/

        [DisplayName("Db.Shared.RecordId"), AlignRight, Width(50)]
        public Int32 Id { get; set; }

        [LookupEditor(typeof(Scripts.InvArrendadoresContactosLookup)), QuickFilter]
        public String ArrendadorNombre { get; set; }

        public String Nombre { get; set; }
        public String Telefono1 { get; set; }
        public String Telefono2 { get; set; }
        public String Email { get; set; }
        public String Cargo { get; set; }
        
        
/*
        [CssClass("italic center"), DisplayName(Texts.Site.RegistroColumnas.CreadoPor), Width(120)]
        public String UserUsername { get; set; }
        [DisplayName(Texts.Site.RegistroColumnas.CreadoEl), Width(140), DateTimeFormatter]
        public DateTime FechaCreacion { get; set; }

        [CssClass("italic center"), DisplayName(Texts.Site.RegistroColumnas.ModificadoPor), Width(120)]
        public String UserIdModificaUsername { get; set; }
        [DisplayName(Texts.Site.RegistroColumnas.ModificadoEl), Width(140), DateTimeFormatter]
        public DateTime FechaModificacion { get; set; }*/
    }
}