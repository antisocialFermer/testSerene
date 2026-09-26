namespace testSerene.Modules.BackOffice.Tariffs;

[PageAuthorize(typeof(TariffsRow))]
public class TariffsPage : Controller
{
    [Route("BackOffice/Tariffs")]
    public ActionResult Index()
    {
        return this.GridPage(ESM.TariffsPage, TariffsRow.Fields.PageTitle());
    }
}
