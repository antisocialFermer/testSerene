using FluentMigrator;

namespace testSerene.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20260902_1200)]
public class DefaultDB_20260902_1200_AddInnAndPhone : AutoReversingMigration
{
    public override void Up()
    {
        Alter.Table("Users")
            .AddColumn("Inn").AsString(12).Nullable()
            .AddColumn("PhoneNumber").AsString(12).Nullable();
    }

}
