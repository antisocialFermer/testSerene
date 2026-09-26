using MyRow = testSerene.Modules.BackOffice.TariffsRow;
namespace testSerene.Modules.BackOffice.Tariffs.RequestHandlers;

public interface ITariffsDeleteHandler : IDeleteHandler<MyRow> { }

public class TariffsDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), ITariffsDeleteHandler
{
}
