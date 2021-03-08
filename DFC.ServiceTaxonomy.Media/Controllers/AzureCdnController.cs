using Microsoft.AspNetCore.Mvc;
using OrchardCore.Admin;

namespace DFC.ServiceTaxonomy.Media.Controllers
{
    [Admin]
    public class AzureCdnController : Controller
    {
        public ActionResult PurgeCdn()
        {
            return View();
        }
    }
}
