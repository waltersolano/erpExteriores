

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

    [ConnectionKey("Default"), DisplayName("Categorias"), InstanceName("Categoria"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.Estructuras.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.Estructuras.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.Estructuras.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.Estructuras.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.Estructuras.Delete)]
    [LookupScript("Inventario.CategoriasSoporteEstructura")]
    public sealed class InvCategoriasSoporteEstructuraRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(100), NotNull, QuickSearch, LookupInclude]
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Nombre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvCategoriasSoporteEstructuraRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Nombre;
            public Int32Field TenantId;

            public RowFields()
                : base("[dbo].[Inv_CategoriasSoporteEstructura]")
            {
                LocalTextPrefix = "Inventario.InvCategoriasSoporteEstructura";
            }
        }
    }
}