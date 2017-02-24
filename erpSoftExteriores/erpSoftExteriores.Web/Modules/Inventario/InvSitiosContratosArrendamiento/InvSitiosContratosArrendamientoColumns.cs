
namespace erpSoftExteriores.Inventario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Inventario.InvSitiosContratosArrendamiento")]
    [BasedOnRow(typeof(Entities.InvSitiosContratosArrendamientoRow))]
    public class InvSitiosContratosArrendamientoColumns
    {
        [DisplayName("Db.Shared.RecordId"), Width(50)]
        public Int32 Id { get; set; }

        [DisplayName("Contrato")]
        [Width(110)]
        public String NumeroContrato { get; set; }

        [Width(70)]
        public String SitioCodigoSitio { get; set; }
        [Width(180)]
        public String ArrendadorNombre { get; set; }

        //public Int32 TipoContratoId { get; set; }
        [Width(135), AlignCenter]
        public String TipoFechaPagoNombre { get; set; }


        //public Int32 MonedaId { get; set; }
        [Width(70), AlignCenter]
        public String MonedaNombre { get; set; }

        public Decimal Monto { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public Decimal PorcentajeIncrementoRenovacion { get; set; }
        /*  public Int32 TenantId { get; set; }
          public Int32 UserRegistraId { get; set; }
          public Int32 UserApruedaId { get; set; }
          public Int32 UserId { get; set; }*/
        [Width(90), AlignCenter]
        public String UsuarioRegistraUsername { get; set; }

        [Width(90), AlignCenter]
        public String UsuarioApruebaUsername { get; set; }

        [DisplayName("Aprobado")]
        public Boolean EstaAprobado { get; set; }
    }
}