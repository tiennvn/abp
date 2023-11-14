using System;
using System.Collections.Generic;
using System.Text;
using New.Max.Localization;
using Volo.Abp.Application.Services;

namespace New.Max;

/* Inherit your application services from this class.
 */
public abstract class MaxAppService : ApplicationService
{
    protected MaxAppService()
    {
        LocalizationResource = typeof(MaxResource);
    }
}
