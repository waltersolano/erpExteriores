

namespace erpSoftExteriores.Inventario.Entities
{
    using General;
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Información Legal de Producto"), InstanceName("Información Legal de Producto"), TwoLevelCached]
    [ReadPermission(Administration.PermissionKeys.Inventario.ProductosLegal.Read)]
    [ModifyPermission(Administration.PermissionKeys.Inventario.ProductosLegal.Modify)]
    [InsertPermission(Administration.PermissionKeys.Inventario.ProductosLegal.Insert)]
    [UpdatePermission(Administration.PermissionKeys.Inventario.ProductosLegal.Update)]
    [DeletePermission(Administration.PermissionKeys.Inventario.ProductosLegal.Delete)]
    [LookupScript("Inventario.InvProductosLegal")]
    public sealed class InvProductosLegalRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int64? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Número Oficio"), Column("documentoUno"), Size(50), NotNull, QuickSearch, LookupInclude]
        public String DocumentoUno
        {
            get { return Fields.DocumentoUno[this]; }
            set { Fields.DocumentoUno[this] = value; }
        }

        [DisplayName("Número Permiso"), Column("documentoDos"), Size(50), LookupInclude]
        public String DocumentoDos
        {
            get { return Fields.DocumentoDos[this]; }
            set { Fields.DocumentoDos[this] = value; }
        }

        [DisplayName("Plano Catastral"), Column("documentoTres"), Size(50), LookupInclude]
        public String DocumentoTres
        {
            get { return Fields.DocumentoTres[this]; }
            set { Fields.DocumentoTres[this] = value; }
        }

        [DisplayName("Contrato OC"), Column("documentoCuatro"), Size(50), LookupInclude]
        public String DocumentoCuatro
        {
            get { return Fields.DocumentoCuatro[this]; }
            set { Fields.DocumentoCuatro[this] = value; }
        }

        [DisplayName("Otro Número de Documento"), Column("documentoCinco"), Size(50), LookupInclude]
        public String DocumentoCinco
        {
            get { return Fields.DocumentoCinco[this]; }
            set { Fields.DocumentoCinco[this] = value; }
        }

        [DisplayName("Vence"), Column("vence"), LookupInclude]
        public DateTime? Vence
        {
            get { return Fields.Vence[this]; }
            set { Fields.Vence[this] = value; }
        }

        [DisplayName("Observaciones"), Column("observaciones"), Size(100), TextAreaEditor]
        public String Observaciones
        {
            get { return Fields.Observaciones[this]; }
            set { Fields.Observaciones[this] = value; }
        }

        [DisplayName("Documentos Digitalizados"), Column("documentosDigitalizados")]
        [MultipleImageUploadEditor(FilenameFormat = "ProductosLegal/~", CopyToHistory = true, ScaleWidth = 1024, ScaleHeight = 768, AllowNonImage=true)]
        public String DocumentosDigitalizados
        {
            get { return Fields.DocumentosDigitalizados[this]; }
            set { Fields.DocumentosDigitalizados[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.DocumentoUno; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InvProductosLegalRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField DocumentoUno;
            public StringField DocumentoDos;
            public StringField DocumentoTres;
            public StringField DocumentoCuatro;
            public StringField DocumentoCinco;
            public DateTimeField Vence;
            public StringField Observaciones;
            public StringField DocumentosDigitalizados;
            public Int32Field TenantId;

            public RowFields()
                : base("[dbo].[Inv_ProductosLegal]")
            {
                LocalTextPrefix = "Inventario.InvProductosLegal";
            }
        }
    }
}