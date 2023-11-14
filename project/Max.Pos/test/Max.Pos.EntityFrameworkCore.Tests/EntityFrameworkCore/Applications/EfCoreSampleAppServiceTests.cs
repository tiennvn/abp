using Max.Pos.Samples;
using Xunit;

namespace Max.Pos.EntityFrameworkCore.Applications;

[Collection(PosTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PosEntityFrameworkCoreTestModule>
{

}
