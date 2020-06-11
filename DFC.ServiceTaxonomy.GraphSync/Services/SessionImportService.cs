using System.Threading.Tasks;
using DFC.ServiceTaxonomy.GraphSync.Services.Interface;
using OrchardCore.ContentManagement;
using YesSql;

namespace DFC.ServiceTaxonomy.GraphSync.Services
{
    public class SessionImportService : ISessionImportService
    {
        private readonly ISession _session;

        public SessionImportService(ISession session)
        {
            _session = session;
        }

        public async Task Add(ContentItem contentItem)
        {
            _session.Save(contentItem);
        }
    }
}
