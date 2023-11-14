using Max.Pos.Samples;
using Xunit;

namespace Max.Pos.EntityFrameworkCore.Domains;

[Collection(PosTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PosEntityFrameworkCoreTestModule>
{

}
