using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class TextController : Controller
    {
        // GET: TextController
        public ActionResult Index()
        {

            List<BlogCard> blogs = new List<BlogCard>();
          
            blogs.Add(new BlogCard("İklim Krizi", "/image/iklim.jpg", "Dünya genelinde atmosferde meydana gelen dengesiz değişiklikler ve bunların ekosistem üzerindeki muzır etkilerini kapsayan geniş çaplı bir çevresel tehdittir."));

            blogs.Add(new BlogCard("Doğal Afet", "/image/afet.jpg", "Doğal afet veya Doğa kaynaklı afet büyük oranda veya tamamen insanların kontrolü dışında gerçekleşen, mal ve can kaybına neden olabilen, büyük ölçekli bir tehlike ve olay'dır." ));

            blogs.Add(new BlogCard("Çocuk Hakları", "/image/cocuk.jpg","Çocuk hakları, kanunen veya ahlaki olarak dünya üzerindeki tüm çocukların doğuştan sahip olduğu; eğitim, sağlık, yaşama, barınma; fiziksel, psikolojik veya cinsel sömürüye karşı korunma gibi haklarının hepsini birden tanımlamakta kullanılan evrensel kavramdır."  ));

            blogs.Add(new BlogCard("Kadın Hakları", "/image/kadın.jpg", "Kadın hakları, kadınların erkeklerle eşit şekilde sahip olduğu sosyoekonomik, siyasi ve yasal hakların tamamına verilen isim." ));

            blogs.Add(new BlogCard("İnsan Hakları", "/image/insna.jpg", "İnsan hakları, tüm insanların sadece insan olmakla sahip olduğu temel hak ve özgürlüklere denir. İnsan hakları; ırk, ulus, etnik köken, dış görünüş, din, dil, ense ve cinsiyet ayrımı gözetmeksizin tüm insanların yararlanabileceği haklardır. " ));

            blogs.Add(new BlogCard("Hayvan Hakları", "https://picsum.photos/id/237/200/300", "İnsan harici hayvanların tümünün ya da bir kısmının kendilerine ait bir özerkliğe sahip oldukları ve acıdan kaçınma gibi temel çıkarlarının tıpkı insanların temel çıkarlarının korunduğu gibi korunması gerektiğini savunan fikirdir."));

            blogs.Add(new BlogCard("Eğitim Sistemi", "/image/eğitim.jpg" , "Türkiye'de eğitim sistemi, Türkiye Cumhuriyeti Anayasasına ve 1739 sayılı Milli Eğitim Temel Kanununa dayanan; Milli Eğitim Bakanlığı ve bünyesindeki kamu tüzel üst sistemlerce yönetilen bir sistemdir."));


            blogs.Add(new BlogCard("Hukuk Sistemi", "/image/hukuk.jpg", "Birey, toplum ve devletin hareketlerini, birbirleriyle olan ilişkilerini; yetkili organlar tarafından usulüne uygun olarak çıkarılan, kamu gücüyle desteklenen, muhatabına genel olarak nasıl davranması yahut nasıl davranmaması gerektiğini gösteren ve bunun için ilgili bütün olasılıkları yürürlükte olan normlarla düzenleyen normatif bir bilimdir." ));

            blogs.Add(new BlogCard("Sağlık Sistemi", "/image/sağlık.png", "Türkiye'de sağlık hizmetleri kamu ve özel sağlık hizmetlerinin bir karışımından oluşmaktadır." ));

            blogs.Add(new BlogCard("Güvenlik", "/image/guvenlik.jpg", "Güvenlik; toplum yaşamında yasal düzenin aksamadan yürütülmesi, kişilerin korkusuzca yaşayabilmesi durumudur."));








            return View(blogs);
        }



    }
}
