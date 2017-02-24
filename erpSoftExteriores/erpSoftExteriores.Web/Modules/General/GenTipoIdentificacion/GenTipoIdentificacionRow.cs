

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

    [ConnectionKey("Default"), DisplayName("Tipo de Identificación"), InstanceName("Tipo de Identificación"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.MantenimientoGeneral.Read)]
    [ModifyPermission(Administration.PermissionKeys.MantenimientoGeneral.Modify)]
    [InsertPermission(Administration.PermissionKeys.MantenimientoGeneral.Insert)]
    [UpdatePermission(Administration.PermissionKeys.MantenimientoGeneral.Update)]
    [DeletePermission(Administration.PermissionKeys.MantenimientoGeneral.Delete)]
    [LookupScript("General.TiposdeIdentificacion")]
    public sealed class GenTipoIdentificacionRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(100), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
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

        public GenTipoIdentificacionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Nombre;

            public RowFields()
                : base("[dbo].[Gen_TipoIdentificacion]")
            {
                LocalTextPrefix = "General.GenTipoIdentificacion";
            }
        }
    }
}