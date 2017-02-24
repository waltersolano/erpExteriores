

namespace erpSoftExteriores.General.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Tipo de Pago"), InstanceName("Tipo de Pago"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.General.TipodePago.Read)]
    [ModifyPermission(Administration.PermissionKeys.General.TipodePago.Modify)]
    [InsertPermission(Administration.PermissionKeys.General.TipodePago.Insert)]
    [UpdatePermission(Administration.PermissionKeys.General.TipodePago.Update)]
    [DeletePermission(Administration.PermissionKeys.General.TipodePago.Delete)]
    [LookupScript("General.TiposdePago")]
    public sealed class GenTipoPagoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Nombre"), Size(50), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Cantidad Días"), Column("cantidadDias"), NotNull]
        public Int32? CantidadDias
        {
            get { return Fields.CantidadDias[this]; }
            set { Fields.CantidadDias[this] = value; }
        }

        [DisplayName("Cantidad Meses"), Column("cantidadMeses"), NotNull, DisplayFormat("#,##0.0")]
        public Double? CantidadMeses
        {
            get { return Fields.CantidadMeses[this]; }
            set { Fields.CantidadMeses[this] = value; }
        }

        [DisplayName("Criterios"), Column("criterios"), Size(200)]
        public String Criterios
        {
            get { return Fields.Criterios[this]; }
            set { Fields.Criterios[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Nombre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GenTipoPagoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Nombre;
            public Int32Field CantidadDias;
            public DoubleField CantidadMeses;
            public StringField Criterios;
            public Int32Field TenantId;

            public RowFields()
                : base("[dbo].[Gen_TipoPago]")
            {
                LocalTextPrefix = "General.GenTipoPago";
            }
        }
    }
}