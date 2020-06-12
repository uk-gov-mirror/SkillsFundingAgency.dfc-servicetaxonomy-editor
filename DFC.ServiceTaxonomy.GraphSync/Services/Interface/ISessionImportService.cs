
using System.Threading.Tasks;
using OrchardCore.ContentManagement;
using YesSql;

namespace DFC.ServiceTaxonomy.GraphSync.Services.Interface
{
    public interface ISessionImportService
    {
        Task Add(ISession session, ContentItem contentItem);
    }
}
