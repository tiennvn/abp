using Volo.Abp.Modularity;

namespace New.Max;

public abstract class MaxApplicationTestBase<TStartupModule> : MaxTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
