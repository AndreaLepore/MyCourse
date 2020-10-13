using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Sono Index");
        }
        public IActionResult Detail(string id)
        {
            return Content($"Cono Detail ho ricevuto I'id {id}");
        }
        public IActionResult Search(string title)
        {
            return Content($"Hai cercato {title}");
        }
    }
}