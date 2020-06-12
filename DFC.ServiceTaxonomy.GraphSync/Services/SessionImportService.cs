using System;
using System.Threading.Tasks;
using DFC.ServiceTaxonomy.GraphSync.Services.Interface;
using OrchardCore.ContentManagement;
using YesSql;

namespace DFC.ServiceTaxonomy.GraphSync.Services
{
    public class SessionImportService : ISessionImportService
    {
        private readonly IServiceProvider _serviceProvider;

        public SessionImportService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task Add(ISession session, ContentItem contentItem)
        {
            await Task.Run(() =>
            {
                session.Save(contentItem);

            });

        }
    }
}
