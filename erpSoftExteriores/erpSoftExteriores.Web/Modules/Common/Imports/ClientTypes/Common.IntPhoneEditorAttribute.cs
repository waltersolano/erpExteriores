using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace erpSoftExteriores.Common
{
    public partial class IntPhoneEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "erpSoftExteriores.Common.IntPhoneEditor";

        public IntPhoneEditorAttribute()
            : base(Key)
        {
        }
    }
}

