

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

    [ConnectionKey("Default"), DisplayName("Tipos de Estructura"), InstanceName("Tipos de Estructura"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.Estructuras.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.Estructuras.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.Estructuras.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.Estructuras.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.Estructuras.Delete)]
    [LookupScript("Inventario.TiposEstructura")]
    public sealed class InvTiposEstructuraRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Categoría"), Column("categoriasSoporteEstructuraID"),LookupInclude, NotNull, ForeignKey("[dbo].[Inv_CategoriasSoporteEstructura]", "ID"), LeftJoin("jCategoriasSoporteEstructura"), TextualField("CategoriasSoporteEstructuraNombre")]
        [LookupEditor(typeof(InvCategoriasSoporteEstructuraRow))]
        public Int32? CategoriasSoporteEstructuraId
        {
            get { return Fields.CategoriasSoporteEstructuraId[this]; }
            set { Fields.CategoriasSoporteEstructuraId[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(100), NotNull, QuickSearch, LookupInclude]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Nombre; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvTiposEstructuraRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field CategoriasSoporteEstructuraId;
            public Int32Field TenantId;
            public StringField Nombre;

            public StringField CategoriasSoporteEstructuraNombre;
            public Int32Field CategoriasSoporteEstructuraTenantId;

            public RowFields()
                : base("[dbo].[Inv_TiposEstructura]")
            {
                LocalTextPrefix = "Inventario.InvTiposEstructura";
            }
        }
    }
}