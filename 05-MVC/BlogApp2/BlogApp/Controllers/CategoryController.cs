using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {

            // ViewBag.Name = "Sanat", "Bilim", "Spor";
            // ViewBag.Description = "Lorem";
            List<Categories> categories = new List<Categories>();
            categories.Add(new Categories("Sanat", "Lorem"));
            categories.Add(new Categories("Edebiyat", "Lorem"));
            categories.Add(new Categories("Bilim", "Lorem"));


            ViewBag.Categories = categories;

            return View();
        }

        

    }
}
