using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ametyevo-village.Controllers;

namespace ametyevo-village.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ametyevo-villageControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
