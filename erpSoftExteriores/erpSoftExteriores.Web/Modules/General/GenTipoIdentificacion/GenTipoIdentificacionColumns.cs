﻿
namespace erpSoftExteriores.General.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("General.GenTipoIdentificacion")]
    [BasedOnRow(typeof(Entities.GenTipoIdentificacionRow))]
    public class GenTipoIdentificacionColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String Nombre { get; set; }
    }
}