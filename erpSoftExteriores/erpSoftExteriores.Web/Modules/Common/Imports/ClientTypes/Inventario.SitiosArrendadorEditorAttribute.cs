using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace erpSoftExteriores.Inventario
{
    public partial class SitiosArrendadorEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "erpSoftExteriores.Inventario.SitiosArrendadorEditor";

        public SitiosArrendadorEditorAttribute()
            : base(Key)
        {
        }
    }
}

