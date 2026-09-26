namespace testSerene.Modules.BackOffice.TradeOperations;

[ColumnsScript("BackOffice.TradeOperation")]
[BasedOnRow(typeof(TradeOperationsRow), CheckNames = true)]
public class TradeOperationsColumns
{
    [DisplayName("Id"), EditLink, AlignRight, Width(50)]
    public int TradeOperationsColumnsId { get; set; }

    [DisplayName("Код клиента"), AlignRight, Width(120)]
    public string TradeOperationsClientCode { get; set; }

    [DisplayName("Имя клиента"), EditLink, AlignRight, Width(150)]
    public string TradeOperationsClientName { get; set; }

    [DisplayName("Тикер бумаги (AAPL, GAZP, SBER)"), AlignRight, Width(210)]
    public string TradeOperationsSymbol { get; set; }

    [DisplayName("Buy или Sell"), AlignRight, Width(100)]
    public string TradeOperationsSide { get; set; }

    [DisplayName("Количество лотов"), AlignRight, Width(100)]
    public decimal TradeOperationsVolume { get; set; }

    [DisplayName("Цена за единицу"), AlignRight, Width(100)]
    public decimal TradeOperationsPrice { get; set; }

    [DisplayName("Дата сделки"), AlignRight, Width(150)]
    public DateTime TradeOperationsTradeDate { get; set; }

    [DisplayName("тариф, по которому считается комиссия"), AlignRight, Width(200)]
    public int TradeOperationsTariffId { get; set; }

    [DisplayName("Статус"), AlignRight, Width(50)]
    public string TradeOperationsStatus { get; set; }

    [DisplayName("Комментарий "), AlignRight, Width(200)]
    public string TradeOperationsNotes { get; set; }

    [DisplayName("Дата создания записи"), AlignRight, Width(150)]
    public DateTime TradeOperationsCreatedAt { get; set; }

    [DisplayName("Общая сумма"), AlignRight, Width(50)]
    public decimal TradeOperationsTotalAmount { get; set; }

    [DisplayName("Сумма коммиссии"), AlignRight, Width(50)]
    public decimal TradeOperationsCommissionAmount { get; set; }

    [DisplayName("Чистая сумма"), AlignRight, Width(50)]
    public decimal TradeOperationsNetAmount { get; set; }

}
