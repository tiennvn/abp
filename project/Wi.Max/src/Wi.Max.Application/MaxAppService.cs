using System;
using System.Collections.Generic;
using System.Text;
using Wi.Max.Localization;
using Volo.Abp.Application.Services;

namespace Wi.Max;

/* Inherit your application services from this class.
 */
public abstract class MaxAppService : ApplicationService
{
    protected MaxAppService()
    {
        LocalizationResource = typeof(MaxResource);
    }
}
