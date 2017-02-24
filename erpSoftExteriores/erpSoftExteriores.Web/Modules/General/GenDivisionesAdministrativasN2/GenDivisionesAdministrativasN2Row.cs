

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
    //using erpSoftExteriores.General.Endpoints;

    [ConnectionKey("Default"), DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N2), InstanceName(MantenimientoGeneral.DivisionesAdministrativas.N2), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.DivisionesAdministrativas.Read)]
    [ModifyPermission(Administration.PermissionKeys.DivisionesAdministrativas.Modify)]
    [InsertPermission(Administration.PermissionKeys.DivisionesAdministrativas.Insert)]
    [UpdatePermission(Administration.PermissionKeys.DivisionesAdministrativas.Update)]
    [DeletePermission(Administration.PermissionKeys.DivisionesAdministrativas.Delete)]
    [LookupScript("General.DivisionesAdministrativasN2")]
    public sealed class GenDivisionesAdministrativasN2Row : Row, IIdRow, INameRow
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

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N1), Column("divisionSuperiorN1"), NotNull, ForeignKey("[dbo].[Gen_DivisionesAdministrativasN1]", "ID"), LeftJoin("jDivisionSuperiorN1"), TextualField("DivisionSuperiorN1Codigo")]
        [LookupEditor(typeof(GenDivisionesAdministrativasN1Row))]
        [LookupInclude]
        public Int32? DivisionSuperiorN1
        {
            get { return Fields.DivisionSuperiorN1[this]; }
            set { Fields.DivisionSuperiorN1[this] = value; }
        }

        [DisplayName("Division Superior N1 Codigo"), Expression("jDivisionSuperiorN1.[codigo]")]
        public String DivisionSuperiorN1Codigo
        {
            get { return Fields.DivisionSuperiorN1Codigo[this]; }
            set { Fields.DivisionSuperiorN1Codigo[this] = value; }
        }

        [DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N1), Expression("jDivisionSuperiorN1.[nombre]")]
        public String DivisionSuperiorN1Nombre
        {
            get { return Fields.DivisionSuperiorN1Nombre[this]; }
            set { Fields.DivisionSuperiorN1Nombre[this] = value; }
        }

        [DisplayName("Division Superior N1 Division Superior"), Expression("jDivisionSuperiorN1.[divisionSuperior]")]
        public Int32? DivisionSuperiorN1DivisionSuperior
        {
            get { return Fields.DivisionSuperiorN1DivisionSuperior[this]; }
            set { Fields.DivisionSuperiorN1DivisionSuperior[this] = value; }
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

        public GenDivisionesAdministrativasN2Row()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Codigo;
            public StringField Nombre;
            public Int32Field DivisionSuperiorN1;

            public StringField DivisionSuperiorN1Codigo;
            public StringField DivisionSuperiorN1Nombre;
            public Int32Field DivisionSuperiorN1DivisionSuperior;

            public RowFields()
                : base("[dbo].[Gen_DivisionesAdministrativasN2]")
            {
                LocalTextPrefix = "General.GenDivisionesAdministrativasN2";
            }
        }
    }
}