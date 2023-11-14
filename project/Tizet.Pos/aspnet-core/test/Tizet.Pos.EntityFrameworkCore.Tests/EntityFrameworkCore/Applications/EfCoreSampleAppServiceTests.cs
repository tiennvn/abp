using Tizet.Pos.Samples;
using Xunit;

namespace Tizet.Pos.EntityFrameworkCore.Applications;

[Collection(PosTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PosEntityFrameworkCoreTestModule>
{

}
