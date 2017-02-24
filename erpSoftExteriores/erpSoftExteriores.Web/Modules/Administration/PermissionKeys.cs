
[assembly: Serenity.ComponentModel.RegisterPermissionKey(erpSoftExteriores.Administration.PermissionKeys.PaginaMantenimientoGeneral)]
[assembly: Serenity.ComponentModel.RegisterPermissionKey("AdministradorDeSistema")]
[assembly: Serenity.ComponentModel.RegisterPermissionKey("DatosGenerales")]




namespace erpSoftExteriores.Administration
{
    /// <summary>
    /// This class contains some permission key constants solely for
    /// easy access and intellisense purposes.
    /// 
    /// Please note that adding a permission here won't show it
    /// in user permissions dialog. In fact, Serenity doesn't
    /// care about this class at all.
    /// 
    /// To show a new permission in user/role permission dialog, just use
    /// its string key with ReadPermission / ModifyPermission / 
    /// DeletePermission / PageAuthorize / ServiceAuthorize etc. attributes 
    /// and Serenity will auto discover them at application start.
    /// 
    /// Permission tree hierarchy in dialog is determined by colons (:)
    /// in permission keys.
    /// 
    /// [assembly: Serenity.ComponentModel.RegisterPermissionKey("DatosGenerales")]
    /// </summary>
    /// 

    public class PermissionKeys
    {
        public const string Security = "Administration:Security";
        public const string Translation = "Administration:Translation";
        public const string PaginaMantenimientoGeneral = "General:PaginaMantenimientoGeneral";
        public const string PaginaDivisionAdministrativaN1 = "General:MantenimientoGeneral:PaginaDivisionAdministrativaN1";
        public const string PaginaDivisionAdministrativaN2 = "General:MantenimientoGeneral:PaginaDivisionAdministrativaN2";
        public const string PaginaDivisionAdministrativaN3 = "General:MantenimientoGeneral:PaginaDivisionAdministrativaN3";
        public const string PaginaDivisionAdministrativaN4 = "General:MantenimientoGeneral:PaginaDivisionAdministrativaN4";
        public const string PaginaDivisionAdministrativaN5 = "General:MantenimientoGeneral:PaginaDivisionAdministrativaN5";

        public class MantenimientoGeneral
        {          
            public const string Modify = "General:MantenimientoGeneral:Modificar";
            public const string Read = "General:MantenimientoGeneral:Leer";
            public const string Insert = "General:MantenimientoGeneral:Insertar";
            public const string Update = "General:MantenimientoGeneral:Actualizar";
            public const string Delete = "General:MantenimientoGeneral:Borrar";
        }

        public class DivisionesAdministrativas
        {
            public const string Modify = "General:MantenimientoGeneral:DivisionesAdministrativas:Modificar";
            public const string Read = "General:MantenimientoGeneral:DivisionesAdministrativas:Leer";
            public const string Insert = "General:MantenimientoGeneral:DivisionesAdministrativas:Insertar";
            public const string Update = "General:MantenimientoGeneral:DivisionesAdministrativas:Actualizar";
            public const string Delete = "General:MantenimientoGeneral:DivisionesAdministrativas:Borrar";
        }

        public class General {
            public class Notas
            {
                public const string Modify = "General:Notas:Modificar";
                public const string Read = "General:Notas:Leer";
                public const string Insert = "General:Notas:Insertar";
                public const string Update = "General:Notas:Actualizar";
                public const string Delete = "General:Notas:Borrar";
            }

            public class TipodePago
            {
                public const string Modify = "General:TipodePago:Modificar";
                public const string Read = "General:TipodePago:Leer";
                public const string Insert = "General:TipodePago:Insertar";
                public const string Update = "General:TipodePago:Actualizar";
                public const string Delete = "General:TipodePago:Borrar";
            }

        }

        public class Inventario
        {
            public const string ArrendadoresPage = "Inventario:PaginaArrendadores";
            public const string EstructurasPage = "Inventario:PaginaEstructuras";
            public const string ProductosPage = "Inventario:PaginaProductos";
            public const string SitiosPage = "Inventario:PaginaSitios";
            public const string ContratosArrendamientoPage = "Inventario:PaginaContratos";
            public const string StatusPage = "Inventario:Status";

            public class Arrendadores
            {
                public const string Modify = "Inventario:Arrendadores:Modificar";
                public const string Read = "Inventario:Arrendadores:Leer";
                public const string Insert = "Inventario:Arrendadores:Insertar";
                public const string Update = "Inventario:Arrendadores:Actualizar";
                public const string Delete = "Inventario:Arrendadores:Borrar";
            }

            public class Sitios
            {
                public const string Modify = "Inventario:Sitios:Modificar";
                public const string Read = "Inventario:Sitios:Leer";
                public const string Insert = "Inventario:Sitios:Insertar";
                public const string Update = "Inventario:Sitios:Actualizar";
                public const string Delete = "Inventario:Sitios:Borrar";
            }

            public class Status
            {
                public const string Modify = "Inventario:Sitios:Modificar";
                public const string Read = "Inventario:Sitios:Leer";
                public const string Insert = "Inventario:Sitios:Insertar";
                public const string Update = "Inventario:Sitios:Actualizar";
                public const string Delete = "Inventario:Sitios:Borrar";
            }

            public class ContratosArrendamiento
            {
                public const string Modify = "Inventario:ContratosArrendamiento:Modificar";
                public const string Read = "Inventario:ContratosArrendamiento:Leer";
                public const string Insert = "Inventario:ContratosArrendamiento:Insertar";
                public const string Update = "Inventario:ContratosArrendamiento:Actualizar";
                public const string Delete = "Inventario:ContratosArrendamiento:Borrar";
            }

            public class Productos
            {
                public const string Modify = "Inventario:Productos:Modificar";
                public const string Read = "Inventario:Productos:Leer";
                public const string Insert = "Inventario:Productos:Insertar";
                public const string Update = "Inventario:Productos:Actualizar";
                public const string Delete = "Inventario:Productos:Borrar";
            }

            public class ProductosLegal
            {
                public const string Modify = "Inventario:ProductosLegal:Modificar";
                public const string Read = "Inventario:ProductosLegal:Leer";
                public const string Insert = "Inventario:ProductosLegal:Insertar";
                public const string Update = "Inventario:ProductosLegal:Actualizar";
                public const string Delete = "Inventario:ProductosLegal:Borrar";
            }

            public class Estructuras
            {
                public const string Modify = "Inventario:Productos:Modificar";
                public const string Read = "Inventario:Productos:Leer";
                public const string Insert = "Inventario:Productos:Insertar";
                public const string Update = "Inventario:Productos:Actualizar";
                public const string Delete = "Inventario:Productos:Borrar";
            }


        }

    }
}
