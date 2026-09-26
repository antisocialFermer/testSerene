using FluentMigrator;
namespace testSerene.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20260914_1500)]
public class DefaultDB_20260914_1500_TradeOperations : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("TradeOperations")
            .WithColumn("TradeOperationsId").AsInt32().IdentityKey(this)
            .WithColumn("TradeOperationsClientCode").AsString().NotNullable()
            .WithColumn("TradeOperationsClientName").AsString().NotNullable()
            .WithColumn("TradeOperationsSymbol").AsString().NotNullable()
            .WithColumn("TradeOperationsSide").AsString().NotNullable()
            .WithColumn("TradeOperationsVolume").AsDecimal().NotNullable()
            .WithColumn("TradeOperationsPrice").AsDecimal().NotNullable()
            .WithColumn("TradeOperationsTradeDate").AsDateTime().NotNullable()
            .WithColumn("TradeOperationsTariffId").AsInt32().NotNullable().ForeignKey()
            .WithColumn("TradeOperationsStatus").AsString().NotNullable()
            .WithColumn("TradeOperationsNotes").AsString().NotNullable()
            .WithColumn("TradeOperationsCreatedAt").AsDateTime().NotNullable();
    }
}
