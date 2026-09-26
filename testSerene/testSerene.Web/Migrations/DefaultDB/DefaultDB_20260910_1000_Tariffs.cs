using FluentMigrator;
namespace testSerene.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20260910_1000)]
public class DefaultDB_20260910_1000_Tariffs : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Tariffs")
            .WithColumn("TariffsId").AsInt32().IdentityKey(this)
            .WithColumn("TariffsCode").AsString().NotNullable()
            .WithColumn("TariffsName").AsString().NotNullable()
            .WithColumn("MonthlyFee").AsDecimal().NotNullable()
            .WithColumn("CommissionPercent").AsDecimal().NotNullable()
            .WithColumn("IsActive").AsBoolean().NotNullable()
            .WithColumn("CreatedAt").AsDateTime();
    }
}
