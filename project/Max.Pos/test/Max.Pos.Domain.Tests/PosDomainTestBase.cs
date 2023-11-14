using Volo.Abp.Modularity;

namespace Max.Pos;

/* Inherit from this class for your domain layer tests. */
public abstract class PosDomainTestBase<TStartupModule> : PosTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
