using Tizet.Pos.Samples;
using Xunit;

namespace Tizet.Pos.EntityFrameworkCore.Domains;

[Collection(PosTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PosEntityFrameworkCoreTestModule>
{

}
