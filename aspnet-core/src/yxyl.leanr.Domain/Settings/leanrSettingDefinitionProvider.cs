using Volo.Abp.Settings;

namespace yxyl.leanr.Settings
{
    public class leanrSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(leanrSettings.MySetting1));
        }
    }
}
