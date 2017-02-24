

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

    [ConnectionKey("Default"), DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N3), InstanceName(MantenimientoGeneral.DivisionesAdministrativas.N3), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.DivisionesAdministrativas.Read)]
    [ModifyPermission(Administration.PermissionKeys.DivisionesAdministrativas.Modify)]
    [InsertPermission(Administration.PermissionKeys.DivisionesAdministrativas.Insert)]
    [UpdatePermission(Administration.PermissionKeys.DivisionesAdministrativas.Update)]
    [DeletePermission(Administration.PermissionKeys.DivisionesAdministrativas.Delete)]
    [LookupScript("General.DivisionesAdministrativasN3")]
    public sealed class GenDivisionesAdministrativasN3Row : Row, IIdRow, INameRow
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

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N2), Column("divisionSuperiorN2"), NotNull, ForeignKey("[dbo].[Gen_DivisionesAdministrativasN2]", "ID"), LeftJoin("jDivisionSuperiorN2"), TextualField("DivisionSuperiorN2Codigo")]
        [LookupEditor(typeof(GenDivisionesAdministrativasN2Row))]       
        [LookupInclude]
        public Int32? DivisionSuperiorN2
        {
            get { return Fields.DivisionSuperiorN2[this]; }
            set { Fields.DivisionSuperiorN2[this] = value; }
        }

        [DisplayName("Division Superior N2 Codigo"), Expression("jDivisionSuperiorN2.[codigo]")]
        public String DivisionSuperiorN2Codigo
        {
            get { return Fields.DivisionSuperiorN2Codigo[this]; }
            set { Fields.DivisionSuperiorN2Codigo[this] = value; }
        }

        [DisplayName("Division Superior N2 Nombre"), Expression("jDivisionSuperiorN2.[nombre]")]
        public String DivisionSuperiorN2Nombre
        {
            get { return Fields.DivisionSuperiorN2Nombre[this]; }
            set { Fields.DivisionSuperiorN2Nombre[this] = value; }
        }

        [DisplayName("Division Superior N2 Division Superior N1"), Expression("jDivisionSuperiorN2.[divisionSuperiorN1]")]
        public Int32? DivisionSuperiorN2DivisionSuperiorN1
        {
            get { return Fields.DivisionSuperiorN2DivisionSuperiorN1[this]; }
            set { Fields.DivisionSuperiorN2DivisionSuperiorN1[this] = value; }
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

        public GenDivisionesAdministrativasN3Row()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Codigo;
            public StringField Nombre;
            public Int32Field DivisionSuperiorN2;

            public StringField DivisionSuperiorN2Codigo;
            public StringField DivisionSuperiorN2Nombre;
            public Int32Field DivisionSuperiorN2DivisionSuperiorN1;

            public RowFields()
                : base("[dbo].[Gen_DivisionesAdministrativasN3]")
            {
                LocalTextPrefix = "General.GenDivisionesAdministrativasN3";
            }
        }
    }
}