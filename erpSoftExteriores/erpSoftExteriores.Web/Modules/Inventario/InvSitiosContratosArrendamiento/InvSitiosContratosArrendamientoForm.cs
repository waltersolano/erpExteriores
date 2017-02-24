
namespace erpSoftExteriores.Inventario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventario.InvSitiosContratosArrendamiento")]
    [BasedOnRow(typeof(Entities.InvSitiosContratosArrendamientoRow))]
    public class InvSitiosContratosArrendamientoForm
    {
        [Category("General")]
        [ReadOnly(true)]
        public String NumeroContrato { get; set; }
        public Int32 SitioId { get; set; }
        public List<Int64> ProductosAsociados { get; set; }
        //public Int32 ArrendadorId { get; set; }

        //[Category("Detalles")]
        //public Int32 TipoContratoId { get; set; }
        public List<object> NoteList { get; set; }

        [Category("Vigencia")]
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }

        [Category("Monto")]
        public Int32 TipoFechaDePagoContratoId { get; set; }
        public Int32 MonedaId { get; set; }
        public Decimal Monto { get; set; }
        public Decimal PorcentajeIncrementoRenovacion { get; set; }

        [Category("Documentos Digitalizados")]
        public String DocumentosDigitalizados { get; set; }

        [Category("Aprobación")]
        [ReadOnly(true)]
        public Int32 UserRegistraId { get; set; }
        [ReadOnly(true)]
        public Int32 UserApruedaId { get; set; }

        [ReadOnly(true)]
        public Boolean EstaAprobado { get; set; }
    }
}