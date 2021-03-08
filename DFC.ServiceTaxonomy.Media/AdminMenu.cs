using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;
using OrchardCore.Navigation;

namespace DFC.ServiceTaxonomy.Media
{
    public class AdminMenu : INavigationProvider
    {
        private readonly IStringLocalizer S;

        public AdminMenu(IStringLocalizer<AdminMenu> localizer)
        {
            S = localizer;
        }

        public Task BuildNavigationAsync(string name, NavigationBuilder builder)
        {
            if (!String.Equals(name, "admin", StringComparison.OrdinalIgnoreCase))
            {
                return Task.CompletedTask;
            }

            builder
                .Add(S["Content"], config => config
                .Add(S["Purge CDN"], S["Menu"].PrefixPosition(), purgeCdn => purgeCdn
                    .Action("PurgeCdn", "AzureCdn", new { area = "DFC.ServiceTaxonomy.Media" })));

            return Task.CompletedTask;
        }
    }
}
