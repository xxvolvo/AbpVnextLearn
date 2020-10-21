using Xunit;

namespace yxyl.leanr.EntityFrameworkCore
{
    [CollectionDefinition(leanrTestConsts.CollectionDefinitionName)]
    public class leanrEntityFrameworkCoreCollection : ICollectionFixture<leanrEntityFrameworkCoreFixture>
    {

    }
}
