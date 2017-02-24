

namespace erpSoftExteriores.Inventario.Entities
{
    using General;
    using General.Entities;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Contratos de Arrendamiento"), InstanceName("Contrato de Arrendamiento"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Delete)]
    [LookupScript("Inventario.ContratosArrendamiento")]
    public sealed class InvSitiosContratosArrendamientoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int64? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Sitio"), Column("SitioID"), NotNull, ForeignKey("[dbo].[Inv_Sitios]", "ID"), LeftJoin("jSitio"), TextualField("SitioDireccion")]
        [SitiosArrendadorEditor]
        public Int32? SitioId
        {
            get { return Fields.SitioId[this]; }
            set { Fields.SitioId[this] = value; }
        }

        [DisplayName("Arrendador"), Column("ArrendadorID"), NotNull, ForeignKey("[dbo].[Inv_Arrendadores]", "ID"), LeftJoin("jArrendador"), TextualField("ArrendadorIdentificacion")]
        [LookupEditor(typeof(InvArrendadoresRow))]
        public Int32? ArrendadorId
        {
            get { return Fields.ArrendadorId[this]; }
            set { Fields.ArrendadorId[this] = value; }
        }

        [LookupEditor(typeof(InvProductosRow), Multiple = true, CascadeFrom = "SitioId", CascadeField = "SitioId"), NotMapped]
        [LinkingSetRelation(typeof(InvSitiosContratosArrendamientoProductosRow), "sitiosContratoID", "productoID")]
        [MinSelectLevel(SelectLevel.Details)]
        [DisplayName("Productos Asociados")]
        public System.Collections.Generic.List<Int64> ProductosAsociados
        {
            get { return Fields.ProductosAsociados[this]; }
            set { Fields.ProductosAsociados[this] = value; }
        }

        [DisplayName("Número de Contrato"), Column("numeroContrato"), Size(100), NotNull, QuickSearch]
        public String NumeroContrato
        {
            get { return Fields.NumeroContrato[this]; }
            set { Fields.NumeroContrato[this] = value; }
        }

        [DisplayName("Tipo Contrato"), Column("tipoContratoID"), NotNull]
        public Int32? TipoContratoId
        {
            get { return Fields.TipoContratoId[this]; }
            set { Fields.TipoContratoId[this] = value; }
        }

        [DisplayName("Frequencia de Pago"), Column("tipoFechaDePagoContratoID"), NotNull,ForeignKey("[dbo].[Gen_TipoPago]", "ID"), LeftJoin("jTipoFechaPago"), TextualField("TipoFechaPagoNombre")]
        [LookupEditor(typeof(General.Entities.GenTipoPagoRow))]
        public Int32? TipoFechaDePagoContratoId
        {
            get { return Fields.TipoFechaDePagoContratoId[this]; }
            set { Fields.TipoFechaDePagoContratoId[this] = value; }
        }

        [DisplayName("Frequencia de Pago"), Expression("jTipoFechaPago.[Nombre]")]
        public String TipoFechaPagoNombre
        {
            get { return Fields.TipoFechaPagoNombre[this]; }
            set { Fields.TipoFechaPagoNombre[this] = value; }
        }

        [DisplayName("Moneda"), Column("monedaID"), NotNull, ForeignKey("[dbo].[Gen_Monedas]", "ID"), LeftJoin("jMoneda"), TextualField("MonedaNombre")]
        [LookupEditor(typeof(General.Entities.GenMonedasRow))]
        public Int32? MonedaId
        {
            get { return Fields.MonedaId[this]; }
            set { Fields.MonedaId[this] = value; }
        }

        [DisplayName("Moneda"), Expression("jMoneda.[nombre]")]
        public String MonedaNombre
        {
            get { return Fields.MonedaNombre[this]; }
            set { Fields.MonedaNombre[this] = value; }
        }

        [DisplayName("Moneda Simbolo"), Expression("jMoneda.[simbolo]")]
        public String MonedaSimbolo
        {
            get { return Fields.MonedaSimbolo[this]; }
            set { Fields.MonedaSimbolo[this] = value; }
        }

