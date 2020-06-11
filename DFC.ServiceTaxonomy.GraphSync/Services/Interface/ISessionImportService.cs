
using System.Threading.Tasks;
using OrchardCore.ContentManagement;

namespace DFC.ServiceTaxonomy.GraphSync.Services.Interface
{
    public interface ISessionImportService
    {
        Task Add(ContentItem contentItem);
    }
}
