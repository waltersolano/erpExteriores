

namespace erpSoftExteriores.Inventario.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Sitios"), InstanceName("Sitio"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.Sitios.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.Sitios.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.Sitios.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.Sitios.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.Sitios.Delete)]
    [LookupScript("Inventario.Sitios")]
    public sealed class InvSitiosRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Codigo Sitio"), Column("codigoSitio"), Size(50), QuickSearch, LookupInclude]
        public String CodigoSitio
        {
            get { return Fields.CodigoSitio[this]; }
            set { Fields.CodigoSitio[this] = value; }
        }

        [DisplayName("Contrato"), Column("contratoID"), ForeignKey("[dbo].[Inv_SitiosContratosArrendamiento]", "ID"), LeftJoin("jContrato"), TextualField("ContratoNumeroContrato")]
        public Int64? ContratoId
        {
            get { return Fields.ContratoId[this]; }
            set { Fields.ContratoId[this] = value; }
        }

        [DisplayName("Direccion"), Column("direccion"), Size(200), NotNull, QuickSearch, TextAreaEditor]
        public String Direccion
        {
            get { return Fields.Direccion[this]; }
            set { Fields.Direccion[this] = value; }
        }

        [DisplayName("Notas del Sitio"), Column("notas"), Size(200), TextAreaEditor]
        public String Notas
        {
            get { return Fields.Notas[this]; }
            set { Fields.Notas[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Ruta"), Column("rutaID"), ForeignKey("[dbo].[Gen_Rutas]", "ID"), LeftJoin("jRuta"), TextualField("RutaNombre")]
        [LookupEditor(typeof(General.Entities.GenRutasRow))]
        public Int32? RutaId
        {
            get { return Fields.RutaId[this]; }
            set { Fields.RutaId[this] = value; }
        }

        [DisplayName("Ruta"), Expression("jRuta.[nombre]")]
        public String RutaNombre
        {
            get { return Fields.RutaNombre[this]; }
            set { Fields.RutaNombre[this] = value; }
        }

        [DisplayName("Ruta Descripcion"), Expression("jRuta.[descripcion]")]
        public String RutaDescripcion
        {
            get { return Fields.RutaDescripcion[this]; }
            set { Fields.RutaDescripcion[this] = value; }
        }

        [DisplayName("Ruta Carreteras"), Expression("jRuta.[carreteras]")]
        public String RutaCarreteras
        {
            get { return Fields.RutaCarreteras[this]; }
            set { Fields.RutaCarreteras[this] = value; }
        }

        [DisplayName("Arrendador"), InvArrendadoresEditor, Column("arrendadorID"), NotNull, ForeignKey("[dbo].[Inv_Arrendadores]", "ID"), LeftJoin("jArrendador"), TextualField("ArrendadorNombre")]
        [LookupEditor(typeof(InvArrendadoresRow))]
        public Int32? ArrendadorId
        {
            get { return Fields.ArrendadorId[this]; }
            set { Fields.ArrendadorId[this] = value; }
        }

        [DisplayName("Identificacion"), Expression("jArrendador.[identificacion]"), LookupInclude]
        public String ArrendadorIdentificacion
        {
            get { return Fields.ArrendadorIdentificacion[this]; }
            set { Fields.ArrendadorIdentificacion[this] = value; }
        }

        [DisplayName("Arrendador"), Expression("jArrendador.[nombre]"), QuickSearch, LookupInclude]
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

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N1),Column("divisionAdministrativaN1"), NotNull, ForeignKey("[dbo].[Gen_DivisionesAdministrativasN1]", "ID"), LeftJoin("jDivisionAdministrativaN1"), TextualField("DivisionAdministrativaN1Nombre")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN1Row))]
        public Int32? DivisionAdministrativaN1
        {
            get { return Fields.DivisionAdministrativaN1[this]; }
            set { Fields.DivisionAdministrativaN1[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N2), Column("divisionAdministrativaN2"), NotNull, ForeignKey("[dbo].[Gen_DivisionesAdministrativasN2]", "ID"), LeftJoin("jDivisionAdministrativaN2"), TextualField("DivisionAdministrativaN2Nombre")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN2Row), CascadeFrom = "DivisionAdministrativaN1", CascadeField = "DivisionSuperiorN1")]
        public Int32? DivisionAdministrativaN2
        {
            get { return Fields.DivisionAdministrativaN2[this]; }
            set { Fields.DivisionAdministrativaN2[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N3), Column("divisionAdministrativaN3"), NotNull, ForeignKey("[dbo].[Gen_DivisionesAdministrativasN3]", "ID"), LeftJoin("jDivisionAdministrativaN3"), TextualField("DivisionAdministrativaN3Nombre")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN3Row), CascadeFrom = "DivisionAdministrativaN2", CascadeField = "DivisionSuperiorN2")]
        public Int32? DivisionAdministrativaN3
        {
            get { return Fields.DivisionAdministrativaN3[this]; }
            set { Fields.DivisionAdministrativaN3[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N4), Column("divisionAdministrativaN4"), ForeignKey("[dbo].[Gen_DivisionesAdministrativasN4]", "ID"), LeftJoin("jDivisionAdministrativaN4"), TextualField("DivisionAdministrativaN4Nombre")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN4Row), CascadeFrom = "DivisionAdministrativaN3", CascadeField = "DivisionSuperiorN3")]
        public Int32? DivisionAdministrativaN4
        {
            get { return Fields.DivisionAdministrativaN4[this]; }
            set { Fields.DivisionAdministrativaN4[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N5), Column("divisionAdministrativaN5"), ForeignKey("[dbo].[Gen_DivisionesAdministrativasN5]", "ID"), LeftJoin("jDivisionAdministrativaN5"), TextualField("DivisionAdministrativaN5Nombre")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN5Row), CascadeFrom = "DivisionAdministrativaN4", CascadeField = "DivisionSuperiorN4")]
        public Int32? DivisionAdministrativaN5
        {
            get { return Fields.DivisionAdministrativaN5[this]; }
            set { Fields.DivisionAdministrativaN5[this] = value; }
        }

        [DisplayName("Division Administrativa N1 Codigo"), Expression("jDivisionAdministrativaN1.[codigo]")]
        public String DivisionAdministrativaN1Codigo
        {
            get { return Fields.DivisionAdministrativaN1Codigo[this]; }
            set { Fields.DivisionAdministrativaN1Codigo[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N1), Expression("jDivisionAdministrativaN1.[nombre]")]
        public String DivisionAdministrativaN1Nombre
        {
            get { return Fields.DivisionAdministrativaN1Nombre[this]; }
            set { Fields.DivisionAdministrativaN1Nombre[this] = value; }
        }

        [DisplayName("Division Administrativa N1 Division Superior"), Expression("jDivisionAdministrativaN1.[divisionSuperior]")]
        public Int32? DivisionAdministrativaN1DivisionSuperior
        {
            get { return Fields.DivisionAdministrativaN1DivisionSuperior[this]; }
            set { Fields.DivisionAdministrativaN1DivisionSuperior[this] = value; }
        }

        [DisplayName("Division Administrativa N2 Codigo"), Expression("jDivisionAdministrativaN2.[codigo]")]
        public String DivisionAdministrativaN2Codigo
        {
            get { return Fields.DivisionAdministrativaN2Codigo[this]; }
            set { Fields.DivisionAdministrativaN2Codigo[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N2), Expression("jDivisionAdministrativaN2.[nombre]")]
        public String DivisionAdministrativaN2Nombre
        {
            get { return Fields.DivisionAdministrativaN2Nombre[this]; }
            set { Fields.DivisionAdministrativaN2Nombre[this] = value; }
        }

        [DisplayName("Division Administrativa N2 Division Superior N1"), Expression("jDivisionAdministrativaN2.[divisionSuperiorN1]")]
        public Int32? DivisionAdministrativaN2DivisionSuperiorN1
        {
            get { return Fields.DivisionAdministrativaN2DivisionSuperiorN1[this]; }
            set { Fields.DivisionAdministrativaN2DivisionSuperiorN1[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N3), Expression("jDivisionAdministrativaN3.[codigo]")]
        public String DivisionAdministrativaN3Codigo
        {
            get { return Fields.DivisionAdministrativaN3Codigo[this]; }
            set { Fields.DivisionAdministrativaN3Codigo[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N3), Expression("jDivisionAdministrativaN3.[nombre]")]
        public String DivisionAdministrativaN3Nombre
        {
            get { return Fields.DivisionAdministrativaN3Nombre[this]; }
            set { Fields.DivisionAdministrativaN3Nombre[this] = value; }
        }

        [DisplayName("Division Administrativa N3 Division Superior N2"), Expression("jDivisionAdministrativaN3.[divisionSuperiorN2]")]
        public Int32? DivisionAdministrativaN3DivisionSuperiorN2
        {
            get { return Fields.DivisionAdministrativaN3DivisionSuperiorN2[this]; }
            set { Fields.DivisionAdministrativaN3DivisionSuperiorN2[this] = value; }
        }

        [DisplayName("Division Administrativa N4 Codigo"), Expression("jDivisionAdministrativaN4.[codigo]")]
        public String DivisionAdministrativaN4Codigo
        {
            get { return Fields.DivisionAdministrativaN4Codigo[this]; }
            set { Fields.DivisionAdministrativaN4Codigo[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N4), Expression("jDivisionAdministrativaN4.[nombre]")]
        public String DivisionAdministrativaN4Nombre
        {
            get { return Fields.DivisionAdministrativaN4Nombre[this]; }
            set { Fields.DivisionAdministrativaN4Nombre[this] = value; }
        }

        [DisplayName("Division Administrativa N4 Division Superior N3"), Expression("jDivisionAdministrativaN4.[divisionSuperiorN3]")]
        public Int32? DivisionAdministrativaN4DivisionSuperiorN3
        {
            get { return Fields.DivisionAdministrativaN4DivisionSuperiorN3[this]; }
            set { Fields.DivisionAdministrativaN4DivisionSuperiorN3[this] = value; }
        }

        [DisplayName("Division Administrativa N5 Codigo"), Expression("jDivisionAdministrativaN5.[codigo]")]
        public String DivisionAdministrativaN5Codigo
        {
            get { return Fields.DivisionAdministrativaN5Codigo[this]; }
            set { Fields.DivisionAdministrativaN5Codigo[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N5), Expression("jDivisionAdministrativaN5.[nombre]")]
        public String DivisionAdministrativaN5Nombre
        {
            get { return Fields.DivisionAdministrativaN5Nombre[this]; }
            set { Fields.DivisionAdministrativaN5Nombre[this] = value; }
        }

        [DisplayName("Division Administrativa N5 Division Superior N4"), Expression("jDivisionAdministrativaN5.[divisionSuperiorN4]")]
        public Int32? DivisionAdministrativaN5DivisionSuperiorN4
        {
            get { return Fields.DivisionAdministrativaN5DivisionSuperiorN4[this]; }
            set { Fields.DivisionAdministrativaN5DivisionSuperiorN4[this] = value; }
        }

        [DisplayName("Contrato Arrendador Id"), Expression("jContrato.[ArrendadorID]")]
        public Int32? ContratoArrendadorId
        {
            get { return Fields.ContratoArrendadorId[this]; }
            set { Fields.ContratoArrendadorId[this] = value; }
        }

        [DisplayName("Contrato Numero Contrato"), Expression("jContrato.[numeroContrato]")]
        public String ContratoNumeroContrato
        {
            get { return Fields.ContratoNumeroContrato[this]; }
            set { Fields.ContratoNumeroContrato[this] = value; }
        }

        [DisplayName("Contrato Tipo Contrato Id"), Expression("jContrato.[tipoContratoID]")]
        public Int32? ContratoTipoContratoId
        {
            get { return Fields.ContratoTipoContratoId[this]; }
            set { Fields.ContratoTipoContratoId[this] = value; }
        }

        [DisplayName("Contrato Tipo Fecha De Pago Contrato Id"), Expression("jContrato.[tipoFechaDePagoContratoID]")]
        public Int32? ContratoTipoFechaDePagoContratoId
        {
            get { return Fields.ContratoTipoFechaDePagoContratoId[this]; }
            set { Fields.ContratoTipoFechaDePagoContratoId[this] = value; }
        }

        [DisplayName("Contrato Moneda Id"), Expression("jContrato.[monedaID]")]
        public Int32? ContratoMonedaId
        {
            get { return Fields.ContratoMonedaId[this]; }
            set { Fields.ContratoMonedaId[this] = value; }
        }

        [DisplayName("Contrato Monto"), Expression("jContrato.[monto]")]
        public Decimal? ContratoMonto
        {
            get { return Fields.ContratoMonto[this]; }
            set { Fields.ContratoMonto[this] = value; }
        }

        [DisplayName("Contrato Documentos Digitalizados"), Expression("jContrato.[documentosDigitalizados]")]
        public String ContratoDocumentosDigitalizados
        {
            get { return Fields.ContratoDocumentosDigitalizados[this]; }
            set { Fields.ContratoDocumentosDigitalizados[this] = value; }
        }

        [DisplayName("Contrato Fecha Inicial"), Expression("jContrato.[fechaInicial]")]
        public DateTime? ContratoFechaInicial
        {
            get { return Fields.ContratoFechaInicial[this]; }
            set { Fields.ContratoFechaInicial[this] = value; }
        }

        [DisplayName("Contrato Fecha Final"), Expression("jContrato.[fechaFinal]")]
        public DateTime? ContratoFechaFinal
        {
            get { return Fields.ContratoFechaFinal[this]; }
            set { Fields.ContratoFechaFinal[this] = value; }
        }

        [DisplayName("Contrato Porcentaje Incremento Renovacion"), Expression("jContrato.[porcentajeIncrementoRenovacion]")]
        public Decimal? ContratoPorcentajeIncrementoRenovacion
        {
            get { return Fields.ContratoPorcentajeIncrementoRenovacion[this]; }
            set { Fields.ContratoPorcentajeIncrementoRenovacion[this] = value; }
        }

        [DisplayName("Contrato Tenant Id"), Expression("jContrato.[tenantID]")]
        public Int32? ContratoTenantId
        {
            get { return Fields.ContratoTenantId[this]; }
            set { Fields.ContratoTenantId[this] = value; }
        }

        [DisplayName("Contrato User Registra Id"), Expression("jContrato.[userRegistraID]")]
        public Int32? ContratoUserRegistraId
        {
            get { return Fields.ContratoUserRegistraId[this]; }
            set { Fields.ContratoUserRegistraId[this] = value; }
        }

        [DisplayName("Contrato User Aprueda Id"), Expression("jContrato.[userApruedaID]")]
        public Int32? ContratoUserApruedaId
        {
            get { return Fields.ContratoUserApruedaId[this]; }
            set { Fields.ContratoUserApruedaId[this] = value; }
        }

        [DisplayName("Contrato User Id"), Expression("jContrato.[userID]")]
        public Int32? ContratoUserId
        {
            get { return Fields.ContratoUserId[this]; }
            set { Fields.ContratoUserId[this] = value; }
        }

        [DisplayName("Contrato Esta Aprobado"), Expression("jContrato.[estaAprobado]")]
        public Boolean? ContratoEstaAprobado
        {
            get { return Fields.ContratoEstaAprobado[this]; }
            set { Fields.ContratoEstaAprobado[this] = value; }
        }



        [DisplayName("Contrato Adendum Id"), Expression("jContrato.[adendumID]")]
        public Int64? ContratoAdendumId
        {
            get { return Fields.ContratoAdendumId[this]; }
            set { Fields.ContratoAdendumId[this] = value; }
        }




        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CodigoSitio; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvSitiosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field ArrendadorId;
            public StringField Direccion;
            public StringField Notas;
            public Int32Field TenantId;
            public Int32Field DivisionAdministrativaN1;
            public Int32Field DivisionAdministrativaN2;
            public Int32Field DivisionAdministrativaN3;
            public Int32Field DivisionAdministrativaN4;
            public Int32Field DivisionAdministrativaN5;
            public Int32Field RutaId;
            public StringField CodigoSitio;
            public Int64Field ContratoId;

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

            public StringField DivisionAdministrativaN1Codigo;
            public StringField DivisionAdministrativaN1Nombre;
            public Int32Field DivisionAdministrativaN1DivisionSuperior;

            public StringField DivisionAdministrativaN2Codigo;
            public StringField DivisionAdministrativaN2Nombre;
            public Int32Field DivisionAdministrativaN2DivisionSuperiorN1;

            public StringField DivisionAdministrativaN3Codigo;
            public StringField DivisionAdministrativaN3Nombre;
            public Int32Field DivisionAdministrativaN3DivisionSuperiorN2;

            public StringField DivisionAdministrativaN4Codigo;
            public StringField DivisionAdministrativaN4Nombre;
            public Int32Field DivisionAdministrativaN4DivisionSuperiorN3;

            public StringField DivisionAdministrativaN5Codigo;
            public StringField DivisionAdministrativaN5Nombre;
            public Int32Field DivisionAdministrativaN5DivisionSuperiorN4;

            public StringField RutaNombre;
            public StringField RutaDescripcion;
            public StringField RutaCarreteras;


            public Int32Field ContratoArrendadorId;
            public StringField ContratoNumeroContrato;
            public Int32Field ContratoTipoContratoId;
            public Int32Field ContratoTipoFechaDePagoContratoId;
            public Int32Field ContratoMonedaId;
            public DecimalField ContratoMonto;
            public StringField ContratoDocumentosDigitalizados;
            public DateTimeField ContratoFechaInicial;
            public DateTimeField ContratoFechaFinal;
            public DecimalField ContratoPorcentajeIncrementoRenovacion;
            public Int32Field ContratoTenantId;
            public Int32Field ContratoUserRegistraId;
            public Int32Field ContratoUserApruedaId;
            public Int32Field ContratoUserId;
            public BooleanField ContratoEstaAprobado;
            public Int64Field ContratoAdendumId;

            public RowFields()
                : base("[dbo].[Inv_Sitios]")
            {
                LocalTextPrefix = "Inventario.InvSitios";
            }
        }
    }
}