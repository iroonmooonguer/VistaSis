using Microsoft.AspNetCore.Mvc;

namespace VistaSis.Controllers
{
    public class MedicalInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
