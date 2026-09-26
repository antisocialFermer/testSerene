using MyRow = testSerene.Administration.RoleRow;

namespace testSerene.Administration;

public interface IRoleSaveHandler : ISaveHandler<MyRow> { }

public class RoleSaveHandler(IRequestContext context)
    : SaveRequestHandler<MyRow>(context), IRoleSaveHandler
{
    protected override void InvalidateCacheOnCommit()
    {
        base.InvalidateCacheOnCommit();

        Cache.InvalidateOnCommit(UnitOfWork, UserPermissionRow.Fields);
        Cache.InvalidateOnCommit(UnitOfWork, RolePermissionRow.Fields);
    }
}