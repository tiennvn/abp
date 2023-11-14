using Volo.Abp.Modularity;

namespace Max.Pos;

public abstract class PosApplicationTestBase<TStartupModule> : PosTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
