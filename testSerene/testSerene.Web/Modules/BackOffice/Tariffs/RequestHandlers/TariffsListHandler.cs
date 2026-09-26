using MyRow = testSerene.Modules.BackOffice.TariffsRow;
namespace testSerene.Modules.BackOffice.Tariffs.RequestHandlers;

public interface ITariffsListHandler : IListHandler<MyRow> { }
public class TariffsListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), ITariffsListHandler
{
}
