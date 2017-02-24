

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

    [ConnectionKey("Default"), DisplayName("Ruta"), InstanceName("Rutas"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.MantenimientoGeneral.Read)]
    [ModifyPermission(Administration.PermissionKeys.MantenimientoGeneral.Modify)]
    [InsertPermission(Administration.PermissionKeys.MantenimientoGeneral.Insert)]
    [UpdatePermission(Administration.PermissionKeys.MantenimientoGeneral.Update)]
    [DeletePermission(Administration.PermissionKeys.MantenimientoGeneral.Delete)]
    [LookupScript("General.Rutas")]
    public sealed class GenRutasRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(100), QuickSearch, LookupInclude]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Descripción"), Column("descripcion"), Size(500), TextAreaEditor]
        public String Descripcion
        {
            get { return Fields.Descripcion[this]; }
            set { Fields.Descripcion[this] = value; }
        }

        [DisplayName("Carreteras"), Column("carreteras"), Size(500), TextAreaEditor]
        public String Carreteras
        {
            get { return Fields.Carreteras[this]; }
            set { Fields.Carreteras[this] = value; }
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

        public GenRutasRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Nombre;
            public StringField Descripcion;
            public StringField Carreteras;

            public RowFields()
                : base("[dbo].[Gen_Rutas]")
            {
                LocalTextPrefix = "General.GenRutas";
            }
        }
    }
}