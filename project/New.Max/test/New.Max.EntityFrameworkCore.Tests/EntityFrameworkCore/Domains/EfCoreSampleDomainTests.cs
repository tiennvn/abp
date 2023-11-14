using New.Max.Samples;
using Xunit;

namespace New.Max.EntityFrameworkCore.Domains;

[Collection(MaxTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MaxEntityFrameworkCoreTestModule>
{

}
