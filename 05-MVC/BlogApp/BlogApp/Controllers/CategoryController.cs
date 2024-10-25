using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class Category : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            ViewBag.Categories = new List<string>
        {
            "Kitap",
            "DVD",
            "Dergi"
        };
            return View();
        }

    }
}
