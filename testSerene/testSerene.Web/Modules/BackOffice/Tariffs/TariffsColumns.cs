namespace testSerene.Modules.BackOffice.Tariffs;

[ColumnsScript("BackOffice.Tariff")]
[BasedOnRow(typeof(TariffsRow), CheckNames = true)]
public class TariffsColumns
{
    [DisplayName("Id"), EditLink, AlignRight, Width(50)]
    public int TariffsId { get; set; }

    [DisplayName("Код"), Width(100)]
    public string TariffsCode { get; set; }

    [DisplayName("Название тарифа"),EditLink, Width(150)]
    public string TariffsName { get; set; }

    [DisplayName("Ежемесячный налог"), Width(120)]
    public decimal MonthlyFee {  get; set; }

    [DisplayName("Процент комиссии"),Width(120)]
    public decimal CommissionPercent {  get; set; }

    [DisplayName("Активный / Неактивный"), CheckboxFormatter, Width(150)]
    public bool IsActive {  get; set; }

    [DisplayName("Дата создания"),DateTimeEditor, Width(120)]
    public DateTime CreatedAt {  get; set; }


}
