using yxyl.leanr.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace yxyl.leanr.Permissions
{
    public class leanrPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(leanrPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(leanrPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<leanrResource>(name);
        }
    }
}