        [DisplayName("Moneda Codigo"), Expression("jMoneda.[codigo]")]
        public String MonedaCodigo
        {
            get { return Fields.MonedaCodigo[this]; }
            set { Fields.MonedaCodigo[this] = value; }
        }

        [DisplayName("Monto"), Column("monto"), Size(19), Scale(2), NotNull, AlignRight, DisplayFormat("#,##0.00")]
        public Decimal? Monto
        {
            get { return Fields.Monto[this]; }
            set { Fields.Monto[this] = value; }
        }

        [DisplayName("Documentos Digitalizados"), Column("documentosDigitalizados")]
        [MultipleFileUploadEditor(FilenameFormat = "ContratosSitios/~", CopyToHistory = true)]
        public String DocumentosDigitalizados
        {
            get { return Fields.DocumentosDigitalizados[this]; }
            set { Fields.DocumentosDigitalizados[this] = value; }
        }

        [DisplayName("Valido desde"), Column("fechaInicial"), NotNull]
        public DateTime? FechaInicial
        {
            get { return Fields.FechaInicial[this]; }
            set { Fields.FechaInicial[this] = value; }
        }

        [DisplayName("Valido hasta"), Column("fechaFinal"), NotNull]
        public DateTime? FechaFinal
        {
            get { return Fields.FechaFinal[this]; }
            set { Fields.FechaFinal[this] = value; }
        }

