namespace testSerene.Modules.BackOffice;

[ConnectionKey("Default"), Module("BackOffice"), TableName("Tariffs")]
[DisplayName("Tariffs"), InstanceName("Tariff")]
[ReadPermission(BackOfficePermissionKeys.Security)]
[ModifyPermission(BackOfficePermissionKeys.Security)]
[LookupScript(Permission = BackOfficePermissionKeys.Security)]
public class TariffsRow : Row<TariffsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Tariffs Id"), Identity, IdProperty]
    public int? TariffsId { get => fields.TariffsId[this]; set => fields.TariffsId[this] = value; }

    [DisplayName("Tariffs Code"), NotNull, Size(50)]
    public string TariffsCode { get => fields.TariffsCode[this]; set => fields.TariffsCode[this] = value; }

    [DisplayName("Tariffs Name"), NotNull, Size(200), NameProperty]
    public string TariffsName { get => fields.TariffsName[this]; set => fields.TariffsName[this] = value; }

    [DisplayName("Tariffs MonthlyFee"), NotNull]
    public decimal? MonthlyFee { get => fields.MonthlyFee[this]; set => fields.MonthlyFee[this] = value; }

    [DisplayName("Tariffs CommissionPercent"), NotNull]
    public decimal? CommissionPercent { get => fields.CommissionPercent[this]; set => fields.CommissionPercent[this] = value; }

    [DisplayName("Tariff is Active"), NotNull]
    public bool? IsActive { get => fields.IsActive[this]; set=>fields.IsActive[this] = value;}

    [DisplayName("Tariff Created at")]
    public DateTime? CreatedAt { get => fields.CreatedAt[this]; set => fields.CreatedAt[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field TariffsId;
        public StringField TariffsCode;
        public StringField TariffsName;
        public DecimalField MonthlyFee;
        public DecimalField CommissionPercent;
        public BooleanField IsActive;
        public DateTimeField CreatedAt;
    }
}
