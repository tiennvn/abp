using Volo.Abp.Modularity;

namespace New.Max;

/* Inherit from this class for your domain layer tests. */
public abstract class MaxDomainTestBase<TStartupModule> : MaxTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
