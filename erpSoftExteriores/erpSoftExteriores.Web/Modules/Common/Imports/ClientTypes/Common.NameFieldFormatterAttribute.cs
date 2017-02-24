using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace erpSoftExteriores.Common
{
    public partial class NameFieldFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "erpSoftExteriores.Common.NameFieldFormatter";

        public NameFieldFormatterAttribute()
            : base(Key)
        {
        }
    }
}

