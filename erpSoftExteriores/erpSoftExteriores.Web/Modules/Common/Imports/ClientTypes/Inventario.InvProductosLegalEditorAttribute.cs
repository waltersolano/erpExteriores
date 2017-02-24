using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace erpSoftExteriores.Inventario
{
    public partial class InvProductosLegalEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "erpSoftExteriores.Inventario.InvProductosLegalEditor";

        public InvProductosLegalEditorAttribute()
            : base(Key)
        {
        }
    }
}

