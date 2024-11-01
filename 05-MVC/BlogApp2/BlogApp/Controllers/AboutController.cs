using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {

            Resume resume = new Resume("Tunacan", "Eşki", "tues@hotmail.com", new List<string>{
                "MLP - Uzman - 2016-2018",
                "KOÇ - Uzman - 2020-2024"
            });
          
            return View(resume);
        }

    }
}
