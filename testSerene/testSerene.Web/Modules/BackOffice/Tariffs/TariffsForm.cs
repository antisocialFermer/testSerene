namespace testSerene.Modules.BackOffice;

[FormScript("BackOffice.Tariff")]
[BasedOnRow(typeof(TariffsRow), CheckNames = true)]
public class TariffsForm
{
    [LabelWidth(50, UntilNext = true)]
    public int TariffsId { get; set; }

    [LabelWidth(50, UntilNext = true)]
    public string TariffsCode { get; set; }

    [LabelWidth(200, UntilNext = true)]
    public string TariffsName { get; set; }

    [LabelWidth(100, UntilNext = true)]
    public decimal MonthlyFee { get; set; }

    [LabelWidth(100, UntilNext = true)]
    public decimal CommissionPercent { get; set; }

    [CheckboxFormatter]
    public bool IsActive { get; set; }

    [DateTimeEditor]
    public DateTime CreatedAt { get; set; }

}
