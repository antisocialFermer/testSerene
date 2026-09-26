namespace testSerene.Modules.BackOffice;

[ConnectionKey("Default"), Module("BackOffice"), TableName("TradeOperations")]
[DisplayName("TradeOperations"), InstanceName("TradeOperation")]
[ReadPermission(BackOfficePermissionKeys.Security)]
[ModifyPermission(BackOfficePermissionKeys.Security)]
[LookupScript(Permission = BackOfficePermissionKeys.Security)]
public class TradeOperationsRow : Row<TradeOperationsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("TradeOperations Id"), Identity, IdProperty]
    public int? TradeOperationsId { get => fields.TradeOperationsId[this]; set => fields.TradeOperationsId[this] = value; }

    [DisplayName("TradeOperations ClientCode"), NotNull, Size(50)]
    public string TradeOperationsClientCode { get => fields.TradeOperationsClientCode[this]; set => fields.TradeOperationsClientCode[this] = value; }

    [DisplayName("TradeOperations ClientName"), NotNull, Size(200), NameProperty]
    public string TradeOperationsClientName { get => fields.TradeOperationsClientName[this]; set => fields.TradeOperationsClientName[this] = value; }

    [DisplayName("TradeOperations Symbol"), NotNull, Size(20)]
    public string TradeOperationsSymbol { get => fields.TradeOperationsSymbol[this]; set => fields.TradeOperationsSymbol[this] = value; }

    [DisplayName("TradeOperations Side"), NotNull, Size(4)]
    public string TradeOperationsSide { get => fields.TradeOperationsSide[this]; set => fields.TradeOperationsSide[this] = value; }

    [DisplayName("TradeOperations Volume"), NotNull]
    public decimal? TradeOperationsVolume { get => fields.TradeOperationsVolume[this]; set => fields.TradeOperationsVolume[this] = value; }

    [DisplayName("TradeOperations Price"), NotNull]
    public decimal? TradeOperationsPrice { get => fields.TradeOperationsPrice[this]; set => fields.TradeOperationsPrice[this] = value; }

    [DisplayName("TradeOperations TradeDate"), NotNull]
    public DateTime? TradeOperationsTradeDate { get => fields.TradeOperationsTradeDate[this]; set => fields.TradeOperationsTradeDate[this] = value; }

    [DisplayName("TradeOperations TariffId"), NotNull]
    public int? TradeOperationsTariffId { get => fields.TradeOperationsTariffId[this]; set => fields.TradeOperationsTariffId[this] = value; }

    [DisplayName("TradeOperations Status"), NotNull, Size(20)]
    public string TradeOperationsStatus { get => fields.TradeOperationsStatus[this]; set => fields.TradeOperationsStatus[this] = value; }

    [DisplayName("TradeOperations Notes"), NotNull, Size(1000)]
    public string TradeOperationsNotes { get => fields.TradeOperationsNotes[this]; set => fields.TradeOperationsNotes[this] = value; }

    [DisplayName("TradeOperations CreatedAt"), NotNull]
    public DateTime? TradeOperationsCreatedAt { get => fields.TradeOperationsCreatedAt[this]; set => fields.TradeOperationsCreatedAt[this] = value; }

    [DisplayName("TradeOperations TotalAmount"), NotNull, ReadOnly(true)]
    public decimal? TradeOperationsTotalAmount { get => fields.TradeOperationsTotalAmount[this]; set => fields.TradeOperationsTotalAmount[this] = value; }

    [DisplayName("TradeOperations CommissionAmount"), NotNull, ReadOnly(true)]
    public decimal? TradeOperationsCommissionAmount { get => fields.TradeOperationsCommissionAmount[this]; set => fields.TradeOperationsCommissionAmount[this] = value; }

    [DisplayName("TradeOperations NetAmount"), NotNull, ReadOnly(true)]
    public decimal? TradeOperationsNetAmount { get => fields.TradeOperationsNetAmount[this]; set => fields.TradeOperationsNetAmount[this] = value; }
    public class RowFields : RowFieldsBase
    {
        public Int32Field TradeOperationsId;
        public StringField TradeOperationsClientCode;
        public StringField TradeOperationsClientName;
        public StringField TradeOperationsSymbol;
        public StringField TradeOperationsSide;
        public DecimalField TradeOperationsVolume;
        public DecimalField TradeOperationsPrice;
        public DateTimeField TradeOperationsTradeDate;
        public Int32Field TradeOperationsTariffId;
        public StringField TradeOperationsStatus;
        public StringField TradeOperationsNotes;
        public DateTimeField TradeOperationsCreatedAt;
        public DecimalField TradeOperationsTotalAmount;
        public DecimalField TradeOperationsCommissionAmount;
        public DecimalField TradeOperationsNetAmount;
    }
}
