using Volo.Abp.Modularity;

namespace Tizet.Pos;

public abstract class PosApplicationTestBase<TStartupModule> : PosTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
