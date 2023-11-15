using System;
using System.Collections.Generic;
using System.Text;
using Max.Angular.Localization;
using Volo.Abp.Application.Services;

namespace Max.Angular;

/* Inherit your application services from this class.
 */
public abstract class AngularAppService : ApplicationService
{
    protected AngularAppService()
    {
        LocalizationResource = typeof(AngularResource);
    }
}
