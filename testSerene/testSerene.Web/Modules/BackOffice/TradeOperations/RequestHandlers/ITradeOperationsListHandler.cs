namespace testSerene.Modules.BackOffice.TradeOperations.RequestHandlers;

using MyRow = testSerene.Modules.BackOffice.TradeOperationsRow;
public interface ITradeOperationsListHandler : IListHandler<MyRow> { }

public class TradeOperationsListHandler(IRequestContext context)
    : ListRequestHandler<MyRow>(context), ITradeOperationsListHandler
{
}
