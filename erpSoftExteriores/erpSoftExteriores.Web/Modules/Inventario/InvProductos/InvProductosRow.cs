
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

    [ConnectionKey("Default"), DisplayName("Productos"), InstanceName("Producto"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.Productos.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.Productos.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.Productos.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.Productos.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.Productos.Delete)]
    [LookupScript("Inventario.Productos")]
    public sealed class InvProductosRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int64? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Código Producto"), Column("codigoProducto"), Size(50), QuickSearch, LookupInclude]
        public String CodigoProducto
        {
            get { return Fields.CodigoProducto[this]; }
            set { Fields.CodigoProducto[this] = value; }
        }

        [DisplayName("Sitio"), Column("sitioID"), NotNull, ForeignKey("[dbo].[Inv_Sitios]", "ID"), LeftJoin("jSitio"), TextualField("SitioDireccion")]
        [LookupEditor(typeof(InvSitiosRow)), LookupInclude]
        public Int32? SitioId
        {
            get { return Fields.SitioId[this]; }
            set { Fields.SitioId[this] = value; }
        }

        [NotesEditor, NotMapped]
        public List<NoteRow> NoteList
        {
            get { return Fields.NoteList[this]; }
            set { Fields.NoteList[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(40), QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Categoría"), Column("categoriasSoporteEstructuraID"), LookupInclude, NotNull, ForeignKey("[dbo].[Inv_CategoriasSoporteEstructura]", "ID"), LeftJoin("jCategoriasSoporteEstructura"), TextualField("CategoriasSoporteEstructuraNombre")]
        [LookupEditor(typeof(InvCategoriasSoporteEstructuraRow))]
        public Int32? CategoriasSoporteEstructuraId
        {
            get { return Fields.CategoriasSoporteEstructuraId[this]; }
            set { Fields.CategoriasSoporteEstructuraId[this] = value; }
        }

        [DisplayName("Categoria"), Expression("jCategoriasSoporteEstructura.[nombre]")]
        public String CategoriasSoporteEstructuraNombre
        {
            get { return Fields.CategoriasSoporteEstructuraNombre[this]; }
            set { Fields.CategoriasSoporteEstructuraNombre[this] = value; }
        }

        [DisplayName("Categorias Soporte Estructura Tenant Id"), Expression("jCategoriasSoporteEstructura.[tenantID]")]
        public Int32? CategoriasSoporteEstructuraTenantId
        {
            get { return Fields.CategoriasSoporteEstructuraTenantId[this]; }
            set { Fields.CategoriasSoporteEstructuraTenantId[this] = value; }
        }


        [DisplayName("Tipo"), Column("tiposEstructuraID"), LookupInclude, NotNull, ForeignKey("[dbo].[Inv_TiposEstructura]", "ID"), LeftJoin("jTiposEstructura"), TextualField("TiposEstructuraNombre")]
        [LookupEditor(typeof(InvTiposEstructuraRow), CascadeFrom = "CategoriasSoporteEstructuraId", CascadeField = "CategoriasSoporteEstructuraId")]
        public Int32? TiposEstructuraId
        {
            get { return Fields.TiposEstructuraId[this]; }
            set { Fields.TiposEstructuraId[this] = value; }
        }

        [DisplayName("Tipo"), Expression("jTiposEstructura.[nombre]")]
        public String TiposEstructuraNombre
        {
            get { return Fields.TiposEstructuraNombre[this]; }
            set { Fields.TiposEstructuraNombre[this] = value; }
        }

        [DisplayName("Categorias Soporte Estructura Tenant Id"), Expression("jTiposEstructura.[tenantID]")]
        public Int32? TiposEstructuraTenantId
        {
            get { return Fields.TiposEstructuraTenantId[this]; }
            set { Fields.TiposEstructuraTenantId[this] = value; }
        }




        [DisplayName("Circuito Id"), Column("circuitoID")]
        public Int32? CircuitoId
        {
            get { return Fields.CircuitoId[this]; }
            set { Fields.CircuitoId[this] = value; }
        }

        [DisplayName("Estatus"), Column("estatusID"), NotNull, ForeignKey("[dbo].[Inv_Status]", "ID"), LeftJoin("jStatus"), TextualField("EstatusNombre")]
        [LookupEditor(typeof(Entities.InvStatusRow))]
        public Int32? EstatusId
        {
            get { return Fields.EstatusId[this]; }
            set { Fields.EstatusId[this] = value; }
        }

        [DisplayName("Estatus"), Expression("jStatus.[nombre]"), QuickSearch]
        public String EstatusNombre
        {
            get { return Fields.EstatusNombre[this]; }
            set { Fields.EstatusNombre[this] = value; }
        }

        [DisplayName("Moneda"), Column("monedaID"), NotNull, ForeignKey("[dbo].[Gen_Monedas]", "ID"), LeftJoin("jMoneda"), TextualField("MonedaNombre")]
        [LookupEditor(typeof(General.Entities.GenMonedasRow))]
        public Int32? MonedaId
        {
            get { return Fields.MonedaId[this]; }
            set { Fields.MonedaId[this] = value; }
        }

        [DisplayName("Precio Venta"), Column("precioVenta"), Size(19), Scale(2), NotNull, AlignRight, DisplayFormat("#,##0.00")]
        public Decimal? PrecioVenta
        {
            get { return Fields.PrecioVenta[this]; }
            set { Fields.PrecioVenta[this] = value; }
        }

        [DisplayName("Precio Venta Minimo"), Column("precioVentaMinimo"), Size(19), Scale(2), NotNull, AlignRight, DisplayFormat("#,##0.00")]
        public Decimal? PrecioVentaMinimo
        {
            get { return Fields.PrecioVentaMinimo[this]; }
            set { Fields.PrecioVentaMinimo[this] = value; }
        }

        [DisplayName("Precio Venta Circuito"), Column("precioVentaCircuito"), Size(19), Scale(2), AlignRight, DisplayFormat("#,##0.00")]
        public Decimal? PrecioVentaCircuito
        {
            get { return Fields.PrecioVentaCircuito[this]; }
            set { Fields.PrecioVentaCircuito[this] = value; }
        }

        [DisplayName("Cantidad Por Unidad"), Column("cantidadPorUnidad"), Size(20)]
        public String CantidadPorUnidad
        {
            get { return Fields.CantidadPorUnidad[this]; }
            set { Fields.CantidadPorUnidad[this] = value; }
        }

        [DisplayName("Unidades En Stock"), Column("unidadesEnStock")]
        public Int16? UnidadesEnStock
        {
            get { return Fields.UnidadesEnStock[this]; }
            set { Fields.UnidadesEnStock[this] = value; }
        }


        [DisplayName("Notas del producto"), Column("notas"), Size(200)]
        public String Notas
        {
            get { return Fields.Notas[this]; }
            set { Fields.Notas[this] = value; }
        }

        [DisplayName("Description Vista"), Column("descriptionVista"), Size(200), NotNull]
        public String DescriptionVista
        {
            get { return Fields.DescriptionVista[this]; }
            set { Fields.DescriptionVista[this] = value; }
        }

        [DisplayName("Base"), Column("base"), Size(10), Scale(2), NotNull]
        public Decimal? Base
        {
            get { return Fields.Base[this]; }
            set { Fields.Base[this] = value; }
        }

        [DisplayName("Altura"), Column("altura"), Size(10), Scale(2), NotNull]
        public Decimal? Altura
        {
            get { return Fields.Altura[this]; }
            set { Fields.Altura[this] = value; }
        }

        [DisplayName("Área"), Size(10), Scale(2), Expression("(T0.[Base] * T0.[Altura])"), ReadOnly(true)]
        public Decimal? Area
        {
            get { return Fields.Area[this]; }
            set { Fields.Area[this] = value; }
        }


        //[ImageUploadEditor]
        [MultipleImageUploadEditor(FilenameFormat = "Productos/~", CopyToHistory = true, ScaleWidth = 1024, ScaleHeight = 768)]
        [DisplayName("Imagenes"), Column("imagenes")]
        public String Imagenes
        {
            get { return Fields.Imagenes[this]; }
            set { Fields.Imagenes[this] = value; }
        }

        [DisplayName("Latitud"), Column("GPSLatitud"), Size(100)]
        public String GpsLatitud
        {
            get { return Fields.GpsLatitud[this]; }
            set { Fields.GpsLatitud[this] = value; }
        }

        [DisplayName("Longitud"), Column("GPSLongitud"), Size(100)]
        public String GpsLongitud
        {
            get { return Fields.GpsLongitud[this]; }
            set { Fields.GpsLongitud[this] = value; }
        }

        [DisplayName("Ubicacion"), Column("ubicacion"), Size(200)]
        public String Ubicacion
        {
            get { return Fields.Ubicacion[this]; }
            set { Fields.Ubicacion[this] = value; }
        }

        [DisplayName("Gps Ruta Id"), Column("GPSRutaID")]
        public Int32? GpsRutaId
        {
            get { return Fields.GpsRutaId[this]; }
            set { Fields.GpsRutaId[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Id Legal Info"), Column("legalInfoID"), ForeignKey("[dbo].[Inv_ProductosLegal]", "ID"), LeftJoin("jPLegal"), TextualField("LegalDocumentoUno")]
        [InvProductosLegalEditor(InplaceAdd = true)]
        public Int32? LegalInfoId
        {
            get { return Fields.LegalInfoId[this]; }
            set { Fields.LegalInfoId[this] = value; }
        }

        [DisplayName("Número Oficio"), Expression("jPLegal.[DocumentoUno]")]
        public String LegalDocumentoUno
        {
            get { return Fields.LegalDocumentoUno[this] + "..."; }
            set { Fields.LegalDocumentoUno[this] = value; }
        }

        [DisplayName("Tiene Iluminación"), Column("tieneIluminacion")]
        public Boolean? TieneIluminacion
        {
            get { return Fields.TieneIluminacion[this]; }
            set { Fields.TieneIluminacion[this] = value; }
        }

        [DisplayName("Precio Iluminación"), Column("precioIluminacion"), Size(19), Scale(2), DisplayFormat("#,##0.00")]
        public Decimal? PrecioIluminacion
        {
            get { return Fields.PrecioIluminacion[this]; }
            set { Fields.PrecioIluminacion[this] = value; }
        }

        [DisplayName("Moneda"), Column("monedaIluminacionId"),ForeignKey("[dbo].[Gen_Monedas]", "ID"), LeftJoin("jiMoneda"), TextualField("MonedaNombre")]
        [LookupEditor(typeof(General.Entities.GenMonedasRow))]
        public Int32? MonedaIluminacionId
        {
            get { return Fields.MonedaIluminacionId[this]; }
            set { Fields.MonedaIluminacionId[this] = value; }
        }

        [DisplayName("Precios incluyen la Iluminación"), Column("precioIncluyeIluminacion")]
        public Boolean? PrecioIncluyeIluminacion
        {
            get { return Fields.PrecioIncluyeIluminacion[this]; }
            set { Fields.PrecioIncluyeIluminacion[this] = value; }
        }

        [DisplayName("Sitio Arrendador Id"), ForeignKey("[dbo].[Inv_Arrendadores]", "ID"), LeftJoin("jArrendador"), Expression("jSitio.[arrendadorID]"), TextualField("ArrendadorNombre")]
        [LookupEditor(typeof(Inventario.Entities.InvArrendadoresRow))]
        public Int32? SitioArrendadorId
        {
            get { return Fields.SitioArrendadorId[this]; }
            set { Fields.SitioArrendadorId[this] = value; }
        }

        [DisplayName("Arrendador"), Expression("jArrendador.[nombre]"), QuickSearch]
        public String SitioArrendadorNombre
        {
            get { return Fields.SitioArrendadorNombre[this]; }
            set { Fields.SitioArrendadorNombre[this] = value; }
        }

        [DisplayName("Sitio Direccion"), Expression("jSitio.[direccion]")]
        public String SitioDireccion
        {
            get { return Fields.SitioDireccion[this]; }
            set { Fields.SitioDireccion[this] = value; }
        }

        [DisplayName("Sitio Notas"), Expression("jSitio.[notas]")]
        public String SitioNotas
        {
            get { return Fields.SitioNotas[this]; }
            set { Fields.SitioNotas[this] = value; }
        }

        [DisplayName("Sitio Tenant Id"), Expression("jSitio.[tenantID]")]
        public Int32? SitioTenantId
        {
            get { return Fields.SitioTenantId[this]; }
            set { Fields.SitioTenantId[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N1), ForeignKey("[dbo].[Gen_DivisionesAdministrativasN1]", "ID"), LeftJoin("jDivisionAdministrativaN1"), Expression("jSitio.[divisionAdministrativaN1]")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN1Row))]
        public Int32? SitioDivisionAdministrativaN1
        {
            get { return Fields.SitioDivisionAdministrativaN1[this]; }
            set { Fields.SitioDivisionAdministrativaN1[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N1), Expression("jDivisionAdministrativaN1.[nombre]")]
        public String SitioDivisionAdministrativaN1Nombre
        {
            get { return Fields.SitioDivisionAdministrativaN1Nombre[this]; }
            set { Fields.SitioDivisionAdministrativaN1Nombre[this] = value; }
        }


        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N2), ForeignKey("[dbo].[Gen_DivisionesAdministrativasN2]", "ID"), LeftJoin("jDivisionAdministrativaN2"), Expression("jSitio.[divisionAdministrativaN2]")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN2Row))]
        public Int32? SitioDivisionAdministrativaN2
        {
            get { return Fields.SitioDivisionAdministrativaN2[this]; }
            set { Fields.SitioDivisionAdministrativaN2[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N2), Expression("jDivisionAdministrativaN2.[nombre]")]
        public String SitioDivisionAdministrativaN2Nombre
        {
            get { return Fields.SitioDivisionAdministrativaN2Nombre[this]; }
            set { Fields.SitioDivisionAdministrativaN2Nombre[this] = value; }
        }



        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N3), ForeignKey("[dbo].[Gen_DivisionesAdministrativasN3]", "ID"), LeftJoin("jDivisionAdministrativaN3"), Expression("jSitio.[divisionAdministrativaN3]")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN3Row), CascadeFrom = "SitioDivisionAdministrativaN2", CascadeField = "divisionAdministrativaN1")]
        public Int32? SitioDivisionAdministrativaN3
        {
            get { return Fields.SitioDivisionAdministrativaN3[this]; }
            set { Fields.SitioDivisionAdministrativaN3[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N3), Expression("jDivisionAdministrativaN3.[nombre]")]
        public String SitioDivisionAdministrativaN3Nombre
        {
            get { return Fields.SitioDivisionAdministrativaN3Nombre[this]; }
            set { Fields.SitioDivisionAdministrativaN3Nombre[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N4), ForeignKey("[dbo].[Gen_DivisionesAdministrativasN4]", "ID"), LeftJoin("jDivisionAdministrativaN4"), Expression("jSitio.[divisionAdministrativaN4]")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN4Row), CascadeFrom = "SitioDivisionAdministrativaN3", CascadeField = "DivisionSuperiorN3")]
        public Int32? SitioDivisionAdministrativaN4
        {
            get { return Fields.SitioDivisionAdministrativaN4[this]; }
            set { Fields.SitioDivisionAdministrativaN4[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N4), Expression("jDivisionAdministrativaN4.[nombre]")]
        public String SitioDivisionAdministrativaN4Nombre
        {
            get { return Fields.SitioDivisionAdministrativaN4Nombre[this]; }
            set { Fields.SitioDivisionAdministrativaN4Nombre[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N5), ForeignKey("[dbo].[Gen_DivisionesAdministrativasN5]", "ID"), LeftJoin("jDivisionAdministrativaN5") Expression("jSitio.[divisionAdministrativaN5]")]
        [LookupEditor(typeof(General.Entities.GenDivisionesAdministrativasN5Row), CascadeFrom = "SitioDivisionAdministrativaN4", CascadeField = "DivisionSuperiorN4")]
        public Int32? SitioDivisionAdministrativaN5
        {
            get { return Fields.SitioDivisionAdministrativaN5[this]; }
            set { Fields.SitioDivisionAdministrativaN5[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N5), Expression("jDivisionAdministrativaN5.[nombre]")]
        public String SitioDivisionAdministrativaN5Nombre
        {
            get { return Fields.SitioDivisionAdministrativaN5Nombre[this]; }
            set { Fields.SitioDivisionAdministrativaN5Nombre[this] = value; }
        }

        [DisplayName("Sitio Ruta Id"), ForeignKey("[dbo].[Gen_Rutas]", "ID"), LeftJoin("jRuta"), Expression("jSitio.[rutaID]")]
        [LookupEditor(typeof(General.Entities.GenRutasRow))]
        public Int32? SitioRutaId
        {
            get { return Fields.SitioRutaId[this]; }
            set { Fields.SitioRutaId[this] = value; }
        }

        [DisplayName("Ruta"), Expression("jRuta.[nombre]")]
        public String SitioRutaNombre
        {
            get { return Fields.SitioRutaNombre[this]; }
            set { Fields.SitioRutaNombre[this] = value; }
        }


        [DisplayName("Código Sitio"), Expression("jSitio.[codigoSitio]"), QuickSearch]
        public String SitioCodigoSitio
        {
            get { return Fields.SitioCodigoSitio[this]; }
            set { Fields.SitioCodigoSitio[this] = value; }
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

        [DisplayName("Moneda Pais"), Expression("jMoneda.[pais]")]
        public String MonedaPais
        {
            get { return Fields.MonedaPais[this]; }
            set { Fields.MonedaPais[this] = value; }
        }

        [DisplayName("Moneda Codigo Pais"), Expression("jMoneda.[codigoPais]")]
        public String MonedaCodigoPais
        {
            get { return Fields.MonedaCodigoPais[this]; }
            set { Fields.MonedaCodigoPais[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CodigoProducto; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvProductosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int32Field SitioId;
            public StringField Nombre;
            public Int32Field CategoriasSoporteEstructuraId;
            public StringField CategoriasSoporteEstructuraNombre;
            public Int32Field CategoriasSoporteEstructuraTenantId;
            
            public Int32Field TiposEstructuraId;
            public StringField TiposEstructuraNombre;
            public Int32Field TiposEstructuraTenantId;

            public Int32Field CircuitoId;
            public Int32Field EstatusId;
            public StringField EstatusNombre;
            public Int32Field MonedaId;
            public DecimalField PrecioVenta;
            public DecimalField PrecioVentaMinimo;
            public DecimalField PrecioVentaCircuito;
            public StringField CantidadPorUnidad;
            public Int16Field UnidadesEnStock;
            public StringField CodigoProducto;
            public StringField Notas;
            public StringField DescriptionVista;
            public DecimalField Base;
            public DecimalField Altura;
            public DecimalField Area;
            public StringField Imagenes;
            public StringField GpsLatitud;
            public StringField GpsLongitud;
            public StringField Ubicacion;
            public Int32Field GpsRutaId;
            public Int32Field TenantId;
            public Int32Field LegalInfoId;
            public StringField LegalDocumentoUno;
            public BooleanField TieneIluminacion;
            public DecimalField PrecioIluminacion;
            public Int32Field MonedaIluminacionId;
            public BooleanField PrecioIncluyeIluminacion;

            public Int32Field SitioArrendadorId;
            public StringField SitioArrendadorNombre;
            public StringField SitioDireccion;

            public StringField SitioNotas;
            public Int32Field SitioTenantId;
            public Int32Field SitioDivisionAdministrativaN1;
            public StringField SitioDivisionAdministrativaN1Nombre;
            public Int32Field SitioDivisionAdministrativaN2;
            public StringField SitioDivisionAdministrativaN2Nombre;
            public Int32Field SitioDivisionAdministrativaN3;
            public StringField SitioDivisionAdministrativaN3Nombre;
            public Int32Field SitioDivisionAdministrativaN4;
            public StringField SitioDivisionAdministrativaN4Nombre;
            public Int32Field SitioDivisionAdministrativaN5;
            public StringField SitioDivisionAdministrativaN5Nombre;
            public Int32Field SitioRutaId;
            public StringField SitioRutaNombre;
            public StringField SitioCodigoSitio;

            public StringField MonedaNombre;
            public StringField MonedaSimbolo;
            public StringField MonedaCodigo;
            public StringField MonedaPais;
            public StringField MonedaCodigoPais;
            public RowListField<NoteRow> NoteList;

            public RowFields()
                : base("[dbo].[Inv_Productos]")
            {
                LocalTextPrefix = "Inventario.InvProductos";
            }
        }
    }
}