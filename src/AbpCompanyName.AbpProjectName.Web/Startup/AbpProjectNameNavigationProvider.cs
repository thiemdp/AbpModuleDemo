using Abp.Application.Navigation;
using Abp.Localization;

namespace AbpCompanyName.AbpProjectName.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class AbpProjectNameNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
           // var menu = context.Manager.Menus["Module"] = new MenuDefinition("Module", new FixedLocalizableString("Module Menu"));
            context.Manager.MainMenu
                //  .AddItem(
                //    new MenuItemDefinition(
                //        PageNames.Home,
                //        L("HomePage"),
                //        url: "",
                //        icon: "fa fa-home"
                //        )
                //)
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "About",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpProjectNameConsts.LocalizationSourceName);
        }
    }
}
