using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload(){

            var file = Request.Form.Files[0];

            // Dosya kontrolü
            if (file != null && file.ContentType == "application/pdf")
            {
                // Dosya yolu
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/cvs", file.FileName);

                // Dosyayı kaydetme
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                // Başarılı yükleme sonrası yönlendirme veya mesaj
                return Content("CV başarıyla yüklendi!");
            }

            return Content("Lütfen geçerli bir PDF dosyası yükleyin.");
        }

    }
}
