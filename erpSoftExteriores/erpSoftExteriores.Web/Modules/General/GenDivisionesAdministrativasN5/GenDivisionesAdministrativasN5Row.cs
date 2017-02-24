

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

    [ConnectionKey("Default"), DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N5), InstanceName(MantenimientoGeneral.DivisionesAdministrativas.N5), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.DivisionesAdministrativas.Read)]
    [ModifyPermission(Administration.PermissionKeys.DivisionesAdministrativas.Modify)]
    [InsertPermission(Administration.PermissionKeys.DivisionesAdministrativas.Insert)]
    [UpdatePermission(Administration.PermissionKeys.DivisionesAdministrativas.Update)]
    [DeletePermission(Administration.PermissionKeys.DivisionesAdministrativas.Delete)]
    [LookupScript("General.DivisionesAdministrativasN5")]
    public sealed class GenDivisionesAdministrativasN5Row : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(50), NotNull]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Código"), Column("codigo"), Size(25), QuickSearch]
        public String Codigo
        {
            get { return Fields.Codigo[this]; }
            set { Fields.Codigo[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N4), Column("divisionSuperiorN4"), NotNull, ForeignKey("[dbo].[Gen_DivisionesAdministrativasN4]", "ID"), LeftJoin("jDivisionSuperiorN4"), TextualField("DivisionSuperiorN4Codigo")]
        [LookupEditor(typeof(GenDivisionesAdministrativasN4Row))]
        [LookupInclude]
        public Int32? DivisionSuperiorN4
        {
            get { return Fields.DivisionSuperiorN4[this]; }
            set { Fields.DivisionSuperiorN4[this] = value; }
        }

        [DisplayName("Division Superior N4 Codigo"), Expression("jDivisionSuperiorN4.[codigo]")]
        public String DivisionSuperiorN4Codigo
        {
            get { return Fields.DivisionSuperiorN4Codigo[this]; }
            set { Fields.DivisionSuperiorN4Codigo[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N4), Expression("jDivisionSuperiorN4.[nombre]")]
        public String DivisionSuperiorN4Nombre
        {
            get { return Fields.DivisionSuperiorN4Nombre[this]; }
            set { Fields.DivisionSuperiorN4Nombre[this] = value; }
        }

        [DisplayName("Division Superior N4 Division Superior N3"), Expression("jDivisionSuperiorN4.[divisionSuperiorN3]")]
        public Int32? DivisionSuperiorN4DivisionSuperiorN3
        {
            get { return Fields.DivisionSuperiorN4DivisionSuperiorN3[this]; }
            set { Fields.DivisionSuperiorN4DivisionSuperiorN3[this] = value; }
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

        public GenDivisionesAdministrativasN5Row()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Codigo;
            public StringField Nombre;
            public Int32Field DivisionSuperiorN4;

            public StringField DivisionSuperiorN4Codigo;
            public StringField DivisionSuperiorN4Nombre;
            public Int32Field DivisionSuperiorN4DivisionSuperiorN3;

            public RowFields()
                : base("[dbo].[Gen_DivisionesAdministrativasN5]")
            {
                LocalTextPrefix = "General.GenDivisionesAdministrativasN5";
            }
        }
    }
}