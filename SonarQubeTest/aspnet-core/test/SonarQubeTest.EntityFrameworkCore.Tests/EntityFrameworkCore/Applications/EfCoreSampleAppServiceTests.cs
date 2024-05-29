using SonarQubeTest.Samples;
using Xunit;

namespace SonarQubeTest.EntityFrameworkCore.Applications;

[Collection(SonarQubeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SonarQubeTestEntityFrameworkCoreTestModule>
{

}
