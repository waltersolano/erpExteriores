

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

    [ConnectionKey("Default"), DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N4), InstanceName(MantenimientoGeneral.DivisionesAdministrativas.N4), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.DivisionesAdministrativas.Read)]
    [ModifyPermission(Administration.PermissionKeys.DivisionesAdministrativas.Modify)]
    [InsertPermission(Administration.PermissionKeys.DivisionesAdministrativas.Insert)]
    [UpdatePermission(Administration.PermissionKeys.DivisionesAdministrativas.Update)]
    [DeletePermission(Administration.PermissionKeys.DivisionesAdministrativas.Delete)]
    [LookupScript("General.DivisionesAdministrativasN4")]
    public sealed class GenDivisionesAdministrativasN4Row : Row, IIdRow, INameRow
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

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N3), Column("divisionSuperiorN3"), NotNull, ForeignKey("[dbo].[Gen_DivisionesAdministrativasN3]", "ID"), LeftJoin("jDivisionSuperiorN3"), TextualField("DivisionSuperiorN3Codigo")]
        [LookupEditor(typeof(GenDivisionesAdministrativasN3Row))]
        [LookupInclude]
        public Int32? DivisionSuperiorN3
        {
            get { return Fields.DivisionSuperiorN3[this]; }
            set { Fields.DivisionSuperiorN3[this] = value; }
        }

        [DisplayName("Division Superior N3 Codigo"), Expression("jDivisionSuperiorN3.[codigo]")]
        public String DivisionSuperiorN3Codigo
        {
            get { return Fields.DivisionSuperiorN3Codigo[this]; }
            set { Fields.DivisionSuperiorN3Codigo[this] = value; }
        }

        [DisplayName("Division Superior N3 Nombre"), Expression("jDivisionSuperiorN3.[nombre]")]
        public String DivisionSuperiorN3Nombre
        {
            get { return Fields.DivisionSuperiorN3Nombre[this]; }
            set { Fields.DivisionSuperiorN3Nombre[this] = value; }
        }

        [DisplayName("Division Superior N3 Division Superior N2"), Expression("jDivisionSuperiorN3.[divisionSuperiorN2]")]
        public Int32? DivisionSuperiorN3DivisionSuperiorN2
        {
            get { return Fields.DivisionSuperiorN3DivisionSuperiorN2[this]; }
            set { Fields.DivisionSuperiorN3DivisionSuperiorN2[this] = value; }
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

        public GenDivisionesAdministrativasN4Row()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Codigo;
            public StringField Nombre;
            public Int32Field DivisionSuperiorN3;

            public StringField DivisionSuperiorN3Codigo;
            public StringField DivisionSuperiorN3Nombre;
            public Int32Field DivisionSuperiorN3DivisionSuperiorN2;

            public RowFields()
                : base("[dbo].[Gen_DivisionesAdministrativasN4]")
            {
                LocalTextPrefix = "General.GenDivisionesAdministrativasN4";
            }
        }
    }
}