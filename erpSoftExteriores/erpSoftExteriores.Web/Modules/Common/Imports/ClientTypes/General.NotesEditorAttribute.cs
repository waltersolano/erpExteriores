using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace erpSoftExteriores.General
{
    public partial class NotesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "erpSoftExteriores.General.NotesEditor";

        public NotesEditorAttribute()
            : base(Key)
        {
        }
    }
}

