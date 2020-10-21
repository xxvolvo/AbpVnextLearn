using System.Threading.Tasks;
using yxyl.leanr.Localization;
using Volo.Abp.UI.Navigation;

namespace yxyl.leanr.Blazor
{
    public class leanrMenuContributor : IMenuContributor
    {
        public Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if(context.Menu.DisplayName != StandardMenus.Main)
            {
                return Task.CompletedTask;
            }

            var l = context.GetLocalizer<leanrResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    "leanr.Home",
                    l["Menu:Home"],
                    "/",
                    icon: "fas fa-home"
                )
            );

            return Task.CompletedTask;
        }
    }
}
