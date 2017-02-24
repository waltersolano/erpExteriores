using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace erpSoftExteriores
{
    public class AppSettingsHelper
    {
        //Codigos..
        public class codeItems
        {
            public bool? AutoGenerar { get; set; }
            public string PrefijoCodigo { get; set; }
            public int? digits { get; set; }
            public bool? IncludeYear { get; set; }
        }
    }
}