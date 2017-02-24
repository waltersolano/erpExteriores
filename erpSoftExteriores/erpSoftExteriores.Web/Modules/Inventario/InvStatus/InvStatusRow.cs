

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

    [ConnectionKey("Default"), DisplayName("Status"), InstanceName("Status"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.Status.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.Status.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.Status.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.Status.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.Status.Delete)]
    [LookupScript("Inventario.Status")]
    public sealed class InvStatusRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int64? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(50), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Criterios"), Column("criterios"), Size(200)]
        public String Criterios
        {
            get { return Fields.Criterios[this]; }
            set { Fields.Criterios[this] = value; }
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

        public InvStatusRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField Nombre;
            public Int32Field TenantId;
            public StringField Criterios;

            public RowFields()
                : base("[dbo].[Inv_Status]")
            {
                LocalTextPrefix = "Inventario.InvStatus";
            }
        }
    }
}