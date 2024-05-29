using SonarQubeTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SonarQubeTest.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SonarQubeTestController : AbpControllerBase
{
    protected SonarQubeTestController()
    {
        LocalizationResource = typeof(SonarQubeTestResource);
    }
}
