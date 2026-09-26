namespace testSerene.Modules.BackOffice.TradeOperations.RequestHandlers;

using MyRow = testSerene.Modules.BackOffice.TradeOperationsRow;
public interface ITradeOperationsDeleteHandler : IDeleteHandler<MyRow> { }

public class TradeOperationsDeleteHandler(IRequestContext context)
    : DeleteRequestHandler<MyRow>(context), ITradeOperationsDeleteHandler
{
}
