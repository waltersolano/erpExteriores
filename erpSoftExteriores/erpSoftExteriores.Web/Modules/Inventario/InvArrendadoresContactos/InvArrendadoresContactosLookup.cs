
namespace erpSoftExteriores.Inventario.Scripts
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("Inventario.ArrendadorContacto")]
    public class InvArrendadoresContactosLookup : RowLookupScript<Entities.InvArrendadoresContactosRow>
    {
        public InvArrendadoresContactosLookup()
        {
            IdField = TextField = "ArrendadorNombre";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.InvArrendadoresContactosRow.Fields;
            query.Distinct(true)
                .Select(fld.ArrendadorNombre)
                .Where(
                    new Criteria(fld.ArrendadorNombre) != "" &
                    new Criteria(fld.ArrendadorNombre).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}