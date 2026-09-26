using MyRow = testSerene.Modules.BackOffice.TariffsRow;
namespace testSerene.Modules.BackOffice.Tariffs.RequestHandlers;

public interface ITariffsRetrieveHandler :IRetrieveHandler<MyRow> { }
public class TariffsRetrieveHandler(IRequestContext context)
    :RetrieveRequestHandler<MyRow>(context), ITariffsRetrieveHandler
{
}
