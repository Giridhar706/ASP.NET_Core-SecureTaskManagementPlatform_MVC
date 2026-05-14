using Microsoft.AspNetCore.Mvc;

namespace SecureTaskManagementPlatform.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}