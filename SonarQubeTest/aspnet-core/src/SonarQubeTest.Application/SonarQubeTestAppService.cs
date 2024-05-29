using System;
using System.Collections.Generic;
using System.Text;
using SonarQubeTest.Localization;
using Volo.Abp.Application.Services;

namespace SonarQubeTest;

/* Inherit your application services from this class.
 */
public abstract class SonarQubeTestAppService : ApplicationService
{
    protected SonarQubeTestAppService()
    {
        LocalizationResource = typeof(SonarQubeTestResource);
    }
}
