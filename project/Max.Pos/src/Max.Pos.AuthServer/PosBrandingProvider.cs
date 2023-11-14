﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Max.Pos;

[Dependency(ReplaceServices = true)]
public class PosBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Pos";
}
