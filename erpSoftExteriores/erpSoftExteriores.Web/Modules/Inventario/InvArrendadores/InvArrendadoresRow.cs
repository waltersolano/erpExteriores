
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
    using General.Entities;

    [ConnectionKey("Default"), DisplayName("Arrendadores"), InstanceName("Arrendador"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.Arrendadores.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.Arrendadores.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.Arrendadores.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.Arrendadores.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.Arrendadores.Delete)]
    [LookupScript("Inventario.Arrendadores")]
    public sealed class InvArrendadoresRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Identificacion"), Column("identificacion"), Size(100), NotNull, QuickSearch, LookupInclude]
        public String Identificacion
        {
            get { return Fields.Identificacion[this]; }
            set { Fields.Identificacion[this] = value; }
        }

        [DisplayName("Nombre"), Column("nombre"), Size(100), NotNull, LookupInclude]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Tipo de Identificación"), Expression("jTipo.[nombre]")]
        public String TipoNombre
        {
            get { return Fields.TipoNombre[this]; }
            set { Fields.TipoNombre[this] = value; }
        }

        [DisplayName("Tipo de Indentificación"), Column("tipoID"), NotNull, ForeignKey("[dbo].[Gen_TipoIdentificacion]", "ID"), LeftJoin("jTipo"), TextualField("TipoNombre")]
        [LookupEditor(typeof(GenTipoIdentificacionRow))]
        public Int32? TipoId
        {
            get { return Fields.TipoId[this]; }
            set { Fields.TipoId[this] = value; }
        }

        [DisplayName("Notas"), Column("notas"), Size(200)]
        public String Notas
        {
            get { return Fields.Notas[this]; }
            set { Fields.Notas[this] = value; }
        }

        [DisplayName("Direccion"), Column("direccion"), Size(200), NotNull]
        public String Direccion
        {
            get { return Fields.Direccion[this]; }
            set { Fields.Direccion[this] = value; }
        }

        [DisplayName("Email para Notificaciones"), Column("emails"), Size(100), EmailEditor, NotNull]
        public String Emails
        {
            get { return Fields.Emails[this]; }
            set { Fields.Emails[this] = value; }
        }

        [DisplayName("Codigo Postal"), Column("codigoPostal"), Size(50)]
        public String CodigoPostal
        {
            get { return Fields.CodigoPostal[this]; }
            set { Fields.CodigoPostal[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Nombre del Representante Legal"), Column("nombreRepresentante"), Size(100)]
        public String NombreRepresentante
        {
            get { return Fields.NombreRepresentante[this]; }
            set { Fields.NombreRepresentante[this] = value; }
        }

        [DisplayName("Identificación del Representante Legal"), Column("identificacionRepresentante"), Size(100)]
        public String IdentificacionRepresentante
        {
            get { return Fields.IdentificacionRepresentante[this]; }
            set { Fields.IdentificacionRepresentante[this] = value; }
        }

        [DisplayName("Tipo de Identificación del Representante"), Column("tipoIDRepresentante"), ForeignKey("[dbo].[Gen_TipoIdentificacion]", "ID"), LeftJoin("jTipoIdRepresentante"), TextualField("TipoIdRepresentanteNombre")]
        [LookupEditor(typeof(GenTipoIdentificacionRow))]
        public Int32? TipoIdRepresentante
        {
            get { return Fields.TipoIdRepresentante[this]; }
            set { Fields.TipoIdRepresentante[this] = value; }
        }

        [DisplayName("Website"), Column("website"), Size(50), URLEditor]
        public String Website
        {
            get { return Fields.Website[this]; }
            set { Fields.Website[this] = value; }
        }

        [DisplayName("Tipo de Identificación"), Expression("jTipoIdRepresentante.[nombre]")]
        public String TipoIdRepresentanteNombre
        {
            get { return Fields.TipoIdRepresentanteNombre[this]; }
            set { Fields.TipoIdRepresentanteNombre[this] = value; }
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

        public InvArrendadoresRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Identificacion;
            public StringField Nombre;
            public Int32Field TipoId;
            public StringField Notas;
            public StringField Direccion;
            public StringField Emails;
            public StringField CodigoPostal;
            public Int32Field TenantId;
            public StringField NombreRepresentante;
            public StringField IdentificacionRepresentante;
            public Int32Field TipoIdRepresentante;
            public StringField Website;

            public StringField TipoNombre;

            public StringField TipoIdRepresentanteNombre;

            public RowFields()
                : base("[dbo].[Inv_Arrendadores]")
            {
                LocalTextPrefix = "Inventario.InvArrendadores";
            }
        }
    }
}