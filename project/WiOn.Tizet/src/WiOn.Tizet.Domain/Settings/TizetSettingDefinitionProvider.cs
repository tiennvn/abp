using Volo.Abp.Settings;

namespace WiOn.Tizet.Settings;

public class TizetSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TizetSettings.MySetting1));
    }
}
