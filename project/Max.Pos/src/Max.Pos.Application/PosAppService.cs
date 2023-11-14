using System;
using System.Collections.Generic;
using System.Text;
using Max.Pos.Localization;
using Volo.Abp.Application.Services;

namespace Max.Pos;

/* Inherit your application services from this class.
 */
public abstract class PosAppService : ApplicationService
{
    protected PosAppService()
    {
        LocalizationResource = typeof(PosResource);
    }
}
