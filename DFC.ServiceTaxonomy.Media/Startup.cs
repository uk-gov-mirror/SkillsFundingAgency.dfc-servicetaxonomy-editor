using System;
using DFC.ServiceTaxonomy.Media.Drivers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Settings;

namespace DFC.ServiceTaxonomy.Media
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<INavigationProvider, AdminMenu>();
            services.AddScoped<IDisplayDriver<ISite>, MediaCdnSettingsDisplayDriver>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            routes.MapAreaControllerRoute(
                name: "AzureCdn",
                areaName: "DFC.ServiceTaxonomy.Media",
                pattern: "AzureCdn/PurgeCdn",
                defaults: new { controller = "AzureCdn", action = "PurgeCdn" }
            );
        }
    }
}
