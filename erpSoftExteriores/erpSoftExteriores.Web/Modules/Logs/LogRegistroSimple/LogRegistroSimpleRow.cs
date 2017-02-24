

namespace erpSoftExteriores.Logs.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), DisplayName("Log_RegistroSimple"), InstanceName("Log_RegistroSimple"), TwoLevelCached]
    [ReadPermission("Administration")]
    [ModifyPermission("Administration")]
    public sealed class LogRegistroSimpleRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Column("ID"), Identity]
        public Int64? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Entity Type"), Size(70), NotNull, QuickSearch]
        public String EntityType
        {
            get { return Fields.EntityType[this]; }
            set { Fields.EntityType[this] = value; }
        }

        [DisplayName("Entity Id"), Column("EntityID"), NotNull]
        public Int64? EntityId
        {
            get { return Fields.EntityId[this]; }
            set { Fields.EntityId[this] = value; }
        }

        [DisplayName("Usuario Registra"), Column("UsuarioRegistraID"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUsuarioRegistra"), TextualField("UsuarioRegistraUsername")]
        public Int32? UsuarioRegistraId
        {
            get { return Fields.UsuarioRegistraId[this]; }
            set { Fields.UsuarioRegistraId[this] = value; }
        }

        [DisplayName("Fecha Registro")]
        public DateTime? FechaRegistro
        {
            get { return Fields.FechaRegistro[this]; }
            set { Fields.FechaRegistro[this] = value; }
        }

        [DisplayName("Usuario Modifica"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jUsuarioModifica"), TextualField("UsuarioModificaUsername")]
        public Int32? UsuarioModifica
        {
            get { return Fields.UsuarioModifica[this]; }
            set { Fields.UsuarioModifica[this] = value; }
        }

        [DisplayName("Fecha Modifica")]
        public DateTime? FechaModifica
        {
            get { return Fields.FechaModifica[this]; }
            set { Fields.FechaModifica[this] = value; }
        }

        [DisplayName("Texto1"), Size(1000)]
        public String Texto1
        {
            get { return Fields.Texto1[this]; }
            set { Fields.Texto1[this] = value; }
        }

        [DisplayName("Texto2"), Size(300)]
        public String Texto2
        {
            get { return Fields.Texto2[this]; }
            set { Fields.Texto2[this] = value; }
        }

        [DisplayName("Ip1"), Size(100)]
        public String Ip1
        {
            get { return Fields.Ip1[this]; }
            set { Fields.Ip1[this] = value; }
        }

        [DisplayName("Ip2"), Size(50)]
        public String Ip2
        {
            get { return Fields.Ip2[this]; }
            set { Fields.Ip2[this] = value; }
        }

        [DisplayName("Tenant Id"), Column("tenantID")]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        [DisplayName("Usuario Registra Username"), Expression("jUsuarioRegistra.[Username]")]
        public String UsuarioRegistraUsername
        {
            get { return Fields.UsuarioRegistraUsername[this]; }
            set { Fields.UsuarioRegistraUsername[this] = value; }
        }

        [DisplayName("Usuario Registra Display Name"), Expression("jUsuarioRegistra.[DisplayName]")]
        public String UsuarioRegistraDisplayName
        {
            get { return Fields.UsuarioRegistraDisplayName[this]; }
            set { Fields.UsuarioRegistraDisplayName[this] = value; }
        }

        [DisplayName("Usuario Registra Email"), Expression("jUsuarioRegistra.[Email]")]
        public String UsuarioRegistraEmail
        {
            get { return Fields.UsuarioRegistraEmail[this]; }
            set { Fields.UsuarioRegistraEmail[this] = value; }
        }

        [DisplayName("Usuario Registra Source"), Expression("jUsuarioRegistra.[Source]")]
        public String UsuarioRegistraSource
        {
            get { return Fields.UsuarioRegistraSource[this]; }
            set { Fields.UsuarioRegistraSource[this] = value; }
        }

        [DisplayName("Usuario Registra Password Hash"), Expression("jUsuarioRegistra.[PasswordHash]")]
        public String UsuarioRegistraPasswordHash
        {
            get { return Fields.UsuarioRegistraPasswordHash[this]; }
            set { Fields.UsuarioRegistraPasswordHash[this] = value; }
        }

        [DisplayName("Usuario Registra Password Salt"), Expression("jUsuarioRegistra.[PasswordSalt]")]
        public String UsuarioRegistraPasswordSalt
        {
            get { return Fields.UsuarioRegistraPasswordSalt[this]; }
            set { Fields.UsuarioRegistraPasswordSalt[this] = value; }
        }

        [DisplayName("Usuario Registra Insert Date"), Expression("jUsuarioRegistra.[InsertDate]")]
        public DateTime? UsuarioRegistraInsertDate
        {
            get { return Fields.UsuarioRegistraInsertDate[this]; }
            set { Fields.UsuarioRegistraInsertDate[this] = value; }
        }

        [DisplayName("Usuario Registra Insert User Id"), Expression("jUsuarioRegistra.[InsertUserId]")]
        public Int32? UsuarioRegistraInsertUserId
        {
            get { return Fields.UsuarioRegistraInsertUserId[this]; }
            set { Fields.UsuarioRegistraInsertUserId[this] = value; }
        }

        [DisplayName("Usuario Registra Update Date"), Expression("jUsuarioRegistra.[UpdateDate]")]
        public DateTime? UsuarioRegistraUpdateDate
        {
            get { return Fields.UsuarioRegistraUpdateDate[this]; }
            set { Fields.UsuarioRegistraUpdateDate[this] = value; }
        }

        [DisplayName("Usuario Registra Update User Id"), Expression("jUsuarioRegistra.[UpdateUserId]")]
        public Int32? UsuarioRegistraUpdateUserId
        {
            get { return Fields.UsuarioRegistraUpdateUserId[this]; }
            set { Fields.UsuarioRegistraUpdateUserId[this] = value; }
        }

        [DisplayName("Usuario Registra Is Active"), Expression("jUsuarioRegistra.[IsActive]")]
        public Int16? UsuarioRegistraIsActive
        {
            get { return Fields.UsuarioRegistraIsActive[this]; }
            set { Fields.UsuarioRegistraIsActive[this] = value; }
        }

        [DisplayName("Usuario Registra Last Directory Update"), Expression("jUsuarioRegistra.[LastDirectoryUpdate]")]
        public DateTime? UsuarioRegistraLastDirectoryUpdate
        {
            get { return Fields.UsuarioRegistraLastDirectoryUpdate[this]; }
            set { Fields.UsuarioRegistraLastDirectoryUpdate[this] = value; }
        }

        [DisplayName("Usuario Registra Tenant Id"), Expression("jUsuarioRegistra.[tenantID]")]
        public Int32? UsuarioRegistraTenantId
        {
            get { return Fields.UsuarioRegistraTenantId[this]; }
            set { Fields.UsuarioRegistraTenantId[this] = value; }
        }

        [DisplayName("Usuario Modifica Username"), Expression("jUsuarioModifica.[Username]")]
        public String UsuarioModificaUsername
        {
            get { return Fields.UsuarioModificaUsername[this]; }
            set { Fields.UsuarioModificaUsername[this] = value; }
        }

        [DisplayName("Usuario Modifica Display Name"), Expression("jUsuarioModifica.[DisplayName]")]
        public String UsuarioModificaDisplayName
        {
            get { return Fields.UsuarioModificaDisplayName[this]; }
            set { Fields.UsuarioModificaDisplayName[this] = value; }
        }

        [DisplayName("Usuario Modifica Email"), Expression("jUsuarioModifica.[Email]")]
        public String UsuarioModificaEmail
        {
            get { return Fields.UsuarioModificaEmail[this]; }
            set { Fields.UsuarioModificaEmail[this] = value; }
        }

        [DisplayName("Usuario Modifica Source"), Expression("jUsuarioModifica.[Source]")]
        public String UsuarioModificaSource
        {
            get { return Fields.UsuarioModificaSource[this]; }
            set { Fields.UsuarioModificaSource[this] = value; }
        }

        [DisplayName("Usuario Modifica Password Hash"), Expression("jUsuarioModifica.[PasswordHash]")]
        public String UsuarioModificaPasswordHash
        {
            get { return Fields.UsuarioModificaPasswordHash[this]; }
            set { Fields.UsuarioModificaPasswordHash[this] = value; }
        }

        [DisplayName("Usuario Modifica Password Salt"), Expression("jUsuarioModifica.[PasswordSalt]")]
        public String UsuarioModificaPasswordSalt
        {
            get { return Fields.UsuarioModificaPasswordSalt[this]; }
            set { Fields.UsuarioModificaPasswordSalt[this] = value; }
        }

        [DisplayName("Usuario Modifica Insert Date"), Expression("jUsuarioModifica.[InsertDate]")]
        public DateTime? UsuarioModificaInsertDate
        {
            get { return Fields.UsuarioModificaInsertDate[this]; }
            set { Fields.UsuarioModificaInsertDate[this] = value; }
        }

        [DisplayName("Usuario Modifica Insert User Id"), Expression("jUsuarioModifica.[InsertUserId]")]
        public Int32? UsuarioModificaInsertUserId
        {
            get { return Fields.UsuarioModificaInsertUserId[this]; }
            set { Fields.UsuarioModificaInsertUserId[this] = value; }
        }

        [DisplayName("Usuario Modifica Update Date"), Expression("jUsuarioModifica.[UpdateDate]")]
        public DateTime? UsuarioModificaUpdateDate
        {
            get { return Fields.UsuarioModificaUpdateDate[this]; }
            set { Fields.UsuarioModificaUpdateDate[this] = value; }
        }

        [DisplayName("Usuario Modifica Update User Id"), Expression("jUsuarioModifica.[UpdateUserId]")]
        public Int32? UsuarioModificaUpdateUserId
        {
            get { return Fields.UsuarioModificaUpdateUserId[this]; }
            set { Fields.UsuarioModificaUpdateUserId[this] = value; }
        }

        [DisplayName("Usuario Modifica Is Active"), Expression("jUsuarioModifica.[IsActive]")]
        public Int16? UsuarioModificaIsActive
        {
            get { return Fields.UsuarioModificaIsActive[this]; }
            set { Fields.UsuarioModificaIsActive[this] = value; }
        }

        [DisplayName("Usuario Modifica Last Directory Update"), Expression("jUsuarioModifica.[LastDirectoryUpdate]")]
        public DateTime? UsuarioModificaLastDirectoryUpdate
        {
            get { return Fields.UsuarioModificaLastDirectoryUpdate[this]; }
            set { Fields.UsuarioModificaLastDirectoryUpdate[this] = value; }
        }

        [DisplayName("Usuario Modifica Tenant Id"), Expression("jUsuarioModifica.[tenantID]")]
        public Int32? UsuarioModificaTenantId
        {
            get { return Fields.UsuarioModificaTenantId[this]; }
            set { Fields.UsuarioModificaTenantId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.EntityType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LogRegistroSimpleRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field Id;
            public StringField EntityType;
            public Int64Field EntityId;
            public Int32Field UsuarioRegistraId;
            public DateTimeField FechaRegistro;
            public Int32Field UsuarioModifica;
            public DateTimeField FechaModifica;
            public StringField Texto1;
            public StringField Texto2;
            public StringField Ip1;
            public StringField Ip2;
            public Int32Field TenantId;

            public StringField UsuarioRegistraUsername;
            public StringField UsuarioRegistraDisplayName;
            public StringField UsuarioRegistraEmail;
            public StringField UsuarioRegistraSource;
            public StringField UsuarioRegistraPasswordHash;
            public StringField UsuarioRegistraPasswordSalt;
            public DateTimeField UsuarioRegistraInsertDate;
            public Int32Field UsuarioRegistraInsertUserId;
            public DateTimeField UsuarioRegistraUpdateDate;
            public Int32Field UsuarioRegistraUpdateUserId;
            public Int16Field UsuarioRegistraIsActive;
            public DateTimeField UsuarioRegistraLastDirectoryUpdate;
            public Int32Field UsuarioRegistraTenantId;

            public StringField UsuarioModificaUsername;
            public StringField UsuarioModificaDisplayName;
            public StringField UsuarioModificaEmail;
            public StringField UsuarioModificaSource;
            public StringField UsuarioModificaPasswordHash;
            public StringField UsuarioModificaPasswordSalt;
            public DateTimeField UsuarioModificaInsertDate;
            public Int32Field UsuarioModificaInsertUserId;
            public DateTimeField UsuarioModificaUpdateDate;
            public Int32Field UsuarioModificaUpdateUserId;
            public Int16Field UsuarioModificaIsActive;
            public DateTimeField UsuarioModificaLastDirectoryUpdate;
            public Int32Field UsuarioModificaTenantId;

            public RowFields()
                : base("[dbo].[Log_RegistroSimple]")
            {
                LocalTextPrefix = "Logs.LogRegistroSimple";
            }
        }
    }
}