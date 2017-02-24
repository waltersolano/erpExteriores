using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace erpSoftExteriores.Inventario
{
    public partial class InvArrendadoresFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "erpSoftExteriores.Inventario.InvArrendadoresFormatter";

        public InvArrendadoresFormatterAttribute()
            : base(Key)
        {
        }
    }
}

