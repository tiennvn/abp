using System;
using System.Collections.Generic;
using System.Text;
using WiOn.Tizet.Localization;
using Volo.Abp.Application.Services;

namespace WiOn.Tizet;

/* Inherit your application services from this class.
 */
public abstract class TizetAppService : ApplicationService
{
    protected TizetAppService()
    {
        LocalizationResource = typeof(TizetResource);
    }
}
