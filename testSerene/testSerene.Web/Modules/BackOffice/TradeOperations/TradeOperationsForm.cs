namespace testSerene.Modules.BackOffice;

[FormScript("BackOffice.TradeOperation")]
[BasedOnRow(typeof(TradeOperationsRow), CheckNames = true)]
public class TradeOperationsForm
{
    [LabelWidth(150, UntilNext = true)]
    public int TradeOperationsId { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public string TradeOperationsClientCode { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public string TradeOperationsClientName { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public string TradeOperationsSymbol { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public decimal TradeOperationsVolume { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public decimal TradeOperationsPrice { get; set; }

    [DateTimeEditor]
    public DateTime TradeOperationsTradeDate { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public int TradeOperationsTariffId { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public string TradeOperationsStatus { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public string TradeOperationsNotes { get; set; }

    [DateTimeEditor]
    public DateTime TradeOperationsCreatedAt { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public decimal TradeOperationsTotalAmount { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public decimal TradeOperationsComissionAmount { get; set; }

    [LabelWidth(150, UntilNext = true)]
    public decimal TradeOperationsNetAmount { get; set; }

}
