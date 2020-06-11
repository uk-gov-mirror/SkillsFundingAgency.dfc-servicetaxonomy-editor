using System;
using System.Threading.Tasks;
using DFC.ServiceTaxonomy.GraphSync.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;

namespace DFC.ServiceTaxonomy.GraphSync.Services
{
    public class SessionImportService : ISessionImportService
    {
        private readonly IServiceProvider _serviceProvider;

        public SessionImportService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Add(ContentItem contentItem)
        {
            await Task.Run(() =>
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var session = scope.ServiceProvider.GetRequiredService<YesSql.ISession>();
                    session.Save(contentItem);
                }
            });

        }
    }
}
