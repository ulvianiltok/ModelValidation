using Microsoft.AspNetCore.Mvc;
using MOdelValidation.Models;

namespace MOdelValidation.Controllers
{
    public class KullaniciController : Controller
    {
        [HttpGet]
        public IActionResult Ekle(Kullanici kullanici)
        {
            return View(kullanici);
        }
       
 
    }
}
