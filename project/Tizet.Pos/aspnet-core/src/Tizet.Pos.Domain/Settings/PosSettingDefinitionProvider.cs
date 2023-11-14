using Volo.Abp.Settings;

namespace Tizet.Pos.Settings;

public class PosSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PosSettings.MySetting1));
    }
}
