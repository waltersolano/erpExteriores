using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using erpSoftExteriores.General.Endpoints;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;
using MyRepository = erpSoftExteriores.General.Repositories.GenDivisionesAdministrativasRepository;
using MyRow = erpSoftExteriores.General.Entities.GenDivisionesAdministrativasRow;

namespace erpSoftExteriores.MantenimientoGeneral
{

    
    public static class DivisionesAdministrativas
    {

/*
         * Actualizar tambien en texts.cs
         * 
         */
        public const string N1 = "Provincia";
        public const string N2 = "Cantón";
        public const string N3 = "Distrito";
        public const string N4 = "--Nivel--";
        public const string N5 = "--Nivel--";

        public static string GetNombres(string nivel)
        {
            //var connection = SqlConnections.NewFor<GenDivisionesAdministrativasRow>();
            var connection = SqlConnections.NewByKey("Default");
            var request = new Serenity.Services.ListRequest();
            var response = new MyRepository().List(connection, request);


            switch (nivel)
            {
                case "":
                    return "Nivel División Superior";

                case "N1":
                    return response.Entities[0].PrimerNivel;

                case "N2":
                    return response.Entities[0].SegundoNivel;

                case "N3":
                    return response.Entities[0].TercerNivel;

                case "N4":
                    return response.Entities[0].CuartoNivel;

                case "N5":
                    return response.Entities[0].QuintoNivel;

                default:
                    return "Nivel División Superior";

            }
        }

        public static string GetNombreN1()
        {
            //var connection = SqlConnections.NewFor<GenDivisionesAdministrativasRow>();
            var connection = SqlConnections.NewByKey("Default");
            var request = new Serenity.Services.ListRequest();
            var response = new MyRepository().List(connection, request);
            return response.Entities[0].PrimerNivel;
        }


    }
}