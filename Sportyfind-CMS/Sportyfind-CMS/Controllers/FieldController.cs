using Microsoft.AspNetCore.Mvc;

namespace Sportyfind_CMS.Controllers
{
    public class FieldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
