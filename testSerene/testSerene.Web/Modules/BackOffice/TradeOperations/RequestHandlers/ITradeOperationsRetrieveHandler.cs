using MyRow = testSerene.Modules.BackOffice.TradeOperationsRow;
public interface ITradeOperationsRetrieveHandler : IRetrieveHandler<MyRow> { }

public class TradeOperationsRetrieveHandler(IRequestContext context)
    : RetrieveRequestHandler<MyRow>(context), ITradeOperationsRetrieveHandler
{
}
