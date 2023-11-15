using Volo.Abp.Modularity;

namespace Max.Angular;

/* Inherit from this class for your domain layer tests. */
public abstract class AngularDomainTestBase<TStartupModule> : AngularTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
