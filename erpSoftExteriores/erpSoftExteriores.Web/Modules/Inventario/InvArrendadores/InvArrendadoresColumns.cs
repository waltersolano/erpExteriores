
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Inventario.InvArrendadores")]
    [BasedOnRow(typeof(Entities.InvArrendadoresRow))]
    public class InvArrendadoresColumns
    {
        /*[EditLink, Common.EditFormatter, DisplayName("Editar"), CssClass("grid-edit-button"), Width(45)]
        public String Edit { get; set; }

        [Common.ViewFormatter, DisplayName("Ver"), CssClass("grid-view-button"), Width(45)]
        public String View { get; set; }*/

        [DisplayName("Db.Shared.RecordId"), AlignRight, Width(50)]
        public Int32 Id { get; set; }
        
        public String Nombre { get; set; }

        public String  TipoNombre { get; set; }
        public String Identificacion { get; set; }

        //public String Notas { get; set; }
        public String Direccion { get; set; }
        public String Emails { get; set; }
        public String Website { get; set; }
        public String CodigoPostal { get; set; }

        public String NombreRepresentante { get; set; }
        public String IdentificacionRepresentante { get; set; }
        //public Int32 TipoIdRepresentante { get; set; }

        //public Int32 UserId { get; set; }
        //public Int32 TenantId { get; set; }

/*

        [CssClass("italic center"), DisplayName(Texts.Site.RegistroColumnas.CreadoPor), Width(120)]
        public String UserUsername { get; set; }
        [DisplayName(Texts.Site.RegistroColumnas.CreadoEl), Width(140), DateTimeFormatter]
        public DateTime FechaCreacion { get; set; }

        [CssClass("italic center"), DisplayName(Texts.Site.RegistroColumnas.ModificadoPor), Width(120)]
        public String UserIdModificaUsername { get; set; }
        [DisplayName(Texts.Site.RegistroColumnas.ModificadoEl), Width(140), DateTimeFormatter]
        public DateTime FechaModificacion { get; set; }
*/

        //public Int32 UserIdModifica { get; set; }
    }
}