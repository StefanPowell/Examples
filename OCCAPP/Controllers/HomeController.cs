using OCCAPP.Models;
using System.Reflection;
using System.Web.Mvc;

namespace OCCAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(StudentRequest request)
        {
            return View("Confirmation", request);
        }

    }
}