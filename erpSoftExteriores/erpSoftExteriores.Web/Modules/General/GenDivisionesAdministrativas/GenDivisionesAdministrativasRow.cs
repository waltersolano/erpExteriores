

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

    [ConnectionKey("Default"), DisplayName("Nombre de Divisiones Administrativas"), InstanceName("Nombre de Divisiones Administrativas"), TwoLevelCached]

    //[ReadPermission("DatosGenerales")]
    //[ModifyPermission("MantenimientoGeneral")]

    [ReadPermission(Administration.PermissionKeys.DivisionesAdministrativas.Read)]
    [ModifyPermission(Administration.PermissionKeys.DivisionesAdministrativas.Modify)]
    [InsertPermission(Administration.PermissionKeys.DivisionesAdministrativas.Insert)]
    [UpdatePermission(Administration.PermissionKeys.DivisionesAdministrativas.Update)]
    [DeletePermission(Administration.PermissionKeys.DivisionesAdministrativas.Delete)]


    public sealed class GenDivisionesAdministrativasRow : Row, IIdRow, INameRow
    {
        [DisplayName("Primer Nivel"), Column("primerNivel"), Size(50), NotNull, QuickSearch]
        public String PrimerNivel
        {
            get { return Fields.PrimerNivel[this]; }
            set { Fields.PrimerNivel[this] = value; }
        }

        [DisplayName("Segundo Nivel"), Column("segundoNivel"), Size(50)]
        public String SegundoNivel
        {
            get { return Fields.SegundoNivel[this]; }
            set { Fields.SegundoNivel[this] = value; }
        }

        [DisplayName("Tercer Nivel"), Column("tercerNivel"), Size(50)]
        public String TercerNivel
        {
            get { return Fields.TercerNivel[this]; }
            set { Fields.TercerNivel[this] = value; }
        }

        [DisplayName("Cuarto Nivel"), Column("cuartoNivel"), Size(50)]
        public String CuartoNivel
        {
            get { return Fields.CuartoNivel[this]; }
            set { Fields.CuartoNivel[this] = value; }
        }

        [DisplayName("Quinto Nivel"), Column("quintoNivel"), Size(50)]
        public String QuintoNivel
        {
            get { return Fields.QuintoNivel[this]; }
            set { Fields.QuintoNivel[this] = value; }
        }

        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PrimerNivel; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GenDivisionesAdministrativasRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField PrimerNivel;
            public StringField SegundoNivel;
            public StringField TercerNivel;
            public StringField CuartoNivel;
            public StringField QuintoNivel;
            public Int32Field Id;

            public RowFields()
                : base("[dbo].[Gen_DivisionesAdministrativas]")
            {
                LocalTextPrefix = "General.GenDivisionesAdministrativas";
            }
        }
    }
}