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

    [ConnectionKey("Default"), DisplayName("Contactos"), InstanceName("Contacto"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.Arrendadores.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.Arrendadores.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.Arrendadores.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.Arrendadores.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.Arrendadores.Delete)]
    [LookupScript("Inventario.ArrendadoresContactos")]
    public sealed class InvArrendadoresContactosRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Contacto"), Column("nombre"), Size(60), NotNull, QuickSearch]
        public String Nombre
        {
            get { return Fields.Nombre[this]; }
            set { Fields.Nombre[this] = value; }
        }

        [DisplayName("Telefono 1"), Column("telefono1"), Size(20), NotNull, Common.IntPhoneEditor]
        public String Telefono1
        {
            get { return Fields.Telefono1[this]; }
            set { Fields.Telefono1[this] = value; }
        }

        [DisplayName("Email"), Column("email"), Size(100), EmailEditor]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        [DisplayName("Cargo"), Column("cargo"), Size(100)]
        public String Cargo
        {
            get { return Fields.Cargo[this]; }
            set { Fields.Cargo[this] = value; }
        }

        [DisplayName("Arrendador"), InvArrendadoresEditor, Column("arrendadorID"), NotNull, ForeignKey("[dbo].[Inv_Arrendadores]", "ID"), LeftJoin("jArrendador"), TextualField("ArrendadorIdentificacion")]
        [LookupEditor(typeof(InvArrendadoresRow))]
        public Int32? ArrendadorId
        {
            get { return Fields.ArrendadorId[this]; }
            set { Fields.ArrendadorId[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Telefono2"), Column("telefono2"), Size(20), Common.IntPhoneEditor]
        public String Telefono2
        {
            get { return Fields.Telefono2[this]; }
            set { Fields.Telefono2[this] = value; }
        }

        [DisplayName("Telefono3"), Column("telefono3"), Size(20), Common.IntPhoneEditor]
        public String Telefono3
        {
            get { return Fields.Telefono3[this]; }
            set { Fields.Telefono3[this] = value; }
        }

        [DisplayName("Arrendador Identificacion"), Expression("jArrendador.[identificacion]")]
        public String ArrendadorIdentificacion
        {
            get { return Fields.ArrendadorIdentificacion[this]; }
            set { Fields.ArrendadorIdentificacion[this] = value; }
        }

        [DisplayName("Arrendador"), Expression("jArrendador.[nombre]")]
        public String ArrendadorNombre
        {
            get { return Fields.ArrendadorNombre[this]; }
            set { Fields.ArrendadorNombre[this] = value; }
        }

        [DisplayName("Arrendador Tipo Id"), Expression("jArrendador.[tipoID]")]
        public Int32? ArrendadorTipoId
        {
            get { return Fields.ArrendadorTipoId[this]; }
            set { Fields.ArrendadorTipoId[this] = value; }
        }

        [DisplayName("Arrendador Notas"), Expression("jArrendador.[notas]")]
        public String ArrendadorNotas
        {
            get { return Fields.ArrendadorNotas[this]; }
            set { Fields.ArrendadorNotas[this] = value; }
        }

        [DisplayName("Arrendador Direccion"), Expression("jArrendador.[direccion]")]
        public String ArrendadorDireccion
        {
            get { return Fields.ArrendadorDireccion[this]; }
            set { Fields.ArrendadorDireccion[this] = value; }
        }

        [DisplayName("Arrendador Emails"), Expression("jArrendador.[emails]")]
        public String ArrendadorEmails
        {
            get { return Fields.ArrendadorEmails[this]; }
            set { Fields.ArrendadorEmails[this] = value; }
        }

        [DisplayName("Arrendador Codigo Postal"), Expression("jArrendador.[codigoPostal]")]
        public String ArrendadorCodigoPostal
        {
            get { return Fields.ArrendadorCodigoPostal[this]; }
            set { Fields.ArrendadorCodigoPostal[this] = value; }
        }

        [DisplayName("Arrendador Tenant Id"), Expression("jArrendador.[tenantID]")]
        public Int32? ArrendadorTenantId
        {
            get { return Fields.ArrendadorTenantId[this]; }
            set { Fields.ArrendadorTenantId[this] = value; }
        }

        [DisplayName("Arrendador Nombre Representante"), Expression("jArrendador.[nombreRepresentante]")]
        public String ArrendadorNombreRepresentante
        {
            get { return Fields.ArrendadorNombreRepresentante[this]; }
            set { Fields.ArrendadorNombreRepresentante[this] = value; }
        }

        [DisplayName("Arrendador Identificacion Representante"), Expression("jArrendador.[identificacionRepresentante]")]
        public String ArrendadorIdentificacionRepresentante
        {
            get { return Fields.ArrendadorIdentificacionRepresentante[this]; }
            set { Fields.ArrendadorIdentificacionRepresentante[this] = value; }
        }

        [DisplayName("Arrendador Tipo Id Representante"), Expression("jArrendador.[tipoIDRepresentante]")]
        public Int32? ArrendadorTipoIdRepresentante
        {
            get { return Fields.ArrendadorTipoIdRepresentante[this]; }
            set { Fields.ArrendadorTipoIdRepresentante[this] = value; }
        }

        [DisplayName("Arrendador Website"), Expression("jArrendador.[website]")]
        public String ArrendadorWebsite
        {
            get { return Fields.ArrendadorWebsite[this]; }
            set { Fields.ArrendadorWebsite[this] = value; }
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

        public InvArrendadoresContactosRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Nombre;
            public StringField Telefono1;
            public StringField Email;
            public StringField Cargo;
            public Int32Field ArrendadorId;
            public Int32Field TenantId;
            public StringField Telefono2;
            public StringField Telefono3;

            public StringField ArrendadorIdentificacion;
            public StringField ArrendadorNombre;
            public Int32Field ArrendadorTipoId;
            public StringField ArrendadorNotas;
            public StringField ArrendadorDireccion;
            public StringField ArrendadorEmails;
            public StringField ArrendadorCodigoPostal;
            public Int32Field ArrendadorTenantId;
            public StringField ArrendadorNombreRepresentante;
            public StringField ArrendadorIdentificacionRepresentante;
            public Int32Field ArrendadorTipoIdRepresentante;
            public StringField ArrendadorWebsite;

            public RowFields()
                : base("[dbo].[Inv_ArrendadoresContactos]")
            {
                LocalTextPrefix = "Inventario.InvArrendadoresContactos";
            }
        }
    }
}