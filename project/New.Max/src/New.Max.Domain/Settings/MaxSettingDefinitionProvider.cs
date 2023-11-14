using Volo.Abp.Settings;

namespace New.Max.Settings;

public class MaxSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MaxSettings.MySetting1));
    }
}
