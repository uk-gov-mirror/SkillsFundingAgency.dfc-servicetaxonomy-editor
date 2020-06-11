using Microsoft.AspNetCore.Mvc;
using OrchardCore.Admin;
using OrchardCore.ContentManagement;
using YesSql;

namespace DFC.ServiceTaxonomy.GraphLookup.Controllers
{
    public class ImportController
    {
        private readonly ISession _session;

        public ImportController(ISession session)
        {
            _session = session;
        }

        [Admin]
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public IActionResult CreateContentItems([FromBody]ContentItem contentItem)
        {
            _session.Save(contentItem);

            return new OkObjectResult("Ok");
        }
    }
}
