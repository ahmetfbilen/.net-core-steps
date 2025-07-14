using Microsoft.AspNetCore.Mvc;

namespace dotnet_first.Controllers
{
    public class CourseController : Controller
    {
        public string List()
        {
            return "List";
        }
        public string Details()
        {
            return "List";
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}