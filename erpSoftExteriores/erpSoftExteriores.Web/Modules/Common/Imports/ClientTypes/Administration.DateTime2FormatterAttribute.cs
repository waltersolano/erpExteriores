using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace erpSoftExteriores.Administration
{
    public partial class DateTime2FormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "erpSoftExteriores.Administration.DateTime2Formatter";

        public DateTime2FormatterAttribute()
            : base(Key)
        {
        }
    }
}

