using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class TitleController : Controller
    {
        // GET: TitleController
        public ActionResult Index()
        {
            List<Blog> blogs = new List<Blog>();
           
            blogs.Add(new Blog("İklim Krizi", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "Alleben Rotaract"));

            blogs.Add(new Blog("Doğal Afet", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "Alice Cares"));

            blogs.Add(new Blog("Çocuk Hakları", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "Unicef"));

            blogs.Add(new Blog("Kadın Hakları", "Lorem10", "C:/Users\tunacan/Desktop/C#/kadın.jpg", "6284"));

            blogs.Add(new Blog("İnsan Hakları", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "United Nation"));

            blogs.Add(new Blog("Hayvan Hakları", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "Tunacan"));

            blogs.Add(new Blog("Eğitim Sistemi", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "Animal Rights Charity"));

           
            blogs.Add(new Blog("Hukuk Sistemi", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "Law"));

            blogs.Add(new Blog("Sağlık Sistemi", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "HealthCare"));

            blogs.Add(new Blog("Güvenlik", "Lorem10", "https://picsum.photos/seed/picsum/200/300", "Government Security Solutions"));








            return View(blogs);
        }

    }
}
