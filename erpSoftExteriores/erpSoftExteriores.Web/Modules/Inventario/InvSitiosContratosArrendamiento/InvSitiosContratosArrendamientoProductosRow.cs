

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

    [ConnectionKey("Default"), DisplayName("Inv_SitiosContratosArrendamientoProductos"), InstanceName("Inv_SitiosContratosArrendamientoProductos"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.ContratosArrendamiento.Delete)]
    [LookupScript("Inventario.ContratosArrendamientoProducto")]
    public sealed class InvSitiosContratosArrendamientoProductosRow : Row, IIdRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int64? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Sitios Contrato"), Column("sitiosContratoID"), ForeignKey("[dbo].[Inv_SitiosContratosArrendamiento]", "ID"), LeftJoin("jSitiosContrato"), TextualField("SitiosContratoNumeroContrato")]
        public Int64? SitiosContratoId
        {
            get { return Fields.SitiosContratoId[this]; }
            set { Fields.SitiosContratoId[this] = value; }
        }

        [DisplayName("Producto"), Column("productoID"), ForeignKey("[dbo].[Inv_Productos]", "ID"), LeftJoin("jProducto"), TextualField("ProductoNombre")]
        public Int64? ProductoId
        {
            get { return Fields.ProductoId[this]; }
            set { Fields.ProductoId[this] = value; }
        }

        [DisplayName("Sitios Contrato Sitio Id"), Expression("jSitiosContrato.[SitioID]")]
        public Int32? SitiosContratoSitioId
        {
            get { return Fields.SitiosContratoSitioId[this]; }
            set { Fields.SitiosContratoSitioId[this] = value; }
        }

        [DisplayName("Sitios Contrato Arrendador Id"), Expression("jSitiosContrato.[ArrendadorID]")]
        public Int32? SitiosContratoArrendadorId
        {
            get { return Fields.SitiosContratoArrendadorId[this]; }
            set { Fields.SitiosContratoArrendadorId[this] = value; }
        }

        [DisplayName("Sitios Contrato Numero Contrato"), Expression("jSitiosContrato.[numeroContrato]")]
        public String SitiosContratoNumeroContrato
        {
            get { return Fields.SitiosContratoNumeroContrato[this]; }
            set { Fields.SitiosContratoNumeroContrato[this] = value; }
        }

        [DisplayName("Sitios Contrato Tipo Contrato Id"), Expression("jSitiosContrato.[tipoContratoID]")]
        public Int32? SitiosContratoTipoContratoId
        {
            get { return Fields.SitiosContratoTipoContratoId[this]; }
            set { Fields.SitiosContratoTipoContratoId[this] = value; }
        }

        [DisplayName("Sitios Contrato Tipo Fecha De Pago Contrato Id"), Expression("jSitiosContrato.[tipoFechaDePagoContratoID]")]
        public Int32? SitiosContratoTipoFechaDePagoContratoId
        {
            get { return Fields.SitiosContratoTipoFechaDePagoContratoId[this]; }
            set { Fields.SitiosContratoTipoFechaDePagoContratoId[this] = value; }
        }

        [DisplayName("Sitios Contrato Moneda Id"), Expression("jSitiosContrato.[monedaID]")]
        public Int32? SitiosContratoMonedaId
        {
            get { return Fields.SitiosContratoMonedaId[this]; }
            set { Fields.SitiosContratoMonedaId[this] = value; }
        }

        [DisplayName("Sitios Contrato Monto"), Expression("jSitiosContrato.[monto]")]
        public Decimal? SitiosContratoMonto
        {
            get { return Fields.SitiosContratoMonto[this]; }
            set { Fields.SitiosContratoMonto[this] = value; }
        }

        [DisplayName("Sitios Contrato Documentos Digitalizados"), Expression("jSitiosContrato.[documentosDigitalizados]")]
        public String SitiosContratoDocumentosDigitalizados
        {
            get { return Fields.SitiosContratoDocumentosDigitalizados[this]; }
            set { Fields.SitiosContratoDocumentosDigitalizados[this] = value; }
        }

        [DisplayName("Sitios Contrato Fecha Inicial"), Expression("jSitiosContrato.[fechaInicial]")]
        public DateTime? SitiosContratoFechaInicial
        {
            get { return Fields.SitiosContratoFechaInicial[this]; }
            set { Fields.SitiosContratoFechaInicial[this] = value; }
        }

        [DisplayName("Sitios Contrato Fecha Final"), Expression("jSitiosContrato.[fechaFinal]")]
        public DateTime? SitiosContratoFechaFinal
        {
            get { return Fields.SitiosContratoFechaFinal[this]; }
            set { Fields.SitiosContratoFechaFinal[this] = value; }
        }

        [DisplayName("Sitios Contrato Porcentaje Incremento Renovacion"), Expression("jSitiosContrato.[porcentajeIncrementoRenovacion]")]
        public Decimal? SitiosContratoPorcentajeIncrementoRenovacion
        {
            get { return Fields.SitiosContratoPorcentajeIncrementoRenovacion[this]; }
            set { Fields.SitiosContratoPorcentajeIncrementoRenovacion[this] = value; }
        }

        [DisplayName("Sitios Contrato Tenant Id"), Expression("jSitiosContrato.[tenantID]")]
        public Int32? SitiosContratoTenantId
        {
            get { return Fields.SitiosContratoTenantId[this]; }
            set { Fields.SitiosContratoTenantId[this] = value; }
        }

        [DisplayName("Sitios Contrato User Registra Id"), Expression("jSitiosContrato.[userRegistraID]")]
        public Int32? SitiosContratoUserRegistraId
        {
            get { return Fields.SitiosContratoUserRegistraId[this]; }
            set { Fields.SitiosContratoUserRegistraId[this] = value; }
        }

        [DisplayName("Sitios Contrato User Aprueda Id"), Expression("jSitiosContrato.[userApruedaID]")]
        public Int32? SitiosContratoUserApruedaId
        {
            get { return Fields.SitiosContratoUserApruedaId[this]; }
            set { Fields.SitiosContratoUserApruedaId[this] = value; }
        }

        [DisplayName("Sitios Contrato User Id"), Expression("jSitiosContrato.[userID]")]
        public Int32? SitiosContratoUserId
        {
            get { return Fields.SitiosContratoUserId[this]; }
            set { Fields.SitiosContratoUserId[this] = value; }
        }

        [DisplayName("Sitios Contrato Esta Aprobado"), Expression("jSitiosContrato.[estaAprobado]")]
        public Boolean? SitiosContratoEstaAprobado
        {
            get { return Fields.SitiosContratoEstaAprobado[this]; }
            set { Fields.SitiosContratoEstaAprobado[this] = value; }
        }

        [DisplayName("Sitios Contrato Estatus"), Expression("jSitiosContrato.[estatus]")]
        public String SitiosContratoEstatus
        {
            get { return Fields.SitiosContratoEstatus[this]; }
            set { Fields.SitiosContratoEstatus[this] = value; }
        }

        [DisplayName("Sitios Contrato Adendum Id"), Expression("jSitiosContrato.[adendumID]")]
        public Int64? SitiosContratoAdendumId
        {
            get { return Fields.SitiosContratoAdendumId[this]; }
            set { Fields.SitiosContratoAdendumId[this] = value; }
        }

        [DisplayName("Producto Sitio Id"), Expression("jProducto.[sitioID]")]
        public Int32? ProductoSitioId
        {
            get { return Fields.ProductoSitioId[this]; }
            set { Fields.ProductoSitioId[this] = value; }
        }

        [DisplayName("Producto Nombre"), Expression("jProducto.[nombre]")]
        public String ProductoNombre
        {
            get { return Fields.ProductoNombre[this]; }
            set { Fields.ProductoNombre[this] = value; }
        }

        [DisplayName("Producto Categorias Soporte Estructura Id"), Expression("jProducto.[categoriasSoporteEstructuraID]")]
        public Int32? ProductoCategoriasSoporteEstructuraId
        {
            get { return Fields.ProductoCategoriasSoporteEstructuraId[this]; }
            set { Fields.ProductoCategoriasSoporteEstructuraId[this] = value; }
        }

        [DisplayName("Producto Tipos Estructura Id"), Expression("jProducto.[tiposEstructuraID]")]
        public Int32? ProductoTiposEstructuraId
        {
            get { return Fields.ProductoTiposEstructuraId[this]; }
            set { Fields.ProductoTiposEstructuraId[this] = value; }
        }

        [DisplayName("Producto Circuito Id"), Expression("jProducto.[circuitoID]")]
        public Int32? ProductoCircuitoId
        {
            get { return Fields.ProductoCircuitoId[this]; }
            set { Fields.ProductoCircuitoId[this] = value; }
        }

        [DisplayName("Producto Estatus Id"), Expression("jProducto.[estatusID]")]
        public Int32? ProductoEstatusId
        {
            get { return Fields.ProductoEstatusId[this]; }
            set { Fields.ProductoEstatusId[this] = value; }
        }

        [DisplayName("Producto Moneda Id"), Expression("jProducto.[monedaID]")]
        public Int32? ProductoMonedaId
        {
            get { return Fields.ProductoMonedaId[this]; }
            set { Fields.ProductoMonedaId[this] = value; }
        }

        [DisplayName("Producto Precio Venta"), Expression("jProducto.[precioVenta]")]
        public Decimal? ProductoPrecioVenta
        {
            get { return Fields.ProductoPrecioVenta[this]; }
            set { Fields.ProductoPrecioVenta[this] = value; }
        }

        [DisplayName("Producto Precio Venta Minimo"), Expression("jProducto.[precioVentaMinimo]")]
        public Decimal? ProductoPrecioVentaMinimo
        {
            get { return Fields.ProductoPrecioVentaMinimo[this]; }
            set { Fields.ProductoPrecioVentaMinimo[this] = value; }
        }

        [DisplayName("Producto Precio Venta Circuito"), Expression("jProducto.[precioVentaCircuito]")]
        public Decimal? ProductoPrecioVentaCircuito
        {
            get { return Fields.ProductoPrecioVentaCircuito[this]; }
            set { Fields.ProductoPrecioVentaCircuito[this] = value; }
        }

        [DisplayName("Producto Cantidad Por Unidad"), Expression("jProducto.[cantidadPorUnidad]")]
        public String ProductoCantidadPorUnidad
        {
            get { return Fields.ProductoCantidadPorUnidad[this]; }
            set { Fields.ProductoCantidadPorUnidad[this] = value; }
        }

        [DisplayName("Producto Unidades En Stock"), Expression("jProducto.[unidadesEnStock]")]
        public Int16? ProductoUnidadesEnStock
        {
            get { return Fields.ProductoUnidadesEnStock[this]; }
            set { Fields.ProductoUnidadesEnStock[this] = value; }
        }

        [DisplayName("Producto Codigo Producto"), Expression("jProducto.[codigoProducto]")]
        public String ProductoCodigoProducto
        {
            get { return Fields.ProductoCodigoProducto[this]; }
            set { Fields.ProductoCodigoProducto[this] = value; }
        }

        [DisplayName("Producto Notas"), Expression("jProducto.[notas]")]
        public String ProductoNotas
        {
            get { return Fields.ProductoNotas[this]; }
            set { Fields.ProductoNotas[this] = value; }
        }

        [DisplayName("Producto Description Vista"), Expression("jProducto.[descriptionVista]")]
        public String ProductoDescriptionVista
        {
            get { return Fields.ProductoDescriptionVista[this]; }
            set { Fields.ProductoDescriptionVista[this] = value; }
        }

        [DisplayName("Producto Base"), Expression("jProducto.[base]")]
        public Decimal? ProductoBase
        {
            get { return Fields.ProductoBase[this]; }
            set { Fields.ProductoBase[this] = value; }
        }

        [DisplayName("Producto Altura"), Expression("jProducto.[altura]")]
        public Decimal? ProductoAltura
        {
            get { return Fields.ProductoAltura[this]; }
            set { Fields.ProductoAltura[this] = value; }
        }

        [DisplayName("Producto Imagenes"), Expression("jProducto.[imagenes]")]
        public String ProductoImagenes
        {
            get { return Fields.ProductoImagenes[this]; }
            set { Fields.ProductoImagenes[this] = value; }
        }

        [DisplayName("Producto Gps Latitud"), Expression("jProducto.[GPSLatitud]")]
        public String ProductoGpsLatitud
        {
            get { return Fields.ProductoGpsLatitud[this]; }
            set { Fields.ProductoGpsLatitud[this] = value; }
        }

        [DisplayName("Producto Gps Longitud"), Expression("jProducto.[GPSLongitud]")]
        public String ProductoGpsLongitud
        {
            get { return Fields.ProductoGpsLongitud[this]; }
            set { Fields.ProductoGpsLongitud[this] = value; }
        }

        [DisplayName("Producto Ubicacion"), Expression("jProducto.[ubicacion]")]
        public String ProductoUbicacion
        {
            get { return Fields.ProductoUbicacion[this]; }
            set { Fields.ProductoUbicacion[this] = value; }
        }

        [DisplayName("Producto Gps Ruta Id"), Expression("jProducto.[GPSRutaID]")]
        public Int32? ProductoGpsRutaId
        {
            get { return Fields.ProductoGpsRutaId[this]; }
            set { Fields.ProductoGpsRutaId[this] = value; }
        }

        [DisplayName("Producto Tenant Id"), Expression("jProducto.[tenantID]")]
        public Int32? ProductoTenantId
        {
            get { return Fields.ProductoTenantId[this]; }
            set { Fields.ProductoTenantId[this] = value; }
        }

        [DisplayName("Producto User Id"), Expression("jProducto.[userID]")]
        public Int32? ProductoUserId
        {
            get { return Fields.ProductoUserId[this]; }
            set { Fields.ProductoUserId[this] = value; }
        }

        [DisplayName("Producto Ultima Modificacion"), Expression("jProducto.[ultimaModificacion]")]
        public DateTime? ProductoUltimaModificacion
        {
            get { return Fields.ProductoUltimaModificacion[this]; }
            set { Fields.ProductoUltimaModificacion[this] = value; }
        }

        [DisplayName("Producto User Id Modifica"), Expression("jProducto.[userIDModifica]")]
        public Int32? ProductoUserIdModifica
        {
            get { return Fields.ProductoUserIdModifica[this]; }
            set { Fields.ProductoUserIdModifica[this] = value; }
        }

        [DisplayName("Producto Fecha Creacion"), Expression("jProducto.[fechaCreacion]")]
        public DateTime? ProductoFechaCreacion
        {
            get { return Fields.ProductoFechaCreacion[this]; }
            set { Fields.ProductoFechaCreacion[this] = value; }
        }

        [DisplayName("Producto Legal Info Id"), Expression("jProducto.[legalInfoID]")]
        public Int64? ProductoLegalInfoId
        {
            get { return Fields.ProductoLegalInfoId[this]; }
            set { Fields.ProductoLegalInfoId[this] = value; }
        }

        [DisplayName("Producto Tiene Iluminacion"), Expression("jProducto.[tieneIluminacion]")]
        public Boolean? ProductoTieneIluminacion
        {
            get { return Fields.ProductoTieneIluminacion[this]; }
            set { Fields.ProductoTieneIluminacion[this] = value; }
        }

        [DisplayName("Producto Precio Iluminacion"), Expression("jProducto.[precioIluminacion]")]
        public Decimal? ProductoPrecioIluminacion
        {
            get { return Fields.ProductoPrecioIluminacion[this]; }
            set { Fields.ProductoPrecioIluminacion[this] = value; }
        }

        [DisplayName("Producto Moneda Iluminacion Id"), Expression("jProducto.[monedaIluminacionId]")]
        public Int32? ProductoMonedaIluminacionId
        {
            get { return Fields.ProductoMonedaIluminacionId[this]; }
            set { Fields.ProductoMonedaIluminacionId[this] = value; }
        }

        [DisplayName("Producto Precio Incluye Iluminacion"), Expression("jProducto.[precioIncluyeIluminacion]")]
        public Boolean? ProductoPrecioIncluyeIluminacion
        {
            get { return Fields.ProductoPrecioIncluyeIluminacion[this]; }
            set { Fields.ProductoPrecioIncluyeIluminacion[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvSitiosContratosArrendamientoProductosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public Int64Field SitiosContratoId;
            public Int64Field ProductoId;

            public Int32Field SitiosContratoSitioId;
            public Int32Field SitiosContratoArrendadorId;
            public StringField SitiosContratoNumeroContrato;
            public Int32Field SitiosContratoTipoContratoId;
            public Int32Field SitiosContratoTipoFechaDePagoContratoId;
            public Int32Field SitiosContratoMonedaId;
            public DecimalField SitiosContratoMonto;
            public StringField SitiosContratoDocumentosDigitalizados;
            public DateTimeField SitiosContratoFechaInicial;
            public DateTimeField SitiosContratoFechaFinal;
            public DecimalField SitiosContratoPorcentajeIncrementoRenovacion;
            public Int32Field SitiosContratoTenantId;
            public Int32Field SitiosContratoUserRegistraId;
            public Int32Field SitiosContratoUserApruedaId;
            public Int32Field SitiosContratoUserId;
            public BooleanField SitiosContratoEstaAprobado;
            public StringField SitiosContratoEstatus;
            public Int64Field SitiosContratoAdendumId;

            public Int32Field ProductoSitioId;
            public StringField ProductoNombre;
            public Int32Field ProductoCategoriasSoporteEstructuraId;
            public Int32Field ProductoTiposEstructuraId;
            public Int32Field ProductoCircuitoId;
            public Int32Field ProductoEstatusId;
            public Int32Field ProductoMonedaId;
            public DecimalField ProductoPrecioVenta;
            public DecimalField ProductoPrecioVentaMinimo;
            public DecimalField ProductoPrecioVentaCircuito;
            public StringField ProductoCantidadPorUnidad;
            public Int16Field ProductoUnidadesEnStock;
            public StringField ProductoCodigoProducto;
            public StringField ProductoNotas;
            public StringField ProductoDescriptionVista;
            public DecimalField ProductoBase;
            public DecimalField ProductoAltura;
            public StringField ProductoImagenes;
            public StringField ProductoGpsLatitud;
            public StringField ProductoGpsLongitud;
            public StringField ProductoUbicacion;
            public Int32Field ProductoGpsRutaId;
            public Int32Field ProductoTenantId;
            public Int32Field ProductoUserId;
            public DateTimeField ProductoUltimaModificacion;
            public Int32Field ProductoUserIdModifica;
            public DateTimeField ProductoFechaCreacion;
            public Int64Field ProductoLegalInfoId;
            public BooleanField ProductoTieneIluminacion;
            public DecimalField ProductoPrecioIluminacion;
            public Int32Field ProductoMonedaIluminacionId;
            public BooleanField ProductoPrecioIncluyeIluminacion;

            public RowFields()
                : base("[dbo].[Inv_SitiosContratosArrendamientoProductos]")
            {
                LocalTextPrefix = "Inventario.InvSitiosContratosArrendamientoProductos";
            }
        }
    }
}