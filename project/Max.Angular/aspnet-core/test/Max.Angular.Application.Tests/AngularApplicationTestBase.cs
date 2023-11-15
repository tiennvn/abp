using Volo.Abp.Modularity;

namespace Max.Angular;

public abstract class AngularApplicationTestBase<TStartupModule> : AngularTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
