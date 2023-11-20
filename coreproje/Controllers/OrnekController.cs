using Microsoft.AspNetCore.Mvc;

namespace coreproje.Controllers
{
    public class Product2
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Asp.Net Core";
            ViewData["age"] = 30;
            ViewData["names"] = new List<string>() { "alparslan", "" };
            ViewBag.person = new { id = 1, name = "alparslan", age = 25 };
            var productList = new List<Product2>()
            {
            new (){Id=1, Name ="alparslan"},
            new (){Id=2, Name ="simge"}
            };
            return View(productList);
        }

        public IActionResult Index3()
        {
            TempData["surname"] = "yüce";  
            return View();
        }

        //redirectoaction kullanımı
        public IActionResult Index2()
        {
            return RedirectToAction("Index","Ornek");
        }

        //parametre tanımlama 
        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre", "Ornek", new { id = id });
        }


        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id});
        }

        //contentresult kullanımı
        public IActionResult ContentResult()
        {
            return Content("contentresult");
        }

        //json result kullanımı
        public IActionResult JsonResult()
        {
            return Json(new { id = 1,name= "kalem", price = 100 });
        }

        //empty result kullanımı
        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
