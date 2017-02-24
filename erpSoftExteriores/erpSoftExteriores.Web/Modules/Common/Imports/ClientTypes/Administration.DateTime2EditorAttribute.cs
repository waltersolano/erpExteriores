using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace erpSoftExteriores.Administration
{
    public partial class DateTime2EditorAttribute : CustomEditorAttribute
    {
        public const string Key = "erpSoftExteriores.Administration.DateTime2Editor";

        public DateTime2EditorAttribute()
            : base(Key)
        {
        }
    }
}

