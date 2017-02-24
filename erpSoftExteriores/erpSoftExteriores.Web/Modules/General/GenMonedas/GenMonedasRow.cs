

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

    [ConnectionKey("Default"), DisplayName("Monedas"), InstanceName("Monedas"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.MantenimientoGeneral.Read)]
    [ModifyPermission(Administration.PermissionKeys.MantenimientoGeneral.Modify)]
    [InsertPermission(Administration.PermissionKeys.MantenimientoGeneral.Insert)]
    [UpdatePermission(Administration.PermissionKeys.MantenimientoGeneral.Update)]
    [DeletePermission(Administration.PermissionKeys.MantenimientoGeneral.Delete)]
    [LookupScript("General.Monedas")]
    public sealed class GenMonedasRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(30), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Simbolo"), Column("simbolo"), Size(10), NotNull, QuickSearch, LookupInclude]
        public String Simbolo
        {
            get { return Fields.Simbolo[this]; }
            set { Fields.Simbolo[this] = value; }
        }

        [DisplayName("Codigo"), Column("codigo"), Size(10), NotNull, LookupInclude]
        public String Codigo
        {
            get { return Fields.Codigo[this]; }
            set { Fields.Codigo[this] = value; }
        }

        [DisplayName("Pais"), Column("pais"), Size(30), NotNull, LookupInclude]
        public String Pais
        {
            get { return Fields.Pais[this]; }
            set { Fields.Pais[this] = value; }
        }

        [DisplayName("Codigo Pais"), Column("codigoPais"), Size(10), NotNull]
        public String CodigoPais
        {
            get { return Fields.CodigoPais[this]; }
            set { Fields.CodigoPais[this] = value; }
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

        public GenMonedasRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Nombre;
            public StringField Simbolo;
            public StringField Codigo;
            public StringField Pais;
            public StringField CodigoPais;

            public RowFields()
                : base("[dbo].[Gen_Monedas]")
            {
                LocalTextPrefix = "General.GenMonedas";
            }
        }
    }
}