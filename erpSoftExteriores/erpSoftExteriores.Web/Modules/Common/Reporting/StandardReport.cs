
namespace erpSoftExteriores.Common
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Reporting;
    using System;
    using System.Collections.Generic;
    using erpSoftExteriores.Northwind;
    using erpSoftExteriores.Northwind.Entities;
    using Serenity.Services;
    using System.Reflection;

    [Report("Common.StandardReportDetail")]
    [ReportDesign(MVC.Views.Common.Reporting.StandardReport)]
    [RequiredPermission(PermissionKeys.General)]
    public class StandardReport : CommonIReport, ICustomizeHtmlToPdf
    {
        /*Received from post (getoptions)*/
        public Int32 ID { get; set; }
        public String includeColumns { get; set; }
        public String excludeColumns { get; set; }
        public String localTextPrefix { get; set; }
        public String title { get; set; }

        public ServiceEndpoint IncomingController { get; set; }

        public object GetData()
        {
            var data = new StandardReportData();

            if (!String.IsNullOrEmpty(includeColumns))
            {
                data.includeColumns = includeColumns.Split(',');
            }

            if (!String.IsNullOrEmpty(excludeColumns))
            {
                data.excludeColumns = excludeColumns.Split(',');
            }

            if (!String.IsNullOrEmpty(title))
            {
                data.title = title;
            }

            if (!String.IsNullOrEmpty(localTextPrefix))
            {
                data.localTextPrefix = localTextPrefix;
            }

            using (var connection = SqlConnections.NewFor<OrderRow>())
            {
                string controllerString = "erpSoftExteriores." + localTextPrefix.Replace(".", ".Endpoints.") + "Controller";
                var controller = Type.GetType(controllerString);

                var dataOrder = (Activator.CreateInstance(controller));

                var retrieveRequest = new RetrieveRequest();
                retrieveRequest.EntityId = ID;

                retrieveRequest.ExcludeColumns = new HashSet<string>
                {
                    //"Website", "TenantId","CodigoPostal"
                };

                var _connection = SqlConnections.NewByKey("Default");

                object[] callParams = new object[2];
                callParams[0] = _connection;
                callParams[1] = retrieveRequest;

                var response = controller.InvokeMember(
                    name: "Retrieve",
                    invokeAttr: BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
                    binder: null,
                    target: dataOrder,
                    args: callParams
                );


                var responseType = response.GetType();

                // get info about property: Entity
                PropertyInfo numberPropertyInfo = responseType.GetProperty("Entity");
                var entity = (Row)numberPropertyInfo.GetValue(response, null);


                data.Order = entity;
            }

            return data;
        }

        public void Customize(IHtmlToPdfOptions options)
        {
            // you may customize HTML to PDF converter (WKHTML) parameters here, e.g. 
            // options.MarginsAll = "7cm";
        }
    }

    public interface CommonIReport : Serenity.Reporting.IReport
    {
        //object GetData();
        string includeColumns { get; set; }
        ServiceEndpoint IncomingController { get; set; }
    }


    public class StandardReportData
    {
        public Row Order { get; set; }

        public String[] includeColumns { get; set; }
        public String[] excludeColumns { get; set; }
        public String localTextPrefix { get; set; }
        public String title { get; set; }
        //public List<OrderDetailRow> Details { get; set; }
        //public CustomerRow Customer { get; set; }
    }
}