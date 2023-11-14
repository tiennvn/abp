using System;
using System.Collections.Generic;
using System.Text;
using Tizet.Pos.Localization;
using Volo.Abp.Application.Services;

namespace Tizet.Pos;

/* Inherit your application services from this class.
 */
public abstract class PosAppService : ApplicationService
{
    protected PosAppService()
    {
        LocalizationResource = typeof(PosResource);
    }
}
