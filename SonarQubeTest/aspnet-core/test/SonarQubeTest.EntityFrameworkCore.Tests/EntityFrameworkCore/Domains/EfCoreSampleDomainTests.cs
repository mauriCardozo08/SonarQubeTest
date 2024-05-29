using SonarQubeTest.Samples;
using Xunit;

namespace SonarQubeTest.EntityFrameworkCore.Domains;

[Collection(SonarQubeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SonarQubeTestEntityFrameworkCoreTestModule>
{

}
