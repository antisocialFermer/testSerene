using FluentMigrator;

namespace testSerene.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20260920_1400)]
public class DefaultDB_20260920_1400_UserLastName : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Users").AddColumn("lastName").AsString().NotNullable().WithDefaultValue("");
    }
}