        [DisplayName("Porcentaje de incremento por Renovación"), Column("porcentajeIncrementoRenovacion"), Size(5), Scale(2), NotNull]
        public Decimal? PorcentajeIncrementoRenovacion
        {
            get { return Fields.PorcentajeIncrementoRenovacion[this]; }
            set { Fields.PorcentajeIncrementoRenovacion[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Registrado por"), Column("userRegistraID"), NotNull,ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUserRegistra"), TextualField("UsuarioRegistraUsername")]
        [LookupEditor(typeof(Administration.Entities.UserRow))]
        public Int32? UserRegistraId
        {
            get { return Fields.UserRegistraId[this]; }
            set { Fields.UserRegistraId[this] = value; }
        }

        [DisplayName("Registrado por"), Expression("jUserRegistra.[Username]")]
        [LookupEditor(typeof(Administration.Entities.UserRow))]
        public String UsuarioRegistraUsername
        {
            get { return Fields.UsuarioRegistraUsername[this]; }
            set { Fields.UsuarioRegistraUsername[this] = value; }
        }


        [DisplayName("Aprobado por"), Column("userApruedaID"),ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUserAprueba"), TextualField("UsuarioApruebaUsername")]
        public Int32? UserApruedaId
        {
            get { return Fields.UserApruedaId[this]; }
            set { Fields.UserApruedaId[this] = value; }
        }

        [DisplayName("Aprobado por"), Expression("jUserAprueba.[Username]")]
        public String UsuarioApruebaUsername
        {
            get { return Fields.UsuarioApruebaUsername[this]; }
            set { Fields.UsuarioApruebaUsername[this] = value; }
        }

        [DisplayName("User Id"), Column("userID")]
        public Int32? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        [DisplayName("Está Aprobado"), Column("estaAprobado"), NotNull]
        public Boolean? EstaAprobado
        {
            get { return Fields.EstaAprobado[this]; }
            set { Fields.EstaAprobado[this] = value; }
        }

        [DisplayName("Estatus"), Column("Estatus"), NotNull]
        public Boolean? Estatus
        {
            get { return Fields.Estatus[this]; }
            set { Fields.Estatus[this] = value; }
        }

        [DisplayName("Adendum Id"), Column("adendumID")]
        public Int64? AdendumId
        {
            get { return Fields.AdendumId[this]; }
            set { Fields.AdendumId[this] = value; }
        }

        [DisplayName("Arrendador"), Expression("jSitio.[arrendadorID]")]
        public Int32? SitioArrendadorId
        {
            get { return Fields.SitioArrendadorId[this]; }
            set { Fields.SitioArrendadorId[this] = value; }
        }

        [DisplayName("Dirección"), Expression("jSitio.[direccion]")]
        public String SitioDireccion
        {
            get { return Fields.SitioDireccion[this]; }
            set { Fields.SitioDireccion[this] = value; }
        }


        [DisplayName("Sitio Division Administrativa N1"), Expression("jSitio.[divisionAdministrativaN1]")]
        public Int32? SitioDivisionAdministrativaN1
        {
            get { return Fields.SitioDivisionAdministrativaN1[this]; }
            set { Fields.SitioDivisionAdministrativaN1[this] = value; }
        }

        [DisplayName("Sitio Division Administrativa N2"), Expression("jSitio.[divisionAdministrativaN2]")]
        public Int32? SitioDivisionAdministrativaN2
        {
            get { return Fields.SitioDivisionAdministrativaN2[this]; }
            set { Fields.SitioDivisionAdministrativaN2[this] = value; }
        }

        [DisplayName("Sitio Division Administrativa N3"), Expression("jSitio.[divisionAdministrativaN3]")]
        public Int32? SitioDivisionAdministrativaN3
        {
            get { return Fields.SitioDivisionAdministrativaN3[this]; }
            set { Fields.SitioDivisionAdministrativaN3[this] = value; }
        }

        [DisplayName("Sitio Division Administrativa N4"), Expression("jSitio.[divisionAdministrativaN4]")]
        public Int32? SitioDivisionAdministrativaN4
        {
            get { return Fields.SitioDivisionAdministrativaN4[this]; }
            set { Fields.SitioDivisionAdministrativaN4[this] = value; }
        }

        [DisplayName("Sitio Division Administrativa N5"), Expression("jSitio.[divisionAdministrativaN5]")]
        public Int32? SitioDivisionAdministrativaN5
        {
            get { return Fields.SitioDivisionAdministrativaN5[this]; }
            set { Fields.SitioDivisionAdministrativaN5[this] = value; }
        }

        [DisplayName("Sitio Ruta Id"), Expression("jSitio.[rutaID]")]
        public Int32? SitioRutaId
        {
            get { return Fields.SitioRutaId[this]; }
            set { Fields.SitioRutaId[this] = value; }
        }

        [DisplayName("Sitio"), Expression("jSitio.[codigoSitio]")]
        public String SitioCodigoSitio
        {
            get { return Fields.SitioCodigoSitio[this]; }
            set { Fields.SitioCodigoSitio[this] = value; }
        }

        [DisplayName("Arrendador Identificacion"), Expression("jArrendador.[identificacion]")]
        public String ArrendadorIdentificacion
        {
            get { return Fields.ArrendadorIdentificacion[this]; }
            set { Fields.ArrendadorIdentificacion[this] = value; }
        }

        [DisplayName("Arrendador"), Expression("jArrendador.[nombre]")]
        public String ArrendadorNombre
        {
            get { return Fields.ArrendadorNombre[this]; }
            set { Fields.ArrendadorNombre[this] = value; }
        }

        [DisplayName("Arrendador Tipo Id"), Expression("jArrendador.[tipoID]")]
        public Int32? ArrendadorTipoId
        {
            get { return Fields.ArrendadorTipoId[this]; }
            set { Fields.ArrendadorTipoId[this] = value; }
        }

        [DisplayName("Arrendador Notas"), Expression("jArrendador.[notas]")]
        public String ArrendadorNotas
        {
            get { return Fields.ArrendadorNotas[this]; }
            set { Fields.ArrendadorNotas[this] = value; }
        }

        [DisplayName("Arrendador Direccion"), Expression("jArrendador.[direccion]")]
        public String ArrendadorDireccion
        {
            get { return Fields.ArrendadorDireccion[this]; }
            set { Fields.ArrendadorDireccion[this] = value; }
        }

        [DisplayName("Arrendador Emails"), Expression("jArrendador.[emails]")]
        public String ArrendadorEmails
        {
            get { return Fields.ArrendadorEmails[this]; }
            set { Fields.ArrendadorEmails[this] = value; }
        }

        [DisplayName("Arrendador Codigo Postal"), Expression("jArrendador.[codigoPostal]")]
        public String ArrendadorCodigoPostal
        {
            get { return Fields.ArrendadorCodigoPostal[this]; }
            set { Fields.ArrendadorCodigoPostal[this] = value; }
        }

        [DisplayName("Arrendador Tenant Id"), Expression("jArrendador.[tenantID]")]
        public Int32? ArrendadorTenantId
        {
            get { return Fields.ArrendadorTenantId[this]; }
            set { Fields.ArrendadorTenantId[this] = value; }
        }

        [DisplayName("Arrendador Nombre Representante"), Expression("jArrendador.[nombreRepresentante]")]
        public String ArrendadorNombreRepresentante
        {
            get { return Fields.ArrendadorNombreRepresentante[this]; }
            set { Fields.ArrendadorNombreRepresentante[this] = value; }
        }

        [DisplayName("Arrendador Identificacion Representante"), Expression("jArrendador.[identificacionRepresentante]")]
        public String ArrendadorIdentificacionRepresentante
        {
            get { return Fields.ArrendadorIdentificacionRepresentante[this]; }
            set { Fields.ArrendadorIdentificacionRepresentante[this] = value; }
        }

        [DisplayName("Arrendador Tipo Id Representante"), Expression("jArrendador.[tipoIDRepresentante]")]
        public Int32? ArrendadorTipoIdRepresentante
        {
            get { return Fields.ArrendadorTipoIdRepresentante[this]; }
            set { Fields.ArrendadorTipoIdRepresentante[this] = value; }
        }

        [DisplayName("Arrendador Website"), Expression("jArrendador.[website]")]
        public String ArrendadorWebsite
        {
            get { return Fields.ArrendadorWebsite[this]; }
            set { Fields.ArrendadorWebsite[this] = value; }
        }

        [NotesEditor, NotMapped]
        public List<NoteRow> NoteList
        {
            get { return Fields.NoteList[this]; }
            set { Fields.NoteList[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.NumeroContrato; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvSitiosContratosArrendamientoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int32Field SitioId;
            public ListField<Int64> ProductosAsociados;
            public Int32Field ArrendadorId;
            public StringField NumeroContrato;
            public Int32Field TipoContratoId;
            public Int32Field TipoFechaDePagoContratoId;
            public StringField TipoFechaPagoNombre;
            public Int32Field MonedaId;
            public StringField MonedaNombre;
            public StringField MonedaSimbolo;
            public StringField MonedaCodigo;
            public DecimalField Monto;
            public StringField DocumentosDigitalizados;
            public DateTimeField FechaInicial;
            public DateTimeField FechaFinal;
            public DecimalField PorcentajeIncrementoRenovacion;
            public Int32Field TenantId;
            public Int32Field UserRegistraId;
            public StringField UsuarioRegistraUsername;
            public Int32Field UserApruedaId;
            public StringField UsuarioApruebaUsername;
            public Int32Field UserId;
            public BooleanField EstaAprobado;
            public BooleanField Estatus;
            public Int64Field AdendumId;

            public Int32Field SitioArrendadorId;
            public StringField SitioDireccion;
            public Int32Field SitioDivisionAdministrativaN1;
            public Int32Field SitioDivisionAdministrativaN2;
            public Int32Field SitioDivisionAdministrativaN3;
            public Int32Field SitioDivisionAdministrativaN4;
            public Int32Field SitioDivisionAdministrativaN5;
            public Int32Field SitioRutaId;
            public StringField SitioCodigoSitio;

            public StringField ArrendadorIdentificacion;
            public StringField ArrendadorNombre;
            public Int32Field ArrendadorTipoId;
            public StringField ArrendadorNotas;
            public StringField ArrendadorDireccion;
            public StringField ArrendadorEmails;
            public StringField ArrendadorCodigoPostal;
            public Int32Field ArrendadorTenantId;
            public StringField ArrendadorNombreRepresentante;
            public StringField ArrendadorIdentificacionRepresentante;
            public Int32Field ArrendadorTipoIdRepresentante;
            public StringField ArrendadorWebsite;
            public RowListField<NoteRow> NoteList;

            public RowFields()
                : base("[dbo].[Inv_SitiosContratosArrendamiento]")
            {
                LocalTextPrefix = "Inventario.InvSitiosContratosArrendamiento";
            }
        }
    }
}