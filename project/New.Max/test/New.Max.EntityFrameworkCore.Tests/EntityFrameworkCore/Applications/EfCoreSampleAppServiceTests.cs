using New.Max.Samples;
using Xunit;

namespace New.Max.EntityFrameworkCore.Applications;

[Collection(MaxTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MaxEntityFrameworkCoreTestModule>
{

}
