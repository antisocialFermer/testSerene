namespace testSerene.Modules.BackOffice.TradeOperations.RequestHandlers;
using MyRow = testSerene.Modules.BackOffice.TradeOperationsRow;
public interface ITradeOperationsSaveHandler : ISaveHandler<MyRow> { }

public class TradeOperationsSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow>(context), ITradeOperationsSaveHandler
{
    protected override void SetInternalFields()
    {
        base.SetInternalFields();
        var tariff = Connection.TryById<TariffsRow>(Row.TradeOperationsTariffId);
        var comiss = tariff.CommissionPercent;
        if (comiss != null)
        {
            Row.TradeOperationsTotalAmount = Row.TradeOperationsVolume * Row.TradeOperationsPrice;
            Row.TradeOperationsCommissionAmount = Row.TradeOperationsTotalAmount * comiss / 100;
            Row.TradeOperationsNetAmount = Row.TradeOperationsTotalAmount - Row.TradeOperationsCommissionAmount;
        }
    }

}
