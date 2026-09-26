using FluentMigrator;

namespace testSerene.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20260902_1300)]
public class DefaultDB_20260902_1300_Projects : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Projects")
            .WithColumn("ProjectId").AsInt32().IdentityKey(this)
            .WithColumn("ProjectName").AsString(25).NotNullable()
            .WithColumn("ProjectDescription").AsString().Nullable()
            .WithColumn("ProjectStartDate").AsDate().NotNullable()
            .WithColumn("ProjectEndDate").AsDate().NotNullable();
    }

}
