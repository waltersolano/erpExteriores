

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

    [ConnectionKey("Default"), DisplayName(MantenimientoGeneral.DivisionesAdministrativas.N1), InstanceName(MantenimientoGeneral.DivisionesAdministrativas.N1), TwoLevelCached]

    [ReadPermission(Administration.PermissionKeys.DivisionesAdministrativas.Read)]
    [ModifyPermission(Administration.PermissionKeys.DivisionesAdministrativas.Modify)]
    [InsertPermission(Administration.PermissionKeys.DivisionesAdministrativas.Insert)]
    [UpdatePermission(Administration.PermissionKeys.DivisionesAdministrativas.Update)]
    [DeletePermission(Administration.PermissionKeys.DivisionesAdministrativas.Delete)]
    [LookupScript("General.DivisionesAdministrativasN1")]
    public sealed class GenDivisionesAdministrativasN1Row : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(25), NotNull, QuickSearch, LookupInclude]
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

        [DisplayName("Division Superior"), Column("divisionSuperior")]
        public Int32? DivisionSuperior
        {
            get { return Fields.DivisionSuperior[this]; }
            set { Fields.DivisionSuperior[this] = value; }
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

        public GenDivisionesAdministrativasN1Row()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Codigo;
            public StringField Nombre;
            public Int32Field DivisionSuperior;

            public RowFields()
                : base("[dbo].[Gen_DivisionesAdministrativasN1]")
            {
                LocalTextPrefix = "General.GenDivisionesAdministrativasN1";
            }
        }
    }
}