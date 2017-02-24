
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvArrendadores")]
    [BasedOnRow(typeof(Entities.InvArrendadoresRow))]
    public class InvArrendadoresForm
    {

        [Category("Información General")]
        public Int32 TipoId { get; set; }
        [DisplayName("Nombre o Razón Social")]
        public String Nombre { get; set; }
        public String Identificacion { get; set; }
       
        
        //public String Notas { get; set; }
        public String Direccion { get; set; }
        public String Emails { get; set; }
        public String Website { get; set; }
        public String CodigoPostal { get; set; }


        //public Int32 UserId { get; set; }
        //public Int32 TenantId { get; set; }
        //public DateTime FechaModificacion { get; set; }
        [Category("Firma en Contrato")]
        [ReadOnly(true)]
        public String NombreRepresentante { get; set; }
        [ReadOnly(true)]
        public Int32 TipoIdRepresentante { get; set; }
        [ReadOnly(true)]
        public String IdentificacionRepresentante { get; set; }

        //public DateTime FechaCreacion { get; set; }
        //public Int32 UserIdModifica { get; set; }


        /*[Category("Registro")]
        [CssClass("italic center"), DisplayName(Texts.Site.RegistroColumnas.CreadoPor), Width(120), ReadOnly(true)]
        public String UserUsername { get; set; }
        [DisplayName(Texts.Site.RegistroColumnas.CreadoEl), Width(140), Administration.DateTime2Editor, ReadOnly(true)]
        public DateTime FechaCreacion { get; set; }

        [CssClass("italic center"), DisplayName(Texts.Site.RegistroColumnas.ModificadoPor), Width(120), ReadOnly(true)]
        public String UserIdModificaUsername { get; set; }
        [DisplayName(Texts.Site.RegistroColumnas.ModificadoEl), Width(140), Administration.DateTime2Editor, ReadOnly(true)]
        public DateTime FechaModificacion { get; set; }*/


    }
}